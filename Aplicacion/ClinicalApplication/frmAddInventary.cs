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
    public partial class frmAddInventary : Form
    {
        public frmAddInventary()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddObjectInventary_Click(object sender, EventArgs e)
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
                    if (inventory.save())
                    {
                        MessageBox.Show("Registro Guardado");
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

        private void frmAddInventary_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultInventoryClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
