using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicalApplication
{
    public partial class frmConsultInventory : Form
    {
        public frmConsultInventory()
        {
            InitializeComponent();
        }

        private void frmConsultInventory_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        public void loadData(String category)
        {
            DataBase dataBase = new DataBase();
            String qprocedure;
            if (string.IsNullOrEmpty(category))
            {
                qprocedure = "viewInventoryByClinic @clinicId='" + SG.user.ClincId + "'";
            }
            else
            {
                qprocedure = "viewInventoryByCategory @clinicId='" + SG.user.ClincId + "', @categoryId='" + category + "'";
            }


            if (dataBase.ExecuteQuery(qprocedure))
            {
                grdData.Rows.Clear();

                while (dataBase.table.Read())
                {
                    grdData.Rows.Add(dataBase.table.GetString(0), dataBase.table.GetString(3), dataBase.table.GetString(4), dataBase.table.GetInt32(5), dataBase.table.GetDecimal(6));
                }

            }
            else
            {

                MessageBox.Show("Error en la base de datos");
            }
            dataBase.CloseConnection();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            if (cbConsultItemsData.SelectedIndex > -1)
            {
                loadData((cbConsultItemsData.SelectedIndex + 1).ToString());
            }


        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultInventoryClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
