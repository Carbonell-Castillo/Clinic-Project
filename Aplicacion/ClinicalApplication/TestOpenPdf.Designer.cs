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
            customButton1 = new Controls.CustomButton();
            txtIdInvoice = new TextBox();
            label1 = new Label();
            btnPurcharseBack = new FontAwesome.Sharp.IconButton();
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
            customButton1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(273, 268);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 40);
            customButton1.TabIndex = 0;
            customButton1.Text = "Abrir pdf";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // txtIdInvoice
            // 
            txtIdInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdInvoice.Location = new Point(386, 220);
            txtIdInvoice.Name = "txtIdInvoice";
            txtIdInvoice.Size = new Size(100, 29);
            txtIdInvoice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(217, 220);
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
            // TestOpenPdf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 518);
            Controls.Add(btnPurcharseBack);
            Controls.Add(label1);
            Controls.Add(txtIdInvoice);
            Controls.Add(customButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TestOpenPdf";
            Text = "TestOpenPdf";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.CustomButton customButton1;
        private TextBox txtIdInvoice;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnPurcharseBack;
    }
}