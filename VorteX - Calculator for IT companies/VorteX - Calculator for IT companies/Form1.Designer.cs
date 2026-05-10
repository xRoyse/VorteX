namespace VorteX___Calculator_for_IT_companies
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Алексей Морозов",
            "240 000 ₽",
            "208 800 ₽",
            "Backend",
            "Senior"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Мария Соколова",
            "170 000 ₽",
            "147 900 ₽",
            "Frontend",
            "Middle"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Дмитрий Козлов",
            "200 000 ₽",
            "174 000 ₽",
            "DevOps",
            "Middle"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Анна Петрова",
            "110 000 ₽",
            "95 700 ₽",
            "QA",
            "Junior"}, -1);
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblDeptSection = new System.Windows.Forms.Label();
            this.rbDeptAll = new System.Windows.Forms.RadioButton();
            this.rbDeptBackend = new System.Windows.Forms.RadioButton();
            this.rbDeptFrontend = new System.Windows.Forms.RadioButton();
            this.rbDeptDevOps = new System.Windows.Forms.RadioButton();
            this.lblLevelSection = new System.Windows.Forms.Label();
            this.rbLevelAll = new System.Windows.Forms.RadioButton();
            this.rbLevelJunior = new System.Windows.Forms.RadioButton();
            this.rbLevelMiddle = new System.Windows.Forms.RadioButton();
            this.rbLevelSenior = new System.Windows.Forms.RadioButton();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblStatTitle = new System.Windows.Forms.Label();
            this.lblStatEmpKey = new System.Windows.Forms.Label();
            this.lblStatEmpVal = new System.Windows.Forms.Label();
            this.lblStatSalaryKey = new System.Windows.Forms.Label();
            this.lblStatSalaryVal = new System.Windows.Forms.Label();
            this.lblStatFundKey = new System.Windows.Forms.Label();
            this.lblStatFundVal = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panelSidebar.Controls.Add(this.txtSearch);
            this.panelSidebar.Controls.Add(this.lblDeptSection);
            this.panelSidebar.Controls.Add(this.rbDeptAll);
            this.panelSidebar.Controls.Add(this.rbDeptBackend);
            this.panelSidebar.Controls.Add(this.rbDeptFrontend);
            this.panelSidebar.Controls.Add(this.rbDeptDevOps);
            this.panelSidebar.Controls.Add(this.lblLevelSection);
            this.panelSidebar.Controls.Add(this.rbLevelAll);
            this.panelSidebar.Controls.Add(this.rbLevelJunior);
            this.panelSidebar.Controls.Add(this.rbLevelMiddle);
            this.panelSidebar.Controls.Add(this.rbLevelSenior);
            this.panelSidebar.Controls.Add(this.panelStats);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(190, 441);
            this.panelSidebar.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtSearch.Location = new System.Drawing.Point(14, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Поиск...";
            // 
            // lblDeptSection
            // 
            this.lblDeptSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeptSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(66)))));
            this.lblDeptSection.Location = new System.Drawing.Point(11, 52);
            this.lblDeptSection.Name = "lblDeptSection";
            this.lblDeptSection.Size = new System.Drawing.Size(162, 16);
            this.lblDeptSection.TabIndex = 1;
            this.lblDeptSection.Text = "ОТДЕЛ";
            // 
            // rbDeptAll
            // 
            this.rbDeptAll.BackColor = System.Drawing.Color.Transparent;
            this.rbDeptAll.Checked = true;
            this.rbDeptAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbDeptAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rbDeptAll.Location = new System.Drawing.Point(14, 71);
            this.rbDeptAll.Name = "rbDeptAll";
            this.rbDeptAll.Size = new System.Drawing.Size(162, 18);
            this.rbDeptAll.TabIndex = 2;
            this.rbDeptAll.TabStop = true;
            this.rbDeptAll.Text = "Все";
            this.rbDeptAll.UseVisualStyleBackColor = false;
            // 
            // rbDeptBackend
            // 
            this.rbDeptBackend.BackColor = System.Drawing.Color.Transparent;
            this.rbDeptBackend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbDeptBackend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rbDeptBackend.Location = new System.Drawing.Point(14, 91);
            this.rbDeptBackend.Name = "rbDeptBackend";
            this.rbDeptBackend.Size = new System.Drawing.Size(162, 18);
            this.rbDeptBackend.TabIndex = 3;
            this.rbDeptBackend.Text = "Backend";
            this.rbDeptBackend.UseVisualStyleBackColor = false;
            // 
            // rbDeptFrontend
            // 
            this.rbDeptFrontend.BackColor = System.Drawing.Color.Transparent;
            this.rbDeptFrontend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbDeptFrontend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rbDeptFrontend.Location = new System.Drawing.Point(14, 111);
            this.rbDeptFrontend.Name = "rbDeptFrontend";
            this.rbDeptFrontend.Size = new System.Drawing.Size(162, 18);
            this.rbDeptFrontend.TabIndex = 4;
            this.rbDeptFrontend.Text = "Frontend";
            this.rbDeptFrontend.UseVisualStyleBackColor = false;
            // 
            // rbDeptDevOps
            // 
            this.rbDeptDevOps.BackColor = System.Drawing.Color.Transparent;
            this.rbDeptDevOps.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbDeptDevOps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rbDeptDevOps.Location = new System.Drawing.Point(14, 131);
            this.rbDeptDevOps.Name = "rbDeptDevOps";
            this.rbDeptDevOps.Size = new System.Drawing.Size(162, 18);
            this.rbDeptDevOps.TabIndex = 5;
            this.rbDeptDevOps.Text = "DevOps";
            this.rbDeptDevOps.UseVisualStyleBackColor = false;
            // 
            // lblLevelSection
            // 
            this.lblLevelSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLevelSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(66)))));
            this.lblLevelSection.Location = new System.Drawing.Point(11, 192);
            this.lblLevelSection.Name = "lblLevelSection";
            this.lblLevelSection.Size = new System.Drawing.Size(162, 16);
            this.lblLevelSection.TabIndex = 6;
            this.lblLevelSection.Text = "УРОВЕНЬ";
            this.lblLevelSection.Click += new System.EventHandler(this.lblLevelSection_Click);
            // 
            // rbLevelAll
            // 
            this.rbLevelAll.BackColor = System.Drawing.Color.Transparent;
            this.rbLevelAll.Checked = true;
            this.rbLevelAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbLevelAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rbLevelAll.Location = new System.Drawing.Point(14, 211);
            this.rbLevelAll.Name = "rbLevelAll";
            this.rbLevelAll.Size = new System.Drawing.Size(162, 18);
            this.rbLevelAll.TabIndex = 7;
            this.rbLevelAll.TabStop = true;
            this.rbLevelAll.Text = "Все";
            this.rbLevelAll.UseVisualStyleBackColor = false;
            // 
            // rbLevelJunior
            // 
            this.rbLevelJunior.BackColor = System.Drawing.Color.Transparent;
            this.rbLevelJunior.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbLevelJunior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rbLevelJunior.Location = new System.Drawing.Point(14, 231);
            this.rbLevelJunior.Name = "rbLevelJunior";
            this.rbLevelJunior.Size = new System.Drawing.Size(162, 18);
            this.rbLevelJunior.TabIndex = 8;
            this.rbLevelJunior.Text = "Junior";
            this.rbLevelJunior.UseVisualStyleBackColor = false;
            // 
            // rbLevelMiddle
            // 
            this.rbLevelMiddle.BackColor = System.Drawing.Color.Transparent;
            this.rbLevelMiddle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbLevelMiddle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rbLevelMiddle.Location = new System.Drawing.Point(14, 251);
            this.rbLevelMiddle.Name = "rbLevelMiddle";
            this.rbLevelMiddle.Size = new System.Drawing.Size(162, 18);
            this.rbLevelMiddle.TabIndex = 9;
            this.rbLevelMiddle.Text = "Middle";
            this.rbLevelMiddle.UseVisualStyleBackColor = false;
            // 
            // rbLevelSenior
            // 
            this.rbLevelSenior.BackColor = System.Drawing.Color.Transparent;
            this.rbLevelSenior.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbLevelSenior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.rbLevelSenior.Location = new System.Drawing.Point(14, 271);
            this.rbLevelSenior.Name = "rbLevelSenior";
            this.rbLevelSenior.Size = new System.Drawing.Size(162, 18);
            this.rbLevelSenior.TabIndex = 10;
            this.rbLevelSenior.Text = "Senior";
            this.rbLevelSenior.UseVisualStyleBackColor = false;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelStats.Controls.Add(this.lblStatTitle);
            this.panelStats.Controls.Add(this.lblStatEmpKey);
            this.panelStats.Controls.Add(this.lblStatEmpVal);
            this.panelStats.Controls.Add(this.lblStatSalaryKey);
            this.panelStats.Controls.Add(this.lblStatSalaryVal);
            this.panelStats.Controls.Add(this.lblStatFundKey);
            this.panelStats.Controls.Add(this.lblStatFundVal);
            this.panelStats.Location = new System.Drawing.Point(14, 331);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(162, 98);
            this.panelStats.TabIndex = 11;
            // 
            // lblStatTitle
            // 
            this.lblStatTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblStatTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStatTitle.Location = new System.Drawing.Point(8, 8);
            this.lblStatTitle.Name = "lblStatTitle";
            this.lblStatTitle.Size = new System.Drawing.Size(146, 14);
            this.lblStatTitle.TabIndex = 0;
            this.lblStatTitle.Text = "СТАТИСТИКА";
            // 
            // lblStatEmpKey
            // 
            this.lblStatEmpKey.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatEmpKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblStatEmpKey.Location = new System.Drawing.Point(8, 28);
            this.lblStatEmpKey.Name = "lblStatEmpKey";
            this.lblStatEmpKey.Size = new System.Drawing.Size(80, 16);
            this.lblStatEmpKey.TabIndex = 1;
            this.lblStatEmpKey.Text = "Сотрудников";
            // 
            // lblStatEmpVal
            // 
            this.lblStatEmpVal.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatEmpVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lblStatEmpVal.Location = new System.Drawing.Point(100, 28);
            this.lblStatEmpVal.Name = "lblStatEmpVal";
            this.lblStatEmpVal.Size = new System.Drawing.Size(54, 16);
            this.lblStatEmpVal.TabIndex = 2;
            this.lblStatEmpVal.Text = "14";
            this.lblStatEmpVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatSalaryKey
            // 
            this.lblStatSalaryKey.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatSalaryKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblStatSalaryKey.Location = new System.Drawing.Point(8, 50);
            this.lblStatSalaryKey.Name = "lblStatSalaryKey";
            this.lblStatSalaryKey.Size = new System.Drawing.Size(70, 16);
            this.lblStatSalaryKey.TabIndex = 3;
            this.lblStatSalaryKey.Text = "Ср. оклад";
            // 
            // lblStatSalaryVal
            // 
            this.lblStatSalaryVal.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatSalaryVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(66)))));
            this.lblStatSalaryVal.Location = new System.Drawing.Point(70, 50);
            this.lblStatSalaryVal.Name = "lblStatSalaryVal";
            this.lblStatSalaryVal.Size = new System.Drawing.Size(84, 16);
            this.lblStatSalaryVal.TabIndex = 4;
            this.lblStatSalaryVal.Text = "185 000 ₽";
            this.lblStatSalaryVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatFundKey
            // 
            this.lblStatFundKey.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatFundKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblStatFundKey.Location = new System.Drawing.Point(8, 72);
            this.lblStatFundKey.Name = "lblStatFundKey";
            this.lblStatFundKey.Size = new System.Drawing.Size(70, 16);
            this.lblStatFundKey.TabIndex = 5;
            this.lblStatFundKey.Text = "Фонд/мес.";
            // 
            // lblStatFundVal
            // 
            this.lblStatFundVal.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatFundVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(133)))), ((int)(((byte)(10)))));
            this.lblStatFundVal.Location = new System.Drawing.Point(70, 72);
            this.lblStatFundVal.Name = "lblStatFundVal";
            this.lblStatFundVal.Size = new System.Drawing.Size(84, 16);
            this.lblStatFundVal.TabIndex = 6;
            this.lblStatFundVal.Text = "2.59M ₽";
            this.lblStatFundVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelMain.Controls.Add(this.lvEmployees);
            this.panelMain.Controls.Add(this.panelButtons);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(191, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(14, 14, 14, 0);
            this.panelMain.Size = new System.Drawing.Size(653, 441);
            this.panelMain.TabIndex = 0;
            // 
            // lvEmployees
            // 
            this.lvEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSalary,
            this.colNet,
            this.colDept,
            this.colLevel});
            this.lvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEmployees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lvEmployees.FullRowSelect = true;
            this.lvEmployees.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEmployees.HideSelection = false;
            this.lvEmployees.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvEmployees.Location = new System.Drawing.Point(14, 14);
            this.lvEmployees.MultiSelect = false;
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(625, 379);
            this.lvEmployees.TabIndex = 0;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Сотрудник";
            this.colName.Width = 220;
            // 
            // colSalary
            // 
            this.colSalary.Text = "Оклад";
            this.colSalary.Width = 110;
            // 
            // colNet
            // 
            this.colNet.Text = "На руки";
            this.colNet.Width = 110;
            // 
            // colDept
            // 
            this.colDept.Text = "Отдел";
            this.colDept.Width = 100;
            // 
            // colLevel
            // 
            this.colLevel.Text = "Уровень";
            this.colLevel.Width = 90;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnCalc);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(14, 393);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(625, 48);
            this.panelButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(133)))), ((int)(((byte)(10)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(3, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+ Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(66)))));
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnCalc.Location = new System.Drawing.Point(219, 9);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(182, 30);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDelete.Location = new System.Drawing.Point(440, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelSeparator.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSeparator.Location = new System.Drawing.Point(190, 0);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(1, 441);
            this.panelSeparator.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(844, 441);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSeparator);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(860, 480);
            this.MinimumSize = new System.Drawing.Size(860, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VORTEX — Управление зарплатами";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblDeptSection;
        private System.Windows.Forms.RadioButton rbDeptAll;
        private System.Windows.Forms.RadioButton rbDeptBackend;
        private System.Windows.Forms.RadioButton rbDeptFrontend;
        private System.Windows.Forms.RadioButton rbDeptDevOps;
        private System.Windows.Forms.Label lblLevelSection;
        private System.Windows.Forms.RadioButton rbLevelAll;
        private System.Windows.Forms.RadioButton rbLevelJunior;
        private System.Windows.Forms.RadioButton rbLevelMiddle;
        private System.Windows.Forms.RadioButton rbLevelSenior;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblStatTitle;
        private System.Windows.Forms.Label lblStatEmpKey;
        private System.Windows.Forms.Label lblStatEmpVal;
        private System.Windows.Forms.Label lblStatSalaryKey;
        private System.Windows.Forms.Label lblStatSalaryVal;
        private System.Windows.Forms.Label lblStatFundKey;
        private System.Windows.Forms.Label lblStatFundVal;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ListView lvEmployees;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSalary;
        private System.Windows.Forms.ColumnHeader colNet;
        private System.Windows.Forms.ColumnHeader colDept;
        private System.Windows.Forms.ColumnHeader colLevel;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnDelete;
    }
}