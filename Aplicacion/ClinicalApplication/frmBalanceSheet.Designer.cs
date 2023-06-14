namespace ClinicalApplication
{
    partial class frmBalanceSheet
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnPurcharseBack = new FontAwesome.Sharp.IconButton();
            grdBalanceSheetActive = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            ActiveAccountName = new DataGridViewTextBoxColumn();
            ActiveAmount = new DataGridViewTextBoxColumn();
            label1 = new Label();
            grdBalanceSheetPassiveCapital = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            PassiveCapitalName = new DataGridViewTextBoxColumn();
            PassiveCapitalAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdBalanceSheetActive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdBalanceSheetPassiveCapital).BeginInit();
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
            btnPurcharseBack.TabIndex = 8;
            btnPurcharseBack.UseVisualStyleBackColor = false;
            btnPurcharseBack.Click += btnPurcharseBack_Click;
            // 
            // grdBalanceSheetActive
            // 
            grdBalanceSheetActive.AllowUserToAddRows = false;
            grdBalanceSheetActive.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdBalanceSheetActive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdBalanceSheetActive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBalanceSheetActive.Columns.AddRange(new DataGridViewColumn[] { x, ActiveAccountName, ActiveAmount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdBalanceSheetActive.DefaultCellStyle = dataGridViewCellStyle2;
            grdBalanceSheetActive.Location = new Point(12, 183);
            grdBalanceSheetActive.Name = "grdBalanceSheetActive";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SkyBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdBalanceSheetActive.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdBalanceSheetActive.RowTemplate.Height = 25;
            grdBalanceSheetActive.Size = new Size(338, 375);
            grdBalanceSheetActive.TabIndex = 9;
            grdBalanceSheetActive.CellContentClick += grdBalanceSheet_CellContentClick;
            grdBalanceSheetActive.CellFormatting += grdBalanceSheetActive_CellFormatting;
            grdBalanceSheetActive.CellValueChanged += grdBalanceSheetActive_CellValueChanged;
            // 
            // x
            // 
            x.HeaderText = "---";
            x.Name = "x";
            x.ReadOnly = true;
            x.Visible = false;
            x.Width = 10;
            // 
            // ActiveAccountName
            // 
            ActiveAccountName.HeaderText = "";
            ActiveAccountName.Name = "ActiveAccountName";
            ActiveAccountName.ReadOnly = true;
            ActiveAccountName.Width = 200;
            // 
            // ActiveAmount
            // 
            ActiveAmount.HeaderText = "";
            ActiveAmount.Name = "ActiveAmount";
            ActiveAmount.Width = 95;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(252, 62);
            label1.Name = "label1";
            label1.Size = new Size(222, 37);
            label1.TabIndex = 10;
            label1.Text = "Balance General";
            // 
            // grdBalanceSheetPassiveCapital
            // 
            grdBalanceSheetPassiveCapital.AllowUserToAddRows = false;
            grdBalanceSheetPassiveCapital.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SkyBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdBalanceSheetPassiveCapital.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdBalanceSheetPassiveCapital.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBalanceSheetPassiveCapital.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, PassiveCapitalName, PassiveCapitalAmount });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.SkyBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            grdBalanceSheetPassiveCapital.DefaultCellStyle = dataGridViewCellStyle5;
            grdBalanceSheetPassiveCapital.Location = new Point(356, 183);
            grdBalanceSheetPassiveCapital.Name = "grdBalanceSheetPassiveCapital";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SkyBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            grdBalanceSheetPassiveCapital.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            grdBalanceSheetPassiveCapital.RowTemplate.Height = 25;
            grdBalanceSheetPassiveCapital.Size = new Size(338, 375);
            grdBalanceSheetPassiveCapital.TabIndex = 11;
            grdBalanceSheetPassiveCapital.CellFormatting += grdBalanceSheetPassiveCapital_CellFormatting;
            grdBalanceSheetPassiveCapital.CellValueChanged += grdBalanceSheetPassiveCapital_CellValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(131, 129);
            label2.Name = "label2";
            label2.Size = new Size(112, 37);
            label2.TabIndex = 12;
            label2.Text = "Activos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(407, 129);
            label3.Name = "label3";
            label3.Size = new Size(232, 37);
            label3.TabIndex = 13;
            label3.Text = "Pasivos y Capital";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "---";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 10;
            // 
            // PassiveCapitalName
            // 
            PassiveCapitalName.HeaderText = "";
            PassiveCapitalName.Name = "PassiveCapitalName";
            PassiveCapitalName.ReadOnly = true;
            PassiveCapitalName.Width = 210;
            // 
            // PassiveCapitalAmount
            // 
            PassiveCapitalAmount.HeaderText = "";
            PassiveCapitalAmount.Name = "PassiveCapitalAmount";
            PassiveCapitalAmount.Width = 85;
            // 
            // frmBalanceSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 580);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(grdBalanceSheetPassiveCapital);
            Controls.Add(label1);
            Controls.Add(grdBalanceSheetActive);
            Controls.Add(btnPurcharseBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBalanceSheet";
            Text = "frmBalanceSheet";
            Load += frmBalanceSheet_Load;
            ((System.ComponentModel.ISupportInitialize)grdBalanceSheetActive).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdBalanceSheetPassiveCapital).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnPurcharseBack;
        private DataGridView grdBalanceSheetActive;
        private Label label1;
        private DataGridView grdBalanceSheetPassiveCapital;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn ActiveAccountName;
        private DataGridViewTextBoxColumn ActiveAmount;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn PassiveCapitalName;
        private DataGridViewTextBoxColumn PassiveCapitalAmount;
    }
}