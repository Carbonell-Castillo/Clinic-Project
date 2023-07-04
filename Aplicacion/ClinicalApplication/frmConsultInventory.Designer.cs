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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            grdData = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            cbConsultItemsData = new ComboBox();
            btnConsult = new Button();
            btnConsultInventoryClose = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)grdData).BeginInit();
            SuspendLayout();
            // 
            // grdData
            // 
            grdData.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SkyBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdData.Columns.AddRange(new DataGridViewColumn[] { Codigo, Categoria, Nombre, Cantidad, Precio });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.SkyBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            grdData.DefaultCellStyle = dataGridViewCellStyle5;
            grdData.Location = new Point(73, 139);
            grdData.Name = "grdData";
            grdData.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SkyBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            grdData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            grdData.RowTemplate.Height = 25;
            grdData.Size = new Size(544, 377);
            grdData.TabIndex = 0;
            grdData.CellContentClick += grdData_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // cbConsultItemsData
            // 
            cbConsultItemsData.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbConsultItemsData.FormattingEnabled = true;
            cbConsultItemsData.Items.AddRange(new object[] { "Medicamentos", "Medias" });
            cbConsultItemsData.Location = new Point(112, 96);
            cbConsultItemsData.Name = "cbConsultItemsData";
            cbConsultItemsData.Size = new Size(159, 28);
            cbConsultItemsData.TabIndex = 1;
            // 
            // btnConsult
            // 
            btnConsult.BackColor = Color.White;
            btnConsult.FlatStyle = FlatStyle.Popup;
            btnConsult.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsult.Location = new Point(309, 96);
            btnConsult.Name = "btnConsult";
            btnConsult.Size = new Size(112, 28);
            btnConsult.TabIndex = 2;
            btnConsult.Text = "Consultar";
            btnConsult.UseVisualStyleBackColor = false;
            btnConsult.Click += btnConsult_Click;
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
            ClientSize = new Size(704, 557);
            Controls.Add(btnConsultInventoryClose);
            Controls.Add(btnConsult);
            Controls.Add(cbConsultItemsData);
            Controls.Add(grdData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConsultInventory";
            Load += frmConsultInventory_Load;
            ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
            ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnConsultInventoryClose;
    }
}