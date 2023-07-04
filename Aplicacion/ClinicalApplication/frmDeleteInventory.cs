using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicalApplication
{
    public partial class frmDeleteInventory : Form
    {
        public frmDeleteInventory()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                Inventory inventory = new Inventory();
                String code = txtCode.Text;


                if (inventory.searchProduct(code))
                {
                    txtbNameObject.Text = inventory.Name;
                    txtbPrice.Text = inventory.Price.ToString();
                    txtbStartingAmount.Text = inventory.Quantity.ToString();
                    cbCategoryAddInventary.SelectedIndex = int.Parse(inventory.CategoryId) - 1;

                }

            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                Inventory inventory = new Inventory();
                String code = txtCode.Text;


                if (inventory.deleteProduct(code))
                {
                    MessageBox.Show("Registro eliminado");
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Los campos estan vacios");
            }
        }

        private void btnPurcharseBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool validateData()
        {
            return !string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtbNameObject.Text)
                && !string.IsNullOrEmpty(txtbStartingAmount.Text) && !string.IsNullOrEmpty(txtbPrice.Text)
                && cbCategoryAddInventary.SelectedIndex > -1;
        }

        public void clear()
        {
            txtCode.Clear();
            txtbNameObject.Clear();
            txtbStartingAmount.Clear();
            txtbPrice.Clear();
            cbCategoryAddInventary.SelectedIndex = -1;
        }
    }
}
