using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalApplication
{
    internal class Inventory
    {
        private String id;
        private String clinicId;
        private String categoryId;
        private String name;
        private int quantity;
        private double price;

        public Inventory()
        {
        }

        public Inventory(string id, string clinicId, string categoryId, string name, int quantity, double price)
        {
            this.id = id;
            this.clinicId = clinicId;
            this.categoryId = categoryId;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public string Id { get => id; set => id = value; }
        public string CategoryId { get => categoryId; set => categoryId = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public string ClinicId { get => clinicId; set => clinicId = value; }

        public bool save() {
            DataBase dataBase = new DataBase();
            string qprocedure;
            id = "'" + id + "'";
            clinicId = "'" + clinicId + "'";
            categoryId = "'" + categoryId + "'";
            name = "'" + name + "'";

            qprocedure = "addInventory @id=" + id;
            qprocedure = qprocedure + ",@clinicId=" + clinicId;
            qprocedure = qprocedure + ",@categoryId=" + categoryId;
            qprocedure = qprocedure + ",@name=" + name;
            qprocedure = qprocedure + ",@quantity=" + quantity;
            qprocedure = qprocedure + ",@price=" + price;

            if (dataBase.ExecuteQuery(qprocedure))
            {
                return true;
            }
            else {
                MessageBox.Show("Error in save data");
                return false;
            }



        }
    }
}
