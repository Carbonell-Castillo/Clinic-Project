namespace ClinicalApplication
{
    partial class frmFactura
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
            btnCrearPDF = new Controls.CustomButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtNITClient = new TextBox();
            txtNameClient = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtQuantity = new TextBox();
            btnAddMedicament = new Button();
            label4 = new Label();
            cboMedicaments = new ComboBox();
            txtDescription = new TextBox();
            groupBox3 = new GroupBox();
            txtConsultPrice = new TextBox();
            label6 = new Label();
            txtType = new TextBox();
            label5 = new Label();
            grdPreviewBill = new DataGridView();
            btnPurcharseBack = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPreviewBill).BeginInit();
            SuspendLayout();
            // 
            // btnCrearPDF
            // 
            btnCrearPDF.BackColor = Color.DodgerBlue;
            btnCrearPDF.BackgroundColor = Color.DodgerBlue;
            btnCrearPDF.BorderColor = Color.PaleVioletRed;
            btnCrearPDF.BorderRadius = 0;
            btnCrearPDF.BorderSize = 0;
            btnCrearPDF.FlatAppearance.BorderSize = 0;
            btnCrearPDF.FlatStyle = FlatStyle.Flat;
            btnCrearPDF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearPDF.ForeColor = Color.White;
            btnCrearPDF.Location = new Point(414, 249);
            btnCrearPDF.Name = "btnCrearPDF";
            btnCrearPDF.Size = new Size(141, 56);
            btnCrearPDF.TabIndex = 1;
            btnCrearPDF.Text = "Generar factura y recetario";
            btnCrearPDF.TextColor = Color.White;
            btnCrearPDF.UseVisualStyleBackColor = false;
            btnCrearPDF.Click += btnCrearPDF_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNITClient);
            groupBox1.Controls.Add(txtNameClient);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(34, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 78);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // txtNITClient
            // 
            txtNITClient.Location = new Point(358, 32);
            txtNITClient.Name = "txtNITClient";
            txtNITClient.Size = new Size(189, 29);
            txtNITClient.TabIndex = 6;
            // 
            // txtNameClient
            // 
            txtNameClient.Location = new Point(93, 32);
            txtNameClient.Name = "txtNameClient";
            txtNameClient.Size = new Size(192, 29);
            txtNameClient.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 35);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 4;
            label2.Text = "NIT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 89);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Controls.Add(btnAddMedicament);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboMedicaments);
            groupBox2.Controls.Add(txtDescription);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(34, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 216);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medicamentos a Recetar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 71);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 11;
            label7.Text = "Cantidad:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(92, 68);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(191, 29);
            txtQuantity.TabIndex = 10;
            // 
            // btnAddMedicament
            // 
            btnAddMedicament.BackColor = Color.DodgerBlue;
            btnAddMedicament.ForeColor = Color.White;
            btnAddMedicament.Location = new Point(59, 164);
            btnAddMedicament.Name = "btnAddMedicament";
            btnAddMedicament.Size = new Size(175, 45);
            btnAddMedicament.TabIndex = 9;
            btnAddMedicament.Text = "Añadir medicamento";
            btnAddMedicament.UseVisualStyleBackColor = false;
            btnAddMedicament.Click += btnAddMedicament_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 105);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 8;
            label4.Text = "Descripción:";
            // 
            // cboMedicaments
            // 
            cboMedicaments.FormattingEnabled = true;
            cboMedicaments.Location = new Point(11, 28);
            cboMedicaments.Name = "cboMedicaments";
            cboMedicaments.Size = new Size(188, 29);
            cboMedicaments.TabIndex = 7;
            cboMedicaments.SelectedIndexChanged += cboMedicaments_SelectedIndexChanged_1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(11, 129);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(274, 29);
            txtDescription.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtConsultPrice);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtType);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(349, 96);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 141);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de Consulta";
            // 
            // txtConsultPrice
            // 
            txtConsultPrice.Location = new Point(75, 92);
            txtConsultPrice.Name = "txtConsultPrice";
            txtConsultPrice.Size = new Size(157, 29);
            txtConsultPrice.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 95);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 8;
            label6.Text = "Precio:";
            // 
            // txtType
            // 
            txtType.Location = new Point(65, 35);
            txtType.Name = "txtType";
            txtType.Size = new Size(167, 29);
            txtType.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 38);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 6;
            label5.Text = "Tipo:";
            label5.Click += label5_Click;
            // 
            // grdPreviewBill
            // 
            grdPreviewBill.AllowUserToAddRows = false;
            grdPreviewBill.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SkyBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdPreviewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdPreviewBill.ColumnHeadersHeight = 30;
            grdPreviewBill.EnableHeadersVisualStyles = false;
            grdPreviewBill.GridColor = Color.DimGray;
            grdPreviewBill.Location = new Point(91, 318);
            grdPreviewBill.MultiSelect = false;
            grdPreviewBill.Name = "grdPreviewBill";
            grdPreviewBill.ReadOnly = true;
            grdPreviewBill.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SkyBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdPreviewBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdPreviewBill.RowTemplate.Height = 25;
            grdPreviewBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdPreviewBill.Size = new Size(537, 211);
            grdPreviewBill.TabIndex = 86;
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
            btnPurcharseBack.TabIndex = 87;
            btnPurcharseBack.UseVisualStyleBackColor = false;
            btnPurcharseBack.Click += btnPurcharseBack_Click;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 557);
            Controls.Add(btnPurcharseBack);
            Controls.Add(grdPreviewBill);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCrearPDF);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFactura";
            Load += frmFactura_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdPreviewBill).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Controls.CustomButton btnCrearPDF;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox txtNITClient;
        private TextBox txtNameClient;
        private ComboBox cboMedicaments;
        private TextBox txtDescription;
        private Button btnAddMedicament;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txtType;
        private Label label5;
        private TextBox txtConsultPrice;
        private Label label6;
        private Label label7;
        private TextBox txtQuantity;
        private DataGridView grdPreviewBill;
        private FontAwesome.Sharp.IconButton btnPurcharseBack;
    }
}