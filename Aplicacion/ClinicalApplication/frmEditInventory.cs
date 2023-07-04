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
    public partial class frmEditInventory : Form
    {
        public frmEditInventory()
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

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();

            Boolean validation = false;
            if (validateData())
            {

                try
                {
                    inventory.Id = txtCode.Text;
                    inventory.ClinicId = SG.user.ClincId;
                    inventory.CategoryId = (cbCategoryAddInventary.SelectedIndex + 1).ToString();
                    inventory.Name = txtbNameObject.Text;
                    inventory.Quantity = int.Parse(txtbStartingAmount.Text);
                    inventory.Price = double.Parse(txtbPrice.Text);
                    validation = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error datos invalidos");
                }

                if (validation)
                {
                    if (inventory.updateAll())
                    {
                        MessageBox.Show("Registro Actualizado");
                        clear();
                    }

                }
            }
            else
            {
                MessageBox.Show("Los campos estan vacios");
            }
        }

        public void clear()
        {
            txtCode.Clear();
            txtbNameObject.Clear();
            txtbStartingAmount.Clear();
            txtbPrice.Clear();
            cbCategoryAddInventary.SelectedIndex = -1;
        }

        public bool validateData()
        {
            return !string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtbNameObject.Text)
                && !string.IsNullOrEmpty(txtbStartingAmount.Text) && !string.IsNullOrEmpty(txtbPrice.Text)
                && cbCategoryAddInventary.SelectedIndex > -1;
        }

        private void btnPurcharseBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
