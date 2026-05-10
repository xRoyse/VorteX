using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VorteX___Calculator_for_IT_companies
{
    // ── Модель ────────────────────────────────────────────────────────────────
    public class Employee
    {
        public string Name { get; set; }
        public decimal Gross { get; set; }   // оклад до вычета налога
        public string Dept { get; set; }   // Backend / Frontend / DevOps / QA
        public string Level { get; set; }   // Junior / Middle / Senior

        // 13% если годовой доход < 2 400 000 руб., иначе 15%
        public decimal TaxRate => (Gross * 12) >= 2_400_000m ? 0.15m : 0.13m;
        public decimal TaxAmt => Math.Round(Gross * TaxRate);
        public decimal Net => Gross - TaxAmt;
    }

    // ── Form1 ─────────────────────────────────────────────────────────────────
    public partial class Form1 : Form
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
            WireEvents();
            RefreshList();
        }

        // ── Подписка на события ───────────────────────────────────────────────
        private void WireEvents()
        {
            // Поиск — placeholder
            txtSearch.GotFocus += (s, e) =>
            {
                if (txtSearch.Text == "Поиск...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.FromArgb(220, 220, 220);
                }
            };
            txtSearch.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Поиск...";
                    txtSearch.ForeColor = Color.FromArgb(100, 100, 100);
                }
            };
            txtSearch.TextChanged += (s, e) => RefreshList();

            // Фильтры по отделу
            rbDeptAll.CheckedChanged += (s, e) => RefreshList();
            rbDeptBackend.CheckedChanged += (s, e) => RefreshList();
            rbDeptFrontend.CheckedChanged += (s, e) => RefreshList();
            rbDeptDevOps.CheckedChanged += (s, e) => RefreshList();

            // Фильтры по уровню
            rbLevelAll.CheckedChanged += (s, e) => RefreshList();
            rbLevelJunior.CheckedChanged += (s, e) => RefreshList();
            rbLevelMiddle.CheckedChanged += (s, e) => RefreshList();
            rbLevelSenior.CheckedChanged += (s, e) => RefreshList();

            // Кнопки
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnCalc.Click += BtnCalc_Click;
        }

        // ── Фильтрация и отрисовка списка ─────────────────────────────────────
        private void RefreshList()
        {
            string search = txtSearch.Text == "Поиск..." ? "" : txtSearch.Text.Trim().ToLower();

            string dept = rbDeptBackend.Checked ? "Backend"
                         : rbDeptFrontend.Checked ? "Frontend"
                         : rbDeptDevOps.Checked ? "DevOps"
                         : "";

            string level = rbLevelJunior.Checked ? "Junior"
                         : rbLevelMiddle.Checked ? "Middle"
                         : rbLevelSenior.Checked ? "Senior"
                         : "";

            var filtered = _employees
                .Where(e => string.IsNullOrEmpty(search) || e.Name.ToLower().Contains(search))
                .Where(e => string.IsNullOrEmpty(dept) || e.Dept == dept)
                .Where(e => string.IsNullOrEmpty(level) || e.Level == level)
                .ToList();

            lvEmployees.Items.Clear();
            foreach (var emp in filtered)
            {
                var item = new ListViewItem(emp.Name);
                item.SubItems.Add(emp.Gross.ToString("N0") + " ₽");
                item.SubItems.Add(emp.Net.ToString("N0") + " ₽");
                item.SubItems.Add(emp.Dept);
                item.SubItems.Add(emp.Level);
                item.Tag = emp;
                lvEmployees.Items.Add(item);
            }

            UpdateStats(filtered);
        }

        // ── Статистика в сайдбаре ─────────────────────────────────────────────
        private void UpdateStats(List<Employee> list)
        {
            lblStatEmpVal.Text = list.Count.ToString();
            lblStatSalaryVal.Text = list.Count == 0 ? "—"
                                  : list.Average(e => e.Gross).ToString("N0") + " ₽";
            lblStatFundVal.Text = list.Count == 0 ? "—"
                                  : list.Sum(e => e.Net).ToString("N0") + " ₽";
        }

        // ── Добавить сотрудника ───────────────────────────────────────────────
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new AddEmployeeDialog())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _employees.Add(dlg.Result);
                    RefreshList();
                }
            }
        }

        // ── Удалить сотрудника ────────────────────────────────────────────────
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника в списке.", "Удаление",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var emp = (Employee)lvEmployees.SelectedItems[0].Tag;
            if (MessageBox.Show($"Удалить «{emp.Name}»?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _employees.Remove(emp);
                RefreshList();
            }
        }

        // ── Открыть Form2 для расчёта ─────────────────────────────────────────
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (lvEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника в списке.", "Расчёт",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var emp = (Employee)lvEmployees.SelectedItems[0].Tag;
            using (var f2 = new Form2(emp))
                f2.ShowDialog(this);

            RefreshList();   // зарплата могла измениться в Form2
        }

        // пустой обработчик из дизайнера
        private void lblLevelSection_Click(object sender, EventArgs e) { }
    }

    // ── Диалог «Новый сотрудник» ──────────────────────────────────────────────
    internal class AddEmployeeDialog : Form
    {
        public Employee Result { get; private set; }

        private TextBox txtName;
        private TextBox txtSalary;
        private ComboBox cbDept;
        private ComboBox cbLevel;

        public AddEmployeeDialog()
        {
            Text = "Новый сотрудник";
            ClientSize = new Size(310, 240);
            BackColor = Color.FromArgb(22, 22, 22);
            ForeColor = Color.FromArgb(220, 220, 220);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            Font = new Font("Segoe UI", 9f);

            int y = 16;

            MakeLabel("Имя сотрудника", 14, y);
            txtName = MakeTextBox(14, y + 18, 282);
            y += 52;

            MakeLabel("Оклад, ₽ (до налогов)", 14, y);
            txtSalary = MakeTextBox(14, y + 18, 282);
            y += 52;

            MakeLabel("Отдел", 14, y);
            cbDept = MakeCombo(14, y + 18, 134, new[] { "Backend", "Frontend", "DevOps", "QA" });

            MakeLabel("Уровень", 162, y);
            cbLevel = MakeCombo(162, y + 18, 134, new[] { "Junior", "Middle", "Senior" });
            y += 52;

            var btnOk = new Button
            {
                Text = "Добавить",
                Location = new Point(14, y),
                Size = new Size(134, 30),
                BackColor = Color.FromArgb(245, 230, 66),
                ForeColor = Color.FromArgb(17, 17, 17),
                FlatStyle = FlatStyle.Flat,
            };
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.Click += BtnOk_Click;

            var btnCancel = new Button
            {
                Text = "Отмена",
                Location = new Point(162, y),
                Size = new Size(134, 30),
                BackColor = Color.FromArgb(40, 40, 40),
                ForeColor = Color.FromArgb(200, 200, 200),
                FlatStyle = FlatStyle.Flat,
                DialogResult = DialogResult.Cancel,
            };
            btnCancel.FlatAppearance.BorderSize = 0;

            Controls.AddRange(new Control[] { btnOk, btnCancel });
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { MessageBox.Show("Введите имя сотрудника."); return; }

            // принимаем и запятую и точку как разделитель дробной части
            string raw = txtSalary.Text.Trim().Replace(" ", "").Replace(",", ".");
            if (!decimal.TryParse(raw,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out decimal gross) || gross <= 0)
            { MessageBox.Show("Введите корректный оклад (число больше 0)."); return; }

            Result = new Employee
            {
                Name = txtName.Text.Trim(),
                Gross = gross,
                Dept = cbDept.Text,
                Level = cbLevel.Text,
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        // ── вспомогательные методы ────────────────────────────────────────────
        private void MakeLabel(string text, int x, int y)
        {
            Controls.Add(new Label
            {
                Text = text,
                Location = new Point(x, y),
                AutoSize = true,
                ForeColor = Color.FromArgb(130, 130, 130),
            });
        }

        private TextBox MakeTextBox(int x, int y, int w)
        {
            var tb = new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(w, 23),
                BackColor = Color.FromArgb(35, 35, 35),
                ForeColor = Color.FromArgb(220, 220, 220),
                BorderStyle = BorderStyle.FixedSingle,
            };
            Controls.Add(tb);
            return tb;
        }

        private ComboBox MakeCombo(int x, int y, int w, string[] items)
        {
            var cb = new ComboBox
            {
                Location = new Point(x, y),
                Size = new Size(w, 23),
                BackColor = Color.FromArgb(35, 35, 35),
                ForeColor = Color.FromArgb(220, 220, 220),
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            cb.Items.AddRange(items);
            cb.SelectedIndex = 0;
            Controls.Add(cb);
            return cb;
        }
    }
}