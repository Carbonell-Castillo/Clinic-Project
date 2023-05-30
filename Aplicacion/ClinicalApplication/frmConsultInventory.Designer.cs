namespace ClinicalApplication
{
    partial class frmConsultInventory
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
            grdData = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            cbConsultItemsData = new ComboBox();
            btnConsult = new Button();
            txtConsultByName = new TextBox();
            btnConsultByName = new Button();
            btnConsultInventoryClose = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)grdData).BeginInit();
            SuspendLayout();
            // 
            // grdData
            // 
            grdData.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdData.Columns.AddRange(new DataGridViewColumn[] { Codigo, Categoria, Nombre, Cantidad, Precio });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdData.DefaultCellStyle = dataGridViewCellStyle2;
            grdData.Location = new Point(73, 139);
            grdData.Name = "grdData";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SkyBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdData.RowTemplate.Height = 25;
            grdData.Size = new Size(544, 377);
            grdData.TabIndex = 0;
            grdData.CellContentClick += grdData_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // cbConsultItemsData
            // 
            cbConsultItemsData.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbConsultItemsData.FormattingEnabled = true;
            cbConsultItemsData.Items.AddRange(new object[] { "Medicamentos", "Medias" });
            cbConsultItemsData.Location = new Point(73, 46);
            cbConsultItemsData.Name = "cbConsultItemsData";
            cbConsultItemsData.Size = new Size(159, 28);
            cbConsultItemsData.TabIndex = 1;
            // 
            // btnConsult
            // 
            btnConsult.BackColor = Color.White;
            btnConsult.FlatStyle = FlatStyle.Popup;
            btnConsult.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsult.Location = new Point(258, 45);
            btnConsult.Name = "btnConsult";
            btnConsult.Size = new Size(112, 28);
            btnConsult.TabIndex = 2;
            btnConsult.Text = "Consultar";
            btnConsult.UseVisualStyleBackColor = false;
            btnConsult.Click += btnConsult_Click;
            // 
            // txtConsultByName
            // 
            txtConsultByName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConsultByName.Location = new Point(72, 99);
            txtConsultByName.Name = "txtConsultByName";
            txtConsultByName.Size = new Size(204, 29);
            txtConsultByName.TabIndex = 3;
            // 
            // btnConsultByName
            // 
            btnConsultByName.BackColor = Color.White;
            btnConsultByName.FlatStyle = FlatStyle.Popup;
            btnConsultByName.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultByName.Location = new Point(300, 99);
            btnConsultByName.Name = "btnConsultByName";
            btnConsultByName.Size = new Size(208, 29);
            btnConsultByName.TabIndex = 4;
            btnConsultByName.Text = "Consultar por Nombre";
            btnConsultByName.UseVisualStyleBackColor = false;
            // 
            // btnConsultInventoryClose
            // 
            btnConsultInventoryClose.BackColor = Color.IndianRed;
            btnConsultInventoryClose.FlatAppearance.BorderSize = 0;
            btnConsultInventoryClose.FlatStyle = FlatStyle.Flat;
            btnConsultInventoryClose.IconChar = FontAwesome.Sharp.IconChar.X;
            btnConsultInventoryClose.IconColor = Color.White;
            btnConsultInventoryClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultInventoryClose.IconSize = 20;
            btnConsultInventoryClose.Location = new Point(620, 35);
            btnConsultInventoryClose.Name = "btnConsultInventoryClose";
            btnConsultInventoryClose.Size = new Size(45, 24);
            btnConsultInventoryClose.TabIndex = 5;
            btnConsultInventoryClose.UseVisualStyleBackColor = false;
            btnConsultInventoryClose.Click += btnConsultInventoryClose_Click;
            // 
            // frmConsultInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(688, 541);
            Controls.Add(btnConsultInventoryClose);
            Controls.Add(btnConsultByName);
            Controls.Add(txtConsultByName);
            Controls.Add(btnConsult);
            Controls.Add(cbConsultItemsData);
            Controls.Add(grdData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConsultInventory";
            Load += frmConsultInventory_Load;
            ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdData;
        private ComboBox cbConsultItemsData;
        private Button btnConsult;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private TextBox txtConsultByName;
        private Button btnConsultByName;
        private FontAwesome.Sharp.IconButton btnConsultInventoryClose;
    }
}