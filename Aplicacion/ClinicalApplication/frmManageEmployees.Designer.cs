namespace ClinicalApplication
{
    partial class frmManageEmployees
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
            grdManageEmployees = new DataGridView();
            userId = new DataGridViewTextBoxColumn();
            roleId = new DataGridViewTextBoxColumn();
            usarname = new DataGridViewTextBoxColumn();
            nameUser = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            monthlySalary = new DataGridViewTextBoxColumn();
            btnPurcharseBack = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtIdUser = new TextBox();
            label2 = new Label();
            txtNameUser = new TextBox();
            btnAddEmployees = new Controls.CustomButton();
            btnFireEmployee = new Controls.CustomButton();
            btnUpdateEmplyees = new Controls.CustomButton();
            txtRoleIDUser = new TextBox();
            label3 = new Label();
            txtPasswordUser = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtMonthlySalary = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdManageEmployees).BeginInit();
            SuspendLayout();
            // 
            // grdManageEmployees
            // 
            grdManageEmployees.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SkyBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdManageEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdManageEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdManageEmployees.Columns.AddRange(new DataGridViewColumn[] { userId, roleId, usarname, nameUser, password, monthlySalary });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.SkyBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            grdManageEmployees.DefaultCellStyle = dataGridViewCellStyle5;
            grdManageEmployees.Location = new Point(12, 88);
            grdManageEmployees.Name = "grdManageEmployees";
            grdManageEmployees.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SkyBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            grdManageEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            grdManageEmployees.RowTemplate.Height = 25;
            grdManageEmployees.Size = new Size(503, 379);
            grdManageEmployees.TabIndex = 0;
            grdManageEmployees.CellClick += grdManageEmployees_CellClick;
            // 
            // userId
            // 
            userId.HeaderText = "Id Usuario";
            userId.Name = "userId";
            userId.ReadOnly = true;
            // 
            // roleId
            // 
            roleId.HeaderText = "Id Rol";
            roleId.Name = "roleId";
            roleId.ReadOnly = true;
            // 
            // usarname
            // 
            usarname.HeaderText = "Nombre de Usuario";
            usarname.Name = "usarname";
            usarname.ReadOnly = true;
            // 
            // nameUser
            // 
            nameUser.HeaderText = "Nombre";
            nameUser.Name = "nameUser";
            nameUser.ReadOnly = true;
            // 
            // password
            // 
            password.HeaderText = "Contraseña";
            password.Name = "password";
            password.ReadOnly = true;
            // 
            // monthlySalary
            // 
            monthlySalary.HeaderText = "Sueldo Base";
            monthlySalary.Name = "monthlySalary";
            monthlySalary.ReadOnly = true;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(521, 87);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "ID de Usuario";
            // 
            // txtIdUser
            // 
            txtIdUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUser.Location = new Point(521, 111);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.ReadOnly = true;
            txtIdUser.Size = new Size(161, 29);
            txtIdUser.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(521, 215);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 10;
            label2.Text = "Nombre de Usuario";
            // 
            // txtNameUser
            // 
            txtNameUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameUser.Location = new Point(521, 239);
            txtNameUser.Name = "txtNameUser";
            txtNameUser.ReadOnly = true;
            txtNameUser.Size = new Size(161, 29);
            txtNameUser.TabIndex = 11;
            // 
            // btnAddEmployees
            // 
            btnAddEmployees.BackColor = Color.DodgerBlue;
            btnAddEmployees.BackgroundColor = Color.DodgerBlue;
            btnAddEmployees.BorderColor = Color.PaleVioletRed;
            btnAddEmployees.BorderRadius = 0;
            btnAddEmployees.BorderSize = 0;
            btnAddEmployees.FlatAppearance.BorderSize = 0;
            btnAddEmployees.FlatStyle = FlatStyle.Flat;
            btnAddEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEmployees.ForeColor = Color.White;
            btnAddEmployees.Location = new Point(101, 500);
            btnAddEmployees.Name = "btnAddEmployees";
            btnAddEmployees.Size = new Size(137, 54);
            btnAddEmployees.TabIndex = 12;
            btnAddEmployees.Text = "Contratar Empleado";
            btnAddEmployees.TextColor = Color.White;
            btnAddEmployees.UseVisualStyleBackColor = false;
            btnAddEmployees.Click += btnAdd_Click;
            // 
            // btnFireEmployee
            // 
            btnFireEmployee.BackColor = Color.DodgerBlue;
            btnFireEmployee.BackgroundColor = Color.DodgerBlue;
            btnFireEmployee.BorderColor = Color.PaleVioletRed;
            btnFireEmployee.BorderRadius = 0;
            btnFireEmployee.BorderSize = 0;
            btnFireEmployee.FlatAppearance.BorderSize = 0;
            btnFireEmployee.FlatStyle = FlatStyle.Flat;
            btnFireEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFireEmployee.ForeColor = Color.White;
            btnFireEmployee.Location = new Point(479, 500);
            btnFireEmployee.Name = "btnFireEmployee";
            btnFireEmployee.Size = new Size(137, 54);
            btnFireEmployee.TabIndex = 13;
            btnFireEmployee.Text = "Despedir Empleado";
            btnFireEmployee.TextColor = Color.White;
            btnFireEmployee.UseVisualStyleBackColor = false;
            btnFireEmployee.Click += btnFireEmployee_Click;
            // 
            // btnUpdateEmplyees
            // 
            btnUpdateEmplyees.BackColor = Color.DodgerBlue;
            btnUpdateEmplyees.BackgroundColor = Color.DodgerBlue;
            btnUpdateEmplyees.BorderColor = Color.PaleVioletRed;
            btnUpdateEmplyees.BorderRadius = 0;
            btnUpdateEmplyees.BorderSize = 0;
            btnUpdateEmplyees.FlatAppearance.BorderSize = 0;
            btnUpdateEmplyees.FlatStyle = FlatStyle.Flat;
            btnUpdateEmplyees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateEmplyees.ForeColor = Color.White;
            btnUpdateEmplyees.Location = new Point(291, 500);
            btnUpdateEmplyees.Name = "btnUpdateEmplyees";
            btnUpdateEmplyees.Size = new Size(137, 54);
            btnUpdateEmplyees.TabIndex = 14;
            btnUpdateEmplyees.Text = "Actualizar Datos";
            btnUpdateEmplyees.TextColor = Color.White;
            btnUpdateEmplyees.UseVisualStyleBackColor = false;
            btnUpdateEmplyees.Click += btnUpdateEmplyees_Click;
            // 
            // txtRoleIDUser
            // 
            txtRoleIDUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoleIDUser.Location = new Point(521, 173);
            txtRoleIDUser.Name = "txtRoleIDUser";
            txtRoleIDUser.ReadOnly = true;
            txtRoleIDUser.Size = new Size(161, 29);
            txtRoleIDUser.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(521, 149);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 15;
            label3.Text = "Rol ID";
            // 
            // txtPasswordUser
            // 
            txtPasswordUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswordUser.Location = new Point(521, 370);
            txtPasswordUser.Name = "txtPasswordUser";
            txtPasswordUser.ReadOnly = true;
            txtPasswordUser.Size = new Size(161, 29);
            txtPasswordUser.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(521, 346);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 17;
            label4.Text = "Contraseña";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(521, 307);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(161, 29);
            txtName.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(521, 283);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 19;
            label5.Text = "Nombre";
            // 
            // txtMonthlySalary
            // 
            txtMonthlySalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonthlySalary.Location = new Point(521, 437);
            txtMonthlySalary.Name = "txtMonthlySalary";
            txtMonthlySalary.ReadOnly = true;
            txtMonthlySalary.Size = new Size(161, 29);
            txtMonthlySalary.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(521, 413);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 21;
            label6.Text = "Sueldo Base";
            // 
            // frmManageEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 580);
            Controls.Add(txtMonthlySalary);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(txtPasswordUser);
            Controls.Add(label4);
            Controls.Add(txtRoleIDUser);
            Controls.Add(label3);
            Controls.Add(btnUpdateEmplyees);
            Controls.Add(btnFireEmployee);
            Controls.Add(btnAddEmployees);
            Controls.Add(txtNameUser);
            Controls.Add(label2);
            Controls.Add(txtIdUser);
            Controls.Add(label1);
            Controls.Add(btnPurcharseBack);
            Controls.Add(grdManageEmployees);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManageEmployees";
            Text = "frmManageEmployees";
            Load += frmManageEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)grdManageEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdManageEmployees;
        private FontAwesome.Sharp.IconButton btnPurcharseBack;
        private Label label1;
        private TextBox txtIdUser;
        private Label label2;
        private TextBox txtNameUser;
        private Controls.CustomButton btnAddEmployees;
        private Controls.CustomButton btnFireEmployee;
        private Controls.CustomButton btnUpdateEmplyees;
        private TextBox txtRoleIDUser;
        private Label label3;
        private TextBox txtPasswordUser;
        private Label label4;
        private TextBox txtName;
        private Label label5;
        private TextBox txtMonthlySalary;
        private Label label6;
        private DataGridViewTextBoxColumn userId;
        private DataGridViewTextBoxColumn roleId;
        private DataGridViewTextBoxColumn usarname;
        private DataGridViewTextBoxColumn nameUser;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn monthlySalary;
    }
}