using System.Windows.Forms;

namespace ClinicalApplication
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();

        }

        private void compasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dDHHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Quise intentar cerrar el Sign In pero no pude jajaja
        private static void CloseSignIn()
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            if (dataBase.Connect())
            {
                lblStatus.Text = "Base de datos conectada";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "Error en la base de datos";
                lblStatus.ForeColor = Color.Red;
            }
            dataBase.CloseConnection();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            User user = new User();
            if (validateData())
            {
                if (user.ValidateUser(txtUser.Text, txtPassword.Text))
                {
                    MessageBox.Show("Bienvenido: " + user.Name);
                    SG.user = user;
                    this.Hide();
                    frmPrincipalMenu formPrincipalMenu = new frmPrincipalMenu();
                    formPrincipalMenu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario invalido");
                }
            }
            else
            {
                MessageBox.Show("Datos Vacios");
            }

        }

        public bool validateData()
        {
            return !string.IsNullOrEmpty(txtUser.Text) &&
            !string.IsNullOrEmpty(txtPassword.Text);
        }



        private void customButton1_Click(object sender, EventArgs e)
        {

            User user = new User();
            if (validateData())
            {
                if (user.ValidateUser(txtUser.Text, txtPassword.Text))
                {
                    MessageBox.Show("Bienvenido: " + user.Name);
                    SG.user = user;
                    this.Hide();
                    FRMDashboard formPrincipalMenu = new FRMDashboard();
                    formPrincipalMenu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario invalido");
                }
            }
            else
            {
                MessageBox.Show("Datos Vacios");
            }

        }

        private int clickCount = 0;
        private bool isPasswordVisible = true;

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            clickCount++;

            // Cambiar la imagen del PictureBox
            if (clickCount % 2 == 1)
            {
                pibSee.Image = Properties.Resources.eye_solid; // Cambia esto por la imagen que desees mostrar
            }
            else
            {
                pibSee.Image = Properties.Resources.eye_slash_solid; // Cambia esto por la imagen que desees mostrar
            }

            // Cambiar la propiedad UseSystemPasswordChar del TextBox
            txtPassword.UseSystemPasswordChar = !isPasswordVisible;
            isPasswordVisible = !isPasswordVisible;
        }
    }
}