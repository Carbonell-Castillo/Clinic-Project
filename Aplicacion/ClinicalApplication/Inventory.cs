using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public bool save()
        {
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
            else
            {
                MessageBox.Show("Error in save data");
                return false;
            }
            dataBase.CloseConnection();
        }

        public bool updateQuantity()
        {
            DataBase dataBase = new DataBase();
            string qprocedure;
            id = "'" + id + "'";

            qprocedure = "updateInventoryById @id=" + id;
            qprocedure = qprocedure + ",@newQuantity=" + quantity;

            if (dataBase.ExecuteQuery(qprocedure))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error in save data");
                return false;
            }
            dataBase.CloseConnection();
        }

        public bool searchProduct(String idSearch) {
            DataBase dataBase = new DataBase();

            String qprocedure;

            qprocedure = "searchInventoryById @id= '" + idSearch + "'";

            if (dataBase.ExecuteQuery(qprocedure)) {
                if (dataBase.table.Read())
                {
                    id = dataBase.table.GetString(0);
                    name = dataBase.table.GetString(4);
                    quantity = dataBase.table.GetInt32(5);
                    price= (double)dataBase.table.GetDecimal(6);
                    categoryId = dataBase.table.GetString(2);
                    return true;
                }
                else {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Error in database");
                return false;
            }
            dataBase.CloseConnection();

        }
        public bool updateAll() {
            DataBase dataBase = new DataBase();
            string qprocedure;
            id = "'" + id + "'";
            clinicId = "'" + clinicId + "'";
            categoryId = "'" + categoryId + "'";
            name = "'" + name + "'";

            qprocedure = "updateInventoryByIdAll @id=" + id;
            qprocedure = qprocedure + ",@clinicId=" + clinicId;
            qprocedure = qprocedure + ",@categoryId=" + categoryId;
            qprocedure = qprocedure + ",@name=" + name;
            qprocedure = qprocedure + ",@quantity=" + quantity;
            qprocedure = qprocedure + ",@price=" + price;

            if (dataBase.ExecuteQuery(qprocedure))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error in save data");
                return false;
            }
            dataBase.CloseConnection();
        }

        public bool deleteProduct(String idDelete)
        {
            DataBase dataBase = new DataBase();

            String qprocedure;

            qprocedure = "deleteInventoryById @id= '" + idDelete + "'";

            if (dataBase.ExecuteQuery(qprocedure))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error in save data");
                return false;
            }
            dataBase.CloseConnection();

        }

    }
}
