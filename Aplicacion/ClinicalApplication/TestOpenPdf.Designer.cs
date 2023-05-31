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
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.MediumSlateBlue;
            customButton1.BackgroundColor = Color.MediumSlateBlue;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 0;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(58, 214);
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
            txtIdInvoice.Location = new Point(120, 117);
            txtIdInvoice.Name = "txtIdInvoice";
            txtIdInvoice.Size = new Size(100, 23);
            txtIdInvoice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 117);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // TestOpenPdf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtIdInvoice);
            Controls.Add(customButton1);
            Name = "TestOpenPdf";
            Text = "TestOpenPdf";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.CustomButton customButton1;
        private TextBox txtIdInvoice;
        private Label label1;
    }
}