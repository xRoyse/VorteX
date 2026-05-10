using System;
using System.Drawing;
using System.Windows.Forms;

namespace VorteX___Calculator_for_IT_companies
{
    public partial class Form2 : Form
    {
        private readonly Employee _emp;

        // Поле ввода нового оклада (создаём программно, размещаем на panelKeyboard)
        private TextBox txtNewSalary;
        private Button btnApply;
        private Label lblHint;

        public Form2(Employee emp)
        {
            _emp = emp;
            InitializeComponent();
        }

        // ── Загрузка формы ────────────────────────────────────────────────────
        private void Form2_Load(object sender, EventArgs e)
        {
            // Заполнить левую панель данными сотрудника
            lblEmployeeName.Text = _emp.Name;
            lblInpSalaryVal.Text = _emp.Gross.ToString("N0") + " ₽";
            lblInpSalaryTag.Text = $"НДФЛ {_emp.TaxRate * 100:0}%";
            lblInpPosVal.Text = _emp.Dept;
            lblInpLevelVal.Text = _emp.Level;
            lblInpLevelBadge.Text = LevelBadge(_emp.Level);
            lblInpDeptVal.Text = _emp.Dept;
            lblInpPeriodVal.Text = DateTime.Now.ToString("MMMM yyyy");

            // Скрыть кнопки-калькулятор, разместить поле ввода
            BuildInputArea();

            // Показать расчёт
            ShowCalculation(_emp.Gross);
        }

        // ── Заменяем panelKeyboard на поле ввода ──────────────────────────────
        private void BuildInputArea()
        {
            // Скрываем все кнопки калькулятора
            panelKeyboard.Controls.Clear();
            panelKeyboard.BackColor = Color.FromArgb(20, 20, 20);

            // Заголовок
            lblHint = new Label
            {
                Text = "Введите новый оклад (₽) и нажмите «Применить» или Enter:",
                Location = new Point(12, 14),
                Size = new Size(610, 18),
                ForeColor = Color.FromArgb(120, 120, 120),
                Font = new Font("Segoe UI", 8.5f),
            };

            // Поле ввода
            txtNewSalary = new TextBox
            {
                Location = new Point(12, 38),
                Size = new Size(420, 28),
                Font = new Font("Segoe UI", 13f),
                BackColor = Color.FromArgb(35, 35, 35),
                ForeColor = Color.FromArgb(245, 230, 66),
                BorderStyle = BorderStyle.FixedSingle,
                Text = _emp.Gross.ToString("N0"),
            };
            txtNewSalary.KeyDown += TxtNewSalary_KeyDown;

            // Кнопка «Применить»
            btnApply = new Button
            {
                Text = "Применить",
                Location = new Point(444, 36),
                Size = new Size(120, 30),
                BackColor = Color.FromArgb(245, 230, 66),
                ForeColor = Color.FromArgb(17, 17, 17),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold),
            };
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.Click += (s, e) => ApplyNewSalary();

            panelKeyboard.Controls.AddRange(new Control[] { lblHint, txtNewSalary, btnApply });
        }

        // ── Enter в поле ввода = Применить ───────────────────────────────────
        private void TxtNewSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyNewSalary();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        // ── Применить новый оклад ─────────────────────────────────────────────
        private void ApplyNewSalary()
        {
            string raw = txtNewSalary.Text.Trim()
                                     .Replace(" ", "")
                                     .Replace("\u00a0", "")   // неразрывный пробел
                                     .Replace("₽", "")
                                     .Replace(",", ".");

            if (!decimal.TryParse(raw,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out decimal gross) || gross <= 0)
            {
                MessageBox.Show("Введите корректное число больше 0.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewSalary.Focus();
                return;
            }

            _emp.Gross = gross;   // сохраняем — Form1 увидит изменение

            // Обновляем левую панель
            lblInpSalaryVal.Text = gross.ToString("N0") + " ₽";
            lblInpSalaryTag.Text = $"НДФЛ {_emp.TaxRate * 100:0}%";

            // Пересчитываем таблицу
            ShowCalculation(gross);

            // Показываем актуальное значение в поле (форматируем)
            txtNewSalary.Text = gross.ToString("N0");
        }

        // ── Таблица расчёта (правая панель) ──────────────────────────────────
        private void ShowCalculation(decimal gross)
        {
            decimal taxRate = _emp.TaxRate;
            decimal taxAmt = Math.Round(gross * taxRate);
            decimal net = gross - taxAmt;
            decimal insurance = Math.Round(gross * 0.30m);   // взносы — для справки

            // Строки расчёта
            lblRow0Key.Text = "Оклад (брутто)";
            lblRow0Val.Text = gross.ToString("N0") + " ₽";

            lblRow1Key.Text = $"НДФЛ ({taxRate * 100:0}%)";
            lblRow1Val.Text = "−" + taxAmt.ToString("N0") + " ₽";

            lblRow2Key.Text = "На руки (нетто)";
            lblRow2Val.Text = net.ToString("N0") + " ₽";

            lblRow3Key.Text = "Страховые взносы (30%)";
            lblRow3Val.Text = insurance.ToString("N0") + " ₽";

            lblRow4Key.Text = "Расходы работодателя";
            lblRow4Val.Text = (gross + insurance).ToString("N0") + " ₽";

            lblRow5Key.Text = "Ставка НДФЛ";
            lblRow5Val.Text = $"{taxRate * 100:0}%  " +
                              (taxRate == 0.15m ? "(доход > 2,4 млн/год)" : "(стандартная)");

            // Итог
            lblTotalKey.Text = "ИТОГО «ЧИСТЫМИ»";
            lblTotalSub.Text = $"НДФЛ {taxRate * 100:0}% = {taxAmt:N0} ₽";
            lblTotalVal.Text = net.ToString("N0") + " ₽";

            // Мини-дисплей слева
            lblNetAmount.Text = net.ToString("N0");
            lblNetSub.Text = $"₽ / месяц · после НДФЛ {taxRate * 100:0}%";
        }

        // ── Вспомогательные ───────────────────────────────────────────────────
        private string LevelBadge(string level)
        {
            switch (level)
            {
                case "Junior": return "L1";
                case "Middle": return "L3";
                case "Senior": return "L5";
                default: return "—";
            }
        }

        // пустой обработчик из дизайнера
        private void panelTotal_Paint(object sender, PaintEventArgs e) { }
    }
}