namespace ClinicalApplication
{
    partial class FRMDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDashboard));
            panelMenu = new Panel();
            panelFinanceSubmenu = new Panel();
            btnIncomeStatement = new FontAwesome.Sharp.IconButton();
            btnBalanceSheet = new FontAwesome.Sharp.IconButton();
            btnAddFinancialAccount = new FontAwesome.Sharp.IconButton();
            btnFinance = new FontAwesome.Sharp.IconButton();
            panelDDHHSubmenu = new Panel();
            btnManageEmployees = new FontAwesome.Sharp.IconButton();
            btnPayroll = new FontAwesome.Sharp.IconButton();
            btnDDHH = new FontAwesome.Sharp.IconButton();
            panelInventorySubmenu = new Panel();
            btnDeleteInventory = new FontAwesome.Sharp.IconButton();
            btnModifyInventory = new FontAwesome.Sharp.IconButton();
            btnConsultInventory = new FontAwesome.Sharp.IconButton();
            btnInventory = new FontAwesome.Sharp.IconButton();
            panelSalesSubmenu = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnSales = new FontAwesome.Sharp.IconButton();
            btnPurchases = new FontAwesome.Sharp.IconButton();
            btnMainMenu = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lblTitleDash = new Label();
            btnMenu = new FontAwesome.Sharp.IconButton();
            btnSignOut = new FontAwesome.Sharp.IconButton();
            panelTitleBar = new Panel();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelFinanceSubmenu.SuspendLayout();
            panelDDHHSubmenu.SuspendLayout();
            panelInventorySubmenu.SuspendLayout();
            panelSalesSubmenu.SuspendLayout();
            panel1.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = SystemColors.Highlight;
            panelMenu.Controls.Add(panelFinanceSubmenu);
            panelMenu.Controls.Add(btnFinance);
            panelMenu.Controls.Add(panelDDHHSubmenu);
            panelMenu.Controls.Add(btnDDHH);
            panelMenu.Controls.Add(panelInventorySubmenu);
            panelMenu.Controls.Add(btnInventory);
            panelMenu.Controls.Add(panelSalesSubmenu);
            panelMenu.Controls.Add(btnSales);
            panelMenu.Controls.Add(btnPurchases);
            panelMenu.Controls.Add(btnMainMenu);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 604);
            panelMenu.TabIndex = 0;
            // 
            // panelFinanceSubmenu
            // 
            panelFinanceSubmenu.BackColor = Color.FromArgb(41, 145, 217);
            panelFinanceSubmenu.Controls.Add(btnIncomeStatement);
            panelFinanceSubmenu.Controls.Add(btnBalanceSheet);
            panelFinanceSubmenu.Controls.Add(btnAddFinancialAccount);
            panelFinanceSubmenu.Dock = DockStyle.Top;
            panelFinanceSubmenu.Location = new Point(0, 704);
            panelFinanceSubmenu.Name = "panelFinanceSubmenu";
            panelFinanceSubmenu.Size = new Size(213, 167);
            panelFinanceSubmenu.TabIndex = 13;
            // 
            // btnIncomeStatement
            // 
            btnIncomeStatement.Dock = DockStyle.Top;
            btnIncomeStatement.FlatAppearance.BorderSize = 0;
            btnIncomeStatement.FlatStyle = FlatStyle.Flat;
            btnIncomeStatement.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIncomeStatement.ForeColor = SystemColors.ControlLightLight;
            btnIncomeStatement.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            btnIncomeStatement.IconColor = Color.White;
            btnIncomeStatement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIncomeStatement.IconSize = 30;
            btnIncomeStatement.ImageAlign = ContentAlignment.MiddleLeft;
            btnIncomeStatement.Location = new Point(0, 100);
            btnIncomeStatement.Name = "btnIncomeStatement";
            btnIncomeStatement.Padding = new Padding(10, 0, 0, 0);
            btnIncomeStatement.Size = new Size(213, 50);
            btnIncomeStatement.TabIndex = 7;
            btnIncomeStatement.Tag = "Eliminar";
            btnIncomeStatement.Text = "      Estado de \r\n     Resultados";
            btnIncomeStatement.TextAlign = ContentAlignment.MiddleLeft;
            btnIncomeStatement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIncomeStatement.UseVisualStyleBackColor = true;
            btnIncomeStatement.Click += btnIncomeStatement_Click;
            // 
            // btnBalanceSheet
            // 
            btnBalanceSheet.Dock = DockStyle.Top;
            btnBalanceSheet.FlatAppearance.BorderSize = 0;
            btnBalanceSheet.FlatStyle = FlatStyle.Flat;
            btnBalanceSheet.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBalanceSheet.ForeColor = SystemColors.ControlLightLight;
            btnBalanceSheet.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnBalanceSheet.IconColor = Color.White;
            btnBalanceSheet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBalanceSheet.IconSize = 30;
            btnBalanceSheet.ImageAlign = ContentAlignment.MiddleLeft;
            btnBalanceSheet.Location = new Point(0, 50);
            btnBalanceSheet.Name = "btnBalanceSheet";
            btnBalanceSheet.Padding = new Padding(10, 0, 0, 0);
            btnBalanceSheet.Size = new Size(213, 50);
            btnBalanceSheet.TabIndex = 6;
            btnBalanceSheet.Tag = "Modificar";
            btnBalanceSheet.Text = "  Balance General";
            btnBalanceSheet.TextAlign = ContentAlignment.MiddleLeft;
            btnBalanceSheet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBalanceSheet.UseVisualStyleBackColor = true;
            btnBalanceSheet.Click += btnBalanceSheet_Click;
            // 
            // btnAddFinancialAccount
            // 
            btnAddFinancialAccount.Dock = DockStyle.Top;
            btnAddFinancialAccount.FlatAppearance.BorderSize = 0;
            btnAddFinancialAccount.FlatStyle = FlatStyle.Flat;
            btnAddFinancialAccount.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFinancialAccount.ForeColor = SystemColors.ControlLightLight;
            btnAddFinancialAccount.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAddFinancialAccount.IconColor = Color.White;
            btnAddFinancialAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddFinancialAccount.IconSize = 30;
            btnAddFinancialAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddFinancialAccount.Location = new Point(0, 0);
            btnAddFinancialAccount.Name = "btnAddFinancialAccount";
            btnAddFinancialAccount.Padding = new Padding(10, 0, 0, 0);
            btnAddFinancialAccount.Size = new Size(213, 50);
            btnAddFinancialAccount.TabIndex = 5;
            btnAddFinancialAccount.Tag = "Consultar";
            btnAddFinancialAccount.Text = "  Añadir cuentas";
            btnAddFinancialAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAddFinancialAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddFinancialAccount.UseVisualStyleBackColor = true;
            // 
            // btnFinance
            // 
            btnFinance.Dock = DockStyle.Top;
            btnFinance.FlatAppearance.BorderSize = 0;
            btnFinance.FlatStyle = FlatStyle.Flat;
            btnFinance.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinance.ForeColor = SystemColors.ControlLightLight;
            btnFinance.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            btnFinance.IconColor = Color.White;
            btnFinance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinance.IconSize = 30;
            btnFinance.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinance.Location = new Point(0, 660);
            btnFinance.Name = "btnFinance";
            btnFinance.Padding = new Padding(10, 0, 0, 0);
            btnFinance.Size = new Size(213, 44);
            btnFinance.TabIndex = 18;
            btnFinance.Tag = "Finanzas";
            btnFinance.Text = "  Finanzas";
            btnFinance.TextAlign = ContentAlignment.MiddleLeft;
            btnFinance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFinance.UseVisualStyleBackColor = true;
            btnFinance.Click += btnFinance_Click;
            // 
            // panelDDHHSubmenu
            // 
            panelDDHHSubmenu.BackColor = Color.FromArgb(41, 145, 217);
            panelDDHHSubmenu.Controls.Add(btnManageEmployees);
            panelDDHHSubmenu.Controls.Add(btnPayroll);
            panelDDHHSubmenu.Dock = DockStyle.Top;
            panelDDHHSubmenu.Location = new Point(0, 564);
            panelDDHHSubmenu.Name = "panelDDHHSubmenu";
            panelDDHHSubmenu.Size = new Size(213, 96);
            panelDDHHSubmenu.TabIndex = 17;
            // 
            // btnManageEmployees
            // 
            btnManageEmployees.Dock = DockStyle.Top;
            btnManageEmployees.FlatAppearance.BorderSize = 0;
            btnManageEmployees.FlatStyle = FlatStyle.Flat;
            btnManageEmployees.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnManageEmployees.ForeColor = SystemColors.ControlLightLight;
            btnManageEmployees.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            btnManageEmployees.IconColor = Color.White;
            btnManageEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnManageEmployees.IconSize = 30;
            btnManageEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageEmployees.Location = new Point(0, 44);
            btnManageEmployees.Name = "btnManageEmployees";
            btnManageEmployees.Padding = new Padding(10, 0, 0, 0);
            btnManageEmployees.Size = new Size(213, 44);
            btnManageEmployees.TabIndex = 17;
            btnManageEmployees.Tag = " Humanos";
            btnManageEmployees.Text = "   Disponer Empleados";
            btnManageEmployees.UseVisualStyleBackColor = true;
            btnManageEmployees.Click += btnManageEmployees_Click;
            // 
            // btnPayroll
            // 
            btnPayroll.Dock = DockStyle.Top;
            btnPayroll.FlatAppearance.BorderSize = 0;
            btnPayroll.FlatStyle = FlatStyle.Flat;
            btnPayroll.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPayroll.ForeColor = SystemColors.ControlLightLight;
            btnPayroll.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            btnPayroll.IconColor = Color.White;
            btnPayroll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPayroll.IconSize = 30;
            btnPayroll.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayroll.Location = new Point(0, 0);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Padding = new Padding(10, 0, 0, 0);
            btnPayroll.Size = new Size(213, 44);
            btnPayroll.TabIndex = 16;
            btnPayroll.Tag = "Recursos Humanos";
            btnPayroll.Text = "Planilla de Sueldos";
            btnPayroll.TextAlign = ContentAlignment.MiddleLeft;
            btnPayroll.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayroll.UseVisualStyleBackColor = true;
            btnPayroll.Click += btnPayroll_Click;
            // 
            // btnDDHH
            // 
            btnDDHH.Dock = DockStyle.Top;
            btnDDHH.FlatAppearance.BorderSize = 0;
            btnDDHH.FlatStyle = FlatStyle.Flat;
            btnDDHH.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDDHH.ForeColor = SystemColors.ControlLightLight;
            btnDDHH.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnDDHH.IconColor = Color.White;
            btnDDHH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDDHH.IconSize = 30;
            btnDDHH.ImageAlign = ContentAlignment.MiddleLeft;
            btnDDHH.Location = new Point(0, 520);
            btnDDHH.Name = "btnDDHH";
            btnDDHH.Padding = new Padding(10, 0, 0, 0);
            btnDDHH.Size = new Size(213, 44);
            btnDDHH.TabIndex = 16;
            btnDDHH.Tag = "Finanzas";
            btnDDHH.Text = "  Recursos Humanos";
            btnDDHH.TextAlign = ContentAlignment.MiddleLeft;
            btnDDHH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDDHH.UseVisualStyleBackColor = true;
            btnDDHH.Click += iconButton3_Click_1;
            // 
            // panelInventorySubmenu
            // 
            panelInventorySubmenu.BackColor = Color.FromArgb(41, 145, 217);
            panelInventorySubmenu.Controls.Add(btnDeleteInventory);
            panelInventorySubmenu.Controls.Add(btnModifyInventory);
            panelInventorySubmenu.Controls.Add(btnConsultInventory);
            panelInventorySubmenu.Dock = DockStyle.Top;
            panelInventorySubmenu.Location = new Point(0, 360);
            panelInventorySubmenu.Name = "panelInventorySubmenu";
            panelInventorySubmenu.Size = new Size(213, 160);
            panelInventorySubmenu.TabIndex = 11;
            // 
            // btnDeleteInventory
            // 
            btnDeleteInventory.Dock = DockStyle.Top;
            btnDeleteInventory.FlatAppearance.BorderSize = 0;
            btnDeleteInventory.FlatStyle = FlatStyle.Flat;
            btnDeleteInventory.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteInventory.ForeColor = SystemColors.ControlLightLight;
            btnDeleteInventory.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnDeleteInventory.IconColor = Color.White;
            btnDeleteInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeleteInventory.IconSize = 30;
            btnDeleteInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteInventory.Location = new Point(0, 100);
            btnDeleteInventory.Name = "btnDeleteInventory";
            btnDeleteInventory.Padding = new Padding(10, 0, 0, 0);
            btnDeleteInventory.Size = new Size(213, 50);
            btnDeleteInventory.TabIndex = 6;
            btnDeleteInventory.Tag = "Eliminar";
            btnDeleteInventory.Text = "  Eliminar";
            btnDeleteInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteInventory.UseVisualStyleBackColor = true;
            btnDeleteInventory.Click += btnDeleteInventory_Click;
            // 
            // btnModifyInventory
            // 
            btnModifyInventory.Dock = DockStyle.Top;
            btnModifyInventory.FlatAppearance.BorderSize = 0;
            btnModifyInventory.FlatStyle = FlatStyle.Flat;
            btnModifyInventory.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifyInventory.ForeColor = SystemColors.ControlLightLight;
            btnModifyInventory.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnModifyInventory.IconColor = Color.White;
            btnModifyInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModifyInventory.IconSize = 30;
            btnModifyInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnModifyInventory.Location = new Point(0, 50);
            btnModifyInventory.Name = "btnModifyInventory";
            btnModifyInventory.Padding = new Padding(10, 0, 0, 0);
            btnModifyInventory.Size = new Size(213, 50);
            btnModifyInventory.TabIndex = 5;
            btnModifyInventory.Tag = "Modificar";
            btnModifyInventory.Text = "  Modificar";
            btnModifyInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnModifyInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModifyInventory.UseVisualStyleBackColor = true;
            btnModifyInventory.Click += btnModifyInventory_Click;
            // 
            // btnConsultInventory
            // 
            btnConsultInventory.Dock = DockStyle.Top;
            btnConsultInventory.FlatAppearance.BorderSize = 0;
            btnConsultInventory.FlatStyle = FlatStyle.Flat;
            btnConsultInventory.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultInventory.ForeColor = SystemColors.ControlLightLight;
            btnConsultInventory.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnConsultInventory.IconColor = Color.White;
            btnConsultInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultInventory.IconSize = 30;
            btnConsultInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultInventory.Location = new Point(0, 0);
            btnConsultInventory.Name = "btnConsultInventory";
            btnConsultInventory.Padding = new Padding(10, 0, 0, 0);
            btnConsultInventory.Size = new Size(213, 50);
            btnConsultInventory.TabIndex = 4;
            btnConsultInventory.Tag = "Consultar";
            btnConsultInventory.Text = "  Consultar";
            btnConsultInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultInventory.UseVisualStyleBackColor = true;
            btnConsultInventory.Click += btnConsultInventory_Click;
            // 
            // btnInventory
            // 
            btnInventory.Dock = DockStyle.Top;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInventory.ForeColor = SystemColors.ControlLightLight;
            btnInventory.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btnInventory.IconColor = Color.White;
            btnInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventory.IconSize = 30;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 316);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(10, 0, 0, 0);
            btnInventory.Size = new Size(213, 44);
            btnInventory.TabIndex = 10;
            btnInventory.Tag = "Inventario";
            btnInventory.Text = "  Inventario";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // panelSalesSubmenu
            // 
            panelSalesSubmenu.BackColor = Color.FromArgb(41, 145, 217);
            panelSalesSubmenu.Controls.Add(iconButton1);
            panelSalesSubmenu.Controls.Add(iconButton2);
            panelSalesSubmenu.Dock = DockStyle.Top;
            panelSalesSubmenu.Location = new Point(0, 210);
            panelSalesSubmenu.Name = "panelSalesSubmenu";
            panelSalesSubmenu.Size = new Size(213, 106);
            panelSalesSubmenu.TabIndex = 15;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 44);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 0, 0);
            iconButton1.Size = new Size(213, 44);
            iconButton1.TabIndex = 14;
            iconButton1.Tag = "Recursos Humanos";
            iconButton1.Text = "Buscar Factura";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = SystemColors.ControlLightLight;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 0, 0);
            iconButton2.Size = new Size(213, 44);
            iconButton2.TabIndex = 16;
            iconButton2.Tag = "Recursos Humanos";
            iconButton2.Text = "Generar Factura";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click_1;
            // 
            // btnSales
            // 
            btnSales.Dock = DockStyle.Top;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSales.ForeColor = SystemColors.ControlLightLight;
            btnSales.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            btnSales.IconColor = Color.White;
            btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSales.IconSize = 30;
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(0, 161);
            btnSales.Name = "btnSales";
            btnSales.Padding = new Padding(10, 0, 0, 0);
            btnSales.Size = new Size(213, 49);
            btnSales.TabIndex = 9;
            btnSales.Tag = "Ventas";
            btnSales.Text = "  Ventas";
            btnSales.TextAlign = ContentAlignment.MiddleLeft;
            btnSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnPurchases
            // 
            btnPurchases.Dock = DockStyle.Top;
            btnPurchases.FlatAppearance.BorderSize = 0;
            btnPurchases.FlatStyle = FlatStyle.Flat;
            btnPurchases.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPurchases.ForeColor = SystemColors.ControlLightLight;
            btnPurchases.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            btnPurchases.IconColor = Color.White;
            btnPurchases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPurchases.IconSize = 30;
            btnPurchases.ImageAlign = ContentAlignment.MiddleLeft;
            btnPurchases.Location = new Point(0, 117);
            btnPurchases.Name = "btnPurchases";
            btnPurchases.Padding = new Padding(10, 0, 0, 0);
            btnPurchases.Size = new Size(213, 44);
            btnPurchases.TabIndex = 2;
            btnPurchases.Tag = "Compras";
            btnPurchases.Text = "  Compras";
            btnPurchases.TextAlign = ContentAlignment.MiddleLeft;
            btnPurchases.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPurchases.UseVisualStyleBackColor = true;
            btnPurchases.Click += iconButton3_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Dock = DockStyle.Top;
            btnMainMenu.FlatAppearance.BorderSize = 0;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMainMenu.ForeColor = SystemColors.ControlLightLight;
            btnMainMenu.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnMainMenu.IconColor = Color.White;
            btnMainMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMainMenu.IconSize = 30;
            btnMainMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMainMenu.Location = new Point(0, 73);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Padding = new Padding(10, 0, 0, 0);
            btnMainMenu.Size = new Size(213, 44);
            btnMainMenu.TabIndex = 1;
            btnMainMenu.Tag = "Inicio";
            btnMainMenu.Text = "  Inicio";
            btnMainMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMainMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += iconButton2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitleDash);
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 73);
            panel1.TabIndex = 0;
            // 
            // lblTitleDash
            // 
            lblTitleDash.AutoSize = true;
            lblTitleDash.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleDash.ForeColor = SystemColors.ControlLightLight;
            lblTitleDash.Location = new Point(12, 18);
            lblTitleDash.Name = "lblTitleDash";
            lblTitleDash.Size = new Size(72, 23);
            lblTitleDash.TabIndex = 2;
            lblTitleDash.Text = "MENU";
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            btnMenu.IconColor = Color.White;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 30;
            btnMenu.Location = new Point(170, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(60, 60);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignOut.ForeColor = SystemColors.ControlLightLight;
            btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnSignOut.IconColor = Color.White;
            btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSignOut.IconSize = 30;
            btnSignOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignOut.Location = new Point(217, 463);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Padding = new Padding(10, 0, 0, 15);
            btnSignOut.Size = new Size(230, 44);
            btnSignOut.TabIndex = 6;
            btnSignOut.Tag = "Cerrar Sesion";
            btnSignOut.Text = "  Cerrar Sesion";
            btnSignOut.TextAlign = ContentAlignment.MiddleLeft;
            btnSignOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSignOut.UseVisualStyleBackColor = true;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.White;
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(230, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(704, 24);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown_1;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Orange;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Meteor;
            btnMinimize.IconColor = Color.White;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 20;
            btnMinimize.Location = new Point(569, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(45, 24);
            btnMinimize.TabIndex = 5;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.DodgerBlue;
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            btnMaximize.IconColor = Color.White;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 20;
            btnMaximize.Location = new Point(614, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(45, 24);
            btnMaximize.TabIndex = 4;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 20;
            btnClose.Location = new Point(659, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 24);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.White;
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Controls.Add(btnSignOut);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(230, 24);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(704, 580);
            panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FRMDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 604);
            ControlBox = false;
            Controls.Add(panelChildForm);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(950, 620);
            Name = "FRMDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMDashboard";
            Load += FRMDashboard_Load;
            ResizeBegin += FRMDashboard_ResizeBegin;
            ResizeEnd += FRMDashboard_ResizeEnd;
            panelMenu.ResumeLayout(false);
            panelFinanceSubmenu.ResumeLayout(false);
            panelDDHHSubmenu.ResumeLayout(false);
            panelInventorySubmenu.ResumeLayout(false);
            panelSalesSubmenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Panel panelTitleBar;
        private Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnMainMenu;
        private FontAwesome.Sharp.IconButton btnSignOut;
        private Label lblTitleDash;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnPurchases;
        private FontAwesome.Sharp.IconButton btnConsultInventory;
        private FontAwesome.Sharp.IconButton btnSales;
        private Panel panelInventorySubmenu;
        private FontAwesome.Sharp.IconButton btnDeleteInventory;
        private FontAwesome.Sharp.IconButton btnModifyInventory;
        private FontAwesome.Sharp.IconButton btnInventory;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelSalesSubmenu;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnDDHH;
        private Panel panelDDHHSubmenu;
        private FontAwesome.Sharp.IconButton btnPayroll;
        private FontAwesome.Sharp.IconButton btnManageEmployees;
        private Panel panelFinanceSubmenu;
        private FontAwesome.Sharp.IconButton btnIncomeStatement;
        private FontAwesome.Sharp.IconButton btnBalanceSheet;
        private FontAwesome.Sharp.IconButton btn;
        private FontAwesome.Sharp.IconButton btnFinance;
        private FontAwesome.Sharp.IconButton btnAddFinancialAccount;
    }
}