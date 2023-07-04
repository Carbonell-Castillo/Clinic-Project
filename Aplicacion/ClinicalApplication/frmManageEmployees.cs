using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTextSharp.tool.xml.html.HTML;

namespace ClinicalApplication
{
    public partial class frmManageEmployees : Form
    {
        private bool isAddingEmployee = false;
        private bool isUpdatingEmployee = false;

        public frmManageEmployees()
        {
            InitializeComponent();
        }

        private void grdManageEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdManageEmployees.Rows[e.RowIndex];

                // Obtener los valores de las celdas y asignarlos a TextBoxes
                txtIdUser.Text = row.Cells[0].Value.ToString();
                txtRoleIDUser.Text = row.Cells[1].Value.ToString();
                txtNameUser.Text = row.Cells[2].Value.ToString();
                txtName.Text = row.Cells[3].Value.ToString();
                txtPasswordUser.Text = row.Cells[4].Value.ToString();
                txtMonthlySalary.Text = row.Cells[5].Value.ToString();
                // ...

                // Repite el proceso para cada TextBox en el que deseas mostrar los valores de la fila seleccionada
            }
        }

        private void frmManageEmployees_Load(object sender, EventArgs e)
        {
            loadDataEmployees();
        }

        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdUser.Text))
            {
                MessageBox.Show("El campo de ID de usuario está vacío");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea despedir a este empleado?", "Eliminar empleado a base de datos", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    DataBase dataBase = new DataBase();
                    String qprocedure;
                    qprocedure = "DeleteUser @userId='" + txtIdUser.Text + "'";

                    if (dataBase.ExecuteQuery(qprocedure))
                    {
                        MessageBox.Show("Se ha borrado el registro del empleado");
                    }
                    else
                    {
                        MessageBox.Show("Error en la base de datos");
                    }
                    dataBase.CloseConnection();
                    loadDataEmployees();
                }
            }
        }

        private void loadDataEmployees()
        {
            DataBase dataBase = new DataBase();
            String qprocedure;
            qprocedure = "viewUsersById @id='" + SG.user.ClincId + "'";

            if (dataBase.ExecuteQuery(qprocedure))
            {
                grdManageEmployees.Rows.Clear();

                while (dataBase.table.Read())
                {
                    grdManageEmployees.Rows.Add(dataBase.table.GetString(0), dataBase.table.GetInt32(2), dataBase.table.GetString(3), dataBase.table.GetString(4), dataBase.table.GetString(5), dataBase.table.GetInt32(6));
                }
            }
            else
            {
                MessageBox.Show("Error en la base de datos");
            }
            dataBase.CloseConnection();
            clearAllTextbox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isAddingEmployee)
            {
                DialogResult result = MessageBox.Show("¿Desea contratar un empleado?", "Añadir empleado a base de datos", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    clearAllTextbox();
                    btnFireEmployee.Enabled = false;
                    btnUpdateEmplyees.Enabled = false;

                    txtIdUser.ReadOnly = false;
                    txtRoleIDUser.ReadOnly = false;
                    txtNameUser.ReadOnly = false;
                    txtName.ReadOnly = false;
                    txtPasswordUser.ReadOnly = false;
                    txtMonthlySalary.ReadOnly = false;

                    isAddingEmployee = true; // Cambiar el estado a "agregando empleado"
                    btnAddEmployees.Text = "Almacenar Empleado";
                }
            }
            else
            {
                if (validateData()) 
                {
                    DataBase dataBase = new DataBase();
                    string qprocedure;

                    string idUser = txtIdUser.Text;
                    int roleId = int.Parse(txtRoleIDUser.Text);
                    string nameUser = txtNameUser.Text;
                    string name = txtName.Text;
                    string password = txtPasswordUser.Text;
                    int monthlySalary = int.Parse(txtMonthlySalary.Text);

                    qprocedure = "addUser @userId=" + idUser;
                    qprocedure = qprocedure + ",@clinicId=" + SG.user.ClincId;
                    qprocedure = qprocedure + ",@roleId=" + roleId;
                    qprocedure = qprocedure + ",@username=" + nameUser;
                    qprocedure = qprocedure + ",@name=" + name;
                    qprocedure = qprocedure + ",@password=" + password;
                    qprocedure = qprocedure + ",@monthlySalary=" + monthlySalary;

                    if (dataBase.ExecuteQuery(qprocedure))
                    {
                        MessageBox.Show("Registro almacenado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    dataBase.CloseConnection();
                    // Guardar los datos ingresados en los TextBox

                    // Aquí puedes realizar la lógica para guardar los datos en la base de datos o hacer cualquier otra acción necesaria

                    // Restablecer los controles al estado inicial
                    btnFireEmployee.Enabled = true;
                    btnUpdateEmplyees.Enabled = true;

                    txtIdUser.ReadOnly = true;
                    txtRoleIDUser.ReadOnly = true;
                    txtNameUser.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtPasswordUser.ReadOnly = true;
                    txtMonthlySalary.ReadOnly = true;

                    // Limpiar los TextBox
                    clearAllTextbox();

                    isAddingEmployee = false; // Cambiar el estado a "no agregando empleado"
                    btnAddEmployees.Text = "Contratar Empleado";
                    loadDataEmployees();
                }
                else
                {
                    MessageBox.Show("Los campos para realizar la transaccion estan vacios");
                }
            }
        }

        private void btnUpdateEmplyees_Click(object sender, EventArgs e)
        {
            if (!isUpdatingEmployee)
            {
                DialogResult result = MessageBox.Show("¿Desea actualizar datos de un empleado?", "Actualizar datos de empleado", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    clearAllTextbox();
                    btnAddEmployees.Enabled = false;
                    btnFireEmployee.Enabled = false;

                    txtIdUser.ReadOnly = false;
                    txtRoleIDUser.ReadOnly = false;
                    txtNameUser.ReadOnly = false;
                    txtName.ReadOnly = false;
                    txtPasswordUser.ReadOnly = false;
                    txtMonthlySalary.ReadOnly = false;

                    isUpdatingEmployee = true;
                    btnUpdateEmplyees.Text = "Actualizar Empleado";
                }
            }
            else
            {
                if (validateData()) 
                {
                    DataBase dataBase = new DataBase();
                    string qprocedure;

                    string idUser = "'" + txtIdUser.Text + "'";
                    int roleId = int.Parse(txtRoleIDUser.Text);
                    string nameUser = "'" + txtNameUser.Text + "'";
                    string name = "'" + txtName.Text + "'";
                    string password = "'" + txtPasswordUser.Text + "'";
                    int monthlySalary = int.Parse(txtMonthlySalary.Text);

                    qprocedure = "updateUser @userId=" + idUser;
                    qprocedure = qprocedure + ",@clinicId=" + SG.user.ClincId;
                    qprocedure = qprocedure + ",@roleId=" + roleId;
                    qprocedure = qprocedure + ",@username=" + nameUser;
                    qprocedure = qprocedure + ",@name=" + name;
                    qprocedure = qprocedure + ",@password=" + password;
                    qprocedure = qprocedure + ",@monthlySalary=" + monthlySalary;

                    if (dataBase.ExecuteQuery(qprocedure))
                    {
                        MessageBox.Show("Actualizacion realizada exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    dataBase.CloseConnection();
                    // Guardar los datos ingresados en los TextBox

                    // Aquí puedes realizar la lógica para guardar los datos en la base de datos o hacer cualquier otra acción necesaria

                    // Restablecer los controles al estado inicial
                    btnFireEmployee.Enabled = true;
                    btnAddEmployees.Enabled = true;

                    txtIdUser.ReadOnly = true;
                    txtRoleIDUser.ReadOnly = true;
                    txtNameUser.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtPasswordUser.ReadOnly = true;
                    txtMonthlySalary.ReadOnly = true;

                    // Limpiar los TextBox
                    clearAllTextbox();

                    isUpdatingEmployee = false; // Cambiar el estado a "no agregando empleado"
                    btnUpdateEmplyees.Text = "Actualizar Datos";
                    loadDataEmployees();
                }
                else
                {
                    MessageBox.Show("Los campos para realizar la transaccion estan vacios");
                }
            }
        }

        private void clearAllTextbox()
        {
            txtIdUser.Clear();
            txtRoleIDUser.Clear();
            txtNameUser.Clear();
            txtName.Clear();
            txtPasswordUser.Clear();
            txtMonthlySalary.Clear();
        }

        private bool validateData()
        {
            return !string.IsNullOrEmpty(txtIdUser.Text) && !string.IsNullOrEmpty(txtRoleIDUser.Text)
                    && !string.IsNullOrEmpty(txtNameUser.Text) && !string.IsNullOrEmpty(txtName.Text)
                    && !string.IsNullOrEmpty(txtPasswordUser.Text) && !string.IsNullOrEmpty(txtMonthlySalary.Text);
        }
    }
}
