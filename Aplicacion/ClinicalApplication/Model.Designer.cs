namespace ClinicalApplication
{
    partial class Model
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
            customTextbox1 = new WindowsFormsApp2.customTextbox();
            SuspendLayout();
            // 
            // customTextbox1
            // 
            customTextbox1.BackColor = Color.White;
            customTextbox1.BottomBorderColor = Color.Black;
            customTextbox1.color = Color.White;
            customTextbox1.controlMultiline = false;
            customTextbox1.label_Color = Color.Black;
            customTextbox1.labelName = "Username";
            customTextbox1.Location = new Point(113, 100);
            customTextbox1.Margin = new Padding(4, 3, 4, 3);
            customTextbox1.Name = "customTextbox1";
            customTextbox1.password = false;
            customTextbox1.Size = new Size(349, 68);
            customTextbox1.TabIndex = 0;
            // 
            // Model
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customTextbox1);
            Name = "Model";
            Text = "2";
            ResumeLayout(false);
        }

        #endregion

        private WindowsFormsApp2.customTextbox customTextbox1;
    }
}