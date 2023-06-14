namespace ClinicalApplication
{
    partial class frmIncomeStatement
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
            label1 = new Label();
            grdIncomeStatement = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            IncomeStatementNameAccount = new DataGridViewTextBoxColumn();
            IncomeStatementAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdIncomeStatement).BeginInit();
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
            btnPurcharseBack.TabIndex = 9;
            btnPurcharseBack.UseVisualStyleBackColor = false;
            btnPurcharseBack.Click += btnPurcharseBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(214, 117);
            label1.Name = "label1";
            label1.Size = new Size(289, 37);
            label1.TabIndex = 11;
            label1.Text = "Estado de Resultados";
            // 
            // grdIncomeStatement
            // 
            grdIncomeStatement.AllowUserToAddRows = false;
            grdIncomeStatement.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdIncomeStatement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdIncomeStatement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdIncomeStatement.Columns.AddRange(new DataGridViewColumn[] { x, IncomeStatementNameAccount, IncomeStatementAmount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdIncomeStatement.DefaultCellStyle = dataGridViewCellStyle2;
            grdIncomeStatement.GridColor = Color.FromArgb(128, 255, 255);
            grdIncomeStatement.Location = new Point(12, 171);
            grdIncomeStatement.Name = "grdIncomeStatement";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SkyBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdIncomeStatement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdIncomeStatement.RowTemplate.Height = 25;
            grdIncomeStatement.Size = new Size(680, 344);
            grdIncomeStatement.TabIndex = 12;
            grdIncomeStatement.CellFormatting += grdIncomeStatement_CellFormatting;
            grdIncomeStatement.CellValueChanged += grdIncomeStatement_CellValueChanged;
            // 
            // x
            // 
            x.HeaderText = "---";
            x.Name = "x";
            x.Visible = false;
            x.Width = 10;
            // 
            // IncomeStatementNameAccount
            // 
            IncomeStatementNameAccount.HeaderText = "";
            IncomeStatementNameAccount.Name = "IncomeStatementNameAccount";
            IncomeStatementNameAccount.ReadOnly = true;
            IncomeStatementNameAccount.Width = 350;
            // 
            // IncomeStatementAmount
            // 
            IncomeStatementAmount.HeaderText = "";
            IncomeStatementAmount.Name = "IncomeStatementAmount";
            IncomeStatementAmount.Width = 287;
            // 
            // frmIncomeStatement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 580);
            Controls.Add(grdIncomeStatement);
            Controls.Add(label1);
            Controls.Add(btnPurcharseBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIncomeStatement";
            Text = "frmIncomeStatement";
            Load += frmIncomeStatement_Load;
            ((System.ComponentModel.ISupportInitialize)grdIncomeStatement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnPurcharseBack;
        private Label label1;
        private DataGridView grdIncomeStatement;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn IncomeStatementNameAccount;
        private DataGridViewTextBoxColumn IncomeStatementAmount;
    }
}