namespace ClinicalApplication
{
    partial class frmDeleteInventory
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
            cmdDelete = new Controls.CustomButton();
            customButton1 = new Controls.CustomButton();
            groupBox1 = new GroupBox();
            txtCode = new TextBox();
            label5 = new Label();
            cbCategoryAddInventary = new ComboBox();
            txtbPrice = new TextBox();
            txtbStartingAmount = new TextBox();
            txtbNameObject = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnPurcharseBack = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmdDelete
            // 
            cmdDelete.BackColor = Color.DodgerBlue;
            cmdDelete.BackgroundColor = Color.DodgerBlue;
            cmdDelete.BorderColor = Color.PaleVioletRed;
            cmdDelete.BorderRadius = 0;
            cmdDelete.BorderSize = 0;
            cmdDelete.FlatAppearance.BorderSize = 0;
            cmdDelete.FlatStyle = FlatStyle.Flat;
            cmdDelete.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmdDelete.ForeColor = Color.White;
            cmdDelete.Location = new Point(476, 267);
            cmdDelete.Name = "cmdDelete";
            cmdDelete.Size = new Size(150, 40);
            cmdDelete.TabIndex = 6;
            cmdDelete.Text = "Eliminar";
            cmdDelete.TextColor = Color.White;
            cmdDelete.UseVisualStyleBackColor = false;
            cmdDelete.Click += cmdDelete_Click;
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
            customButton1.Location = new Point(476, 181);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 40);
            customButton1.TabIndex = 5;
            customButton1.Text = "Buscar";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbCategoryAddInventary);
            groupBox1.Controls.Add(txtbPrice);
            groupBox1.Controls.Add(txtbStartingAmount);
            groupBox1.Controls.Add(txtbNameObject);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(78, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 347);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // txtCode
            // 
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode.Location = new Point(35, 43);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(254, 27);
            txtCode.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(72, 22);
            label5.TabIndex = 8;
            label5.Text = "Codigo:";
            // 
            // cbCategoryAddInventary
            // 
            cbCategoryAddInventary.Enabled = false;
            cbCategoryAddInventary.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategoryAddInventary.FormattingEnabled = true;
            cbCategoryAddInventary.Items.AddRange(new object[] { "Medicamentos", "Medias" });
            cbCategoryAddInventary.Location = new Point(35, 290);
            cbCategoryAddInventary.Name = "cbCategoryAddInventary";
            cbCategoryAddInventary.Size = new Size(254, 28);
            cbCategoryAddInventary.TabIndex = 7;
            // 
            // txtbPrice
            // 
            txtbPrice.BorderStyle = BorderStyle.FixedSingle;
            txtbPrice.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtbPrice.Location = new Point(35, 224);
            txtbPrice.Name = "txtbPrice";
            txtbPrice.ReadOnly = true;
            txtbPrice.Size = new Size(254, 27);
            txtbPrice.TabIndex = 6;
            // 
            // txtbStartingAmount
            // 
            txtbStartingAmount.BorderStyle = BorderStyle.FixedSingle;
            txtbStartingAmount.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtbStartingAmount.Location = new Point(35, 156);
            txtbStartingAmount.Name = "txtbStartingAmount";
            txtbStartingAmount.ReadOnly = true;
            txtbStartingAmount.Size = new Size(254, 27);
            txtbStartingAmount.TabIndex = 5;
            // 
            // txtbNameObject
            // 
            txtbNameObject.BorderStyle = BorderStyle.FixedSingle;
            txtbNameObject.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtbNameObject.Location = new Point(35, 96);
            txtbNameObject.Name = "txtbNameObject";
            txtbNameObject.ReadOnly = true;
            txtbNameObject.Size = new Size(254, 27);
            txtbNameObject.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 200);
            label4.Name = "label4";
            label4.Size = new Size(66, 22);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 266);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 2;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 132);
            label2.Name = "label2";
            label2.Size = new Size(137, 22);
            label2.TabIndex = 1;
            label2.Text = "Cantidad Inicial:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 72);
            label1.Name = "label1";
            label1.Size = new Size(78, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
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
            // frmDeleteInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 557);
            Controls.Add(btnPurcharseBack);
            Controls.Add(cmdDelete);
            Controls.Add(customButton1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDeleteInventory";
            Text = "frmDeleteInventory";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controls.CustomButton cmdDelete;
        private Controls.CustomButton customButton1;
        private GroupBox groupBox1;
        private TextBox txtCode;
        private Label label5;
        private ComboBox cbCategoryAddInventary;
        private TextBox txtbPrice;
        private TextBox txtbStartingAmount;
        private TextBox txtbNameObject;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnPurcharseBack;
    }
}