namespace ClinicalApplication
{
    partial class TestOpenPdf
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
            customButton1 = new Controls.CustomButton();
            txtIdInvoice = new TextBox();
            label1 = new Label();
            btnPurcharseBack = new FontAwesome.Sharp.IconButton();
            grdVistaFactura = new DataGridView();
            IDFactura = new DataGridViewTextBoxColumn();
            clinicIDFactura = new DataGridViewTextBoxColumn();
            usuarioFactura = new DataGridViewTextBoxColumn();
            fechaFactura = new DataGridViewTextBoxColumn();
            NITFactura = new DataGridViewTextBoxColumn();
            clienteFactura = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdVistaFactura).BeginInit();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.DodgerBlue;
            customButton1.BackgroundColor = Color.DodgerBlue;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 0;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(487, 126);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(137, 29);
            customButton1.TabIndex = 0;
            customButton1.Text = "Abrir pdf";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // txtIdInvoice
            // 
            txtIdInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdInvoice.Location = new Point(247, 126);
            txtIdInvoice.Name = "txtIdInvoice";
            txtIdInvoice.Size = new Size(117, 29);
            txtIdInvoice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 126);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el ID del pdf:";
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
            btnPurcharseBack.TabIndex = 88;
            btnPurcharseBack.UseVisualStyleBackColor = false;
            btnPurcharseBack.Click += btnPurcharseBack_Click;
            // 
            // grdVistaFactura
            // 
            grdVistaFactura.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdVistaFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdVistaFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVistaFactura.Columns.AddRange(new DataGridViewColumn[] { IDFactura, clinicIDFactura, usuarioFactura, fechaFactura, NITFactura, clienteFactura });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdVistaFactura.DefaultCellStyle = dataGridViewCellStyle2;
            grdVistaFactura.Location = new Point(21, 188);
            grdVistaFactura.Name = "grdVistaFactura";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SkyBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdVistaFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdVistaFactura.RowTemplate.Height = 25;
            grdVistaFactura.Size = new Size(644, 150);
            grdVistaFactura.TabIndex = 89;
            // 
            // IDFactura
            // 
            IDFactura.HeaderText = "ID";
            IDFactura.Name = "IDFactura";
            // 
            // clinicIDFactura
            // 
            clinicIDFactura.HeaderText = "ID Clinica";
            clinicIDFactura.Name = "clinicIDFactura";
            // 
            // usuarioFactura
            // 
            usuarioFactura.HeaderText = "Usuario";
            usuarioFactura.Name = "usuarioFactura";
            // 
            // fechaFactura
            // 
            fechaFactura.HeaderText = "Fecha";
            fechaFactura.Name = "fechaFactura";
            // 
            // NITFactura
            // 
            NITFactura.HeaderText = "NIT";
            NITFactura.Name = "NITFactura";
            // 
            // clienteFactura
            // 
            clienteFactura.HeaderText = "Cliente";
            clienteFactura.Name = "clienteFactura";
            // 
            // TestOpenPdf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(688, 518);
            Controls.Add(grdVistaFactura);
            Controls.Add(btnPurcharseBack);
            Controls.Add(label1);
            Controls.Add(txtIdInvoice);
            Controls.Add(customButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TestOpenPdf";
            Text = "TestOpenPdf";
            Load += TestOpenPdf_Load;
            ((System.ComponentModel.ISupportInitialize)grdVistaFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.CustomButton customButton1;
        private TextBox txtIdInvoice;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnPurcharseBack;
        private DataGridView grdVistaFactura;
        private DataGridViewTextBoxColumn IDFactura;
        private DataGridViewTextBoxColumn clinicIDFactura;
        private DataGridViewTextBoxColumn usuarioFactura;
        private DataGridViewTextBoxColumn fechaFactura;
        private DataGridViewTextBoxColumn NITFactura;
        private DataGridViewTextBoxColumn clienteFactura;
    }
}