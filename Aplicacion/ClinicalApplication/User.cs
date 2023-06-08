using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalApplication
{
    internal class User
    {
        private String userId;
        private String clincId;
        private int roleId;
        private String roleName;
        private String username;
        private String name;
        private int monthlySalary;

        public User()
        {
        }

        public User(string userId, string clincId, int roleId, string roleName, string username, string name, int monthlySalary)
        {
            this.userId = userId;
            this.clincId = clincId;
            this.roleId = roleId;
            this.roleName = roleName;
            this.username = username;
            this.name = name;
            this.monthlySalary = monthlySalary;
        }

        public string UserId { get => userId; set => userId = value; }
        public string ClincId { get => clincId; set => clincId = value; }
        public int RoleId { get => roleId; set => roleId = value; }
        public string RoleName { get => roleName; set => roleName = value; }
        public string Username { get => username; set => username = value; }
        public string Name { get => name; set => name = value; }
        public int MonthlySalary { get => monthlySalary; set => monthlySalary = value; }

        //Funcion que sirve para validar el usuario que se ingreso
        public bool ValidateUser(string usernameValidate, string passwordValidate)
        {
            //Se crea una instancia de la clase DataBase
            DataBase dataBase = new DataBase();
            //El procedimiento almacenado se genera por el nombre de usuario y contraseña proporcionados
            string procedure = "validateUser @username='" + usernameValidate + "', " + "@password='" + passwordValidate + "'";
            if (dataBase.ExecuteQuery(procedure))
            {
                //Si se encuentra la informacion se lee y se asigna a dichas variables
                if (dataBase.table.Read())
                {
                    userId = dataBase.table.GetString(0);
                    clincId = dataBase.table.GetString(1);
                    roleId = dataBase.table.GetInt32(2);
                    roleName = dataBase.table.GetString(3);
                    username = dataBase.table.GetString(4);
                    name = dataBase.table.GetString(5);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Error in the database");
                return false;
            }
            dataBase.CloseConnection();
        }

    }
}
