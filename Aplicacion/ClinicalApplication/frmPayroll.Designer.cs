namespace ClinicalApplication
{
    partial class frmPayroll
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnPurcharseBack = new FontAwesome.Sharp.IconButton();
            grdPayroll = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            salaryBase = new DataGridViewTextBoxColumn();
            overtime = new DataGridViewTextBoxColumn();
            overtimeValue = new DataGridViewTextBoxColumn();
            commission = new DataGridViewTextBoxColumn();
            bonuses = new DataGridViewTextBoxColumn();
            totalAccrued = new DataGridViewTextBoxColumn();
            IGSS = new DataGridViewTextBoxColumn();
            ISR = new DataGridViewTextBoxColumn();
            advancePayments = new DataGridViewTextBoxColumn();
            court = new DataGridViewTextBoxColumn();
            loans = new DataGridViewTextBoxColumn();
            totalDiscounts = new DataGridViewTextBoxColumn();
            totalLiquid = new DataGridViewTextBoxColumn();
            lblTotalAccrued = new Label();
            lblTotalDiscounts = new Label();
            lblTotalLiquid = new Label();
            ((System.ComponentModel.ISupportInitialize)grdPayroll).BeginInit();
            SuspendLayout();
            // 
            // btnPurcharseBack
            // 
            btnPurcharseBack.BackColor = Color.IndianRed;
            btnPurcharseBack.FlatAppearance.BorderSize = 0;
            btnPurcharseBack.FlatStyle = FlatStyle.Flat;
            btnPurcharseBack.IconChar = FontAwesome.Sharp.IconChar.X;
            btnPurcharseBack.IconColor = Color.White;
            btnPurcharseBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPurcharseBack.IconSize = 20;
            btnPurcharseBack.Location = new Point(620, 35);
            btnPurcharseBack.Name = "btnPurcharseBack";
            btnPurcharseBack.Size = new Size(45, 24);
            btnPurcharseBack.TabIndex = 7;
            btnPurcharseBack.UseVisualStyleBackColor = false;
            btnPurcharseBack.Click += btnPurcharseBack_Click;
            // 
            // grdPayroll
            // 
            grdPayroll.AllowUserToAddRows = false;
            grdPayroll.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdPayroll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPayroll.Columns.AddRange(new DataGridViewColumn[] { UserId, name, salaryBase, overtime, overtimeValue, commission, bonuses, totalAccrued, IGSS, ISR, advancePayments, court, loans, totalDiscounts, totalLiquid });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdPayroll.DefaultCellStyle = dataGridViewCellStyle2;
            grdPayroll.Location = new Point(12, 79);
            grdPayroll.Name = "grdPayroll";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SkyBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdPayroll.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdPayroll.RowTemplate.Height = 25;
            grdPayroll.Size = new Size(680, 345);
            grdPayroll.TabIndex = 8;
            grdPayroll.CellValueChanged += grdPayroll_CellValueChanged_1;
            // 
            // UserId
            // 
            UserId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            UserId.HeaderText = "Id Usuario";
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Width = 79;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            name.HeaderText = "Nombre";
            name.Name = "name";
            name.ReadOnly = true;
            name.Resizable = DataGridViewTriState.True;
            name.Width = 76;
            // 
            // salaryBase
            // 
            salaryBase.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            salaryBase.HeaderText = "Sueldo Ordinario";
            salaryBase.Name = "salaryBase";
            salaryBase.ReadOnly = true;
            salaryBase.Width = 111;
            // 
            // overtime
            // 
            overtime.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            overtime.HeaderText = "Horas Extras";
            overtime.Name = "overtime";
            overtime.Width = 89;
            // 
            // overtimeValue
            // 
            overtimeValue.HeaderText = "Valor de Horas Extras";
            overtimeValue.Name = "overtimeValue";
            overtimeValue.ReadOnly = true;
            overtimeValue.Width = 102;
            // 
            // commission
            // 
            commission.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            commission.HeaderText = "Comisión";
            commission.Name = "commission";
            commission.Width = 83;
            // 
            // bonuses
            // 
            bonuses.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            bonuses.HeaderText = "Bonificaciones";
            bonuses.Name = "bonuses";
            bonuses.Width = 109;
            // 
            // totalAccrued
            // 
            totalAccrued.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            totalAccrued.HeaderText = "Total Devengado";
            totalAccrued.Name = "totalAccrued";
            totalAccrued.ReadOnly = true;
            totalAccrued.Width = 110;
            // 
            // IGSS
            // 
            IGSS.HeaderText = "IGSS";
            IGSS.Name = "IGSS";
            IGSS.ReadOnly = true;
            IGSS.Width = 55;
            // 
            // ISR
            // 
            ISR.HeaderText = "ISR";
            ISR.Name = "ISR";
            ISR.ReadOnly = true;
            ISR.Width = 48;
            // 
            // advancePayments
            // 
            advancePayments.HeaderText = "Anticipos";
            advancePayments.Name = "advancePayments";
            advancePayments.Width = 82;
            // 
            // court
            // 
            court.HeaderText = "Judiciales";
            court.Name = "court";
            court.Width = 82;
            // 
            // loans
            // 
            loans.HeaderText = "Prestamos";
            loans.Name = "loans";
            loans.Width = 87;
            // 
            // totalDiscounts
            // 
            totalDiscounts.HeaderText = "Total Descuentos";
            totalDiscounts.Name = "totalDiscounts";
            totalDiscounts.ReadOnly = true;
            totalDiscounts.Width = 111;
            // 
            // totalLiquid
            // 
            totalLiquid.HeaderText = "Total Liquido";
            totalLiquid.Name = "totalLiquid";
            totalLiquid.ReadOnly = true;
            totalLiquid.Width = 92;
            // 
            // lblTotalAccrued
            // 
            lblTotalAccrued.AutoSize = true;
            lblTotalAccrued.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalAccrued.Location = new Point(12, 444);
            lblTotalAccrued.Name = "lblTotalAccrued";
            lblTotalAccrued.Size = new Size(128, 21);
            lblTotalAccrued.TabIndex = 9;
            lblTotalAccrued.Text = "Total Devengado:";
            // 
            // lblTotalDiscounts
            // 
            lblTotalDiscounts.AutoSize = true;
            lblTotalDiscounts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalDiscounts.Location = new Point(11, 483);
            lblTotalDiscounts.Name = "lblTotalDiscounts";
            lblTotalDiscounts.Size = new Size(129, 21);
            lblTotalDiscounts.TabIndex = 10;
            lblTotalDiscounts.Text = "Total Descuentos:";
            // 
            // lblTotalLiquid
            // 
            lblTotalLiquid.AutoSize = true;
            lblTotalLiquid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalLiquid.Location = new Point(12, 526);
            lblTotalLiquid.Name = "lblTotalLiquid";
            lblTotalLiquid.Size = new Size(101, 21);
            lblTotalLiquid.TabIndex = 11;
            lblTotalLiquid.Text = "Total Liquido:";
            // 
            // frmPayroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 580);
            Controls.Add(lblTotalLiquid);
            Controls.Add(lblTotalDiscounts);
            Controls.Add(lblTotalAccrued);
            Controls.Add(grdPayroll);
            Controls.Add(btnPurcharseBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPayroll";
            Text = "frmPayroll";
            Load += frmPayroll_Load;
            ((System.ComponentModel.ISupportInitialize)grdPayroll).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnPurcharseBack;
        private DataGridView grdPayroll;
        private Label lblTotalAccrued;
        private Label lblTotalDiscounts;
        private Label lblTotalLiquid;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn salaryBase;
        private DataGridViewTextBoxColumn overtime;
        private DataGridViewTextBoxColumn overtimeValue;
        private DataGridViewTextBoxColumn commission;
        private DataGridViewTextBoxColumn bonuses;
        private DataGridViewTextBoxColumn totalAccrued;
        private DataGridViewTextBoxColumn IGSS;
        private DataGridViewTextBoxColumn ISR;
        private DataGridViewTextBoxColumn advancePayments;
        private DataGridViewTextBoxColumn court;
        private DataGridViewTextBoxColumn loans;
        private DataGridViewTextBoxColumn totalDiscounts;
        private DataGridViewTextBoxColumn totalLiquid;
    }
}