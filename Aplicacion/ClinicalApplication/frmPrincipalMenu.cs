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
    public partial class frmPrincipalMenu : Form
    {
        public frmPrincipalMenu()
        {
            InitializeComponent();
        }

        private void frmPrincipalMenu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Bienvenido " + SG.user.Name + " :)";
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInventary inventary = new frmAddInventary();
            inventary.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultInventory consultInventory = new frmConsultInventory();
            consultInventory.Show();
        }
    }
}
