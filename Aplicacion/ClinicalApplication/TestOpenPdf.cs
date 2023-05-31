using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Agregar esta directiva
using System.Diagnostics; // Agregar esta directiva
using System.Data.SqlClient; // Agregar esta directiva
using static iTextSharp.tool.xml.html.HTML;

namespace ClinicalApplication
{
    public partial class TestOpenPdf : Form
    {
        public TestOpenPdf()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            int invoiceId = int.Parse(txtIdInvoice.Text); // ID del registro de la factura que deseas visualizar
            string query = "SELECT doc FROM invoice WHERE id = @invoiceId";

            // Crea y abre una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection("Server=tcp:clinica-prueba.database.windows.net,1433;Initial Catalog=clinicaDB;Persist Security Info=False;User ID=admin12;Password=admin3212*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                connection.Open();

                // Crea un comando con la consulta y los parámetros necesarios
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@invoiceId", invoiceId);

                    // Ejecuta la consulta y obtén el resultado
                    byte[] pdfData = (byte[])command.ExecuteScalar();

                    // Cierra la conexión
                    connection.Close();

                    // Verifica si se obtuvo el archivo PDF
                    if (pdfData != null)
                    {
                        // Guarda el archivo PDF temporalmente en el disco
                        string filePath = "temp.pdf";
                        File.WriteAllBytes(filePath, pdfData);

                        // Abre el archivo PDF con una aplicación específica
                        OpenPdfWithDefaultApplication(filePath);
                    }
                    else
                    {
                        // El campo 'doc' está vacío o el registro no existe
                        MessageBox.Show("No se encontró el archivo PDF.");
                    }
                }
            }
        }

        private void OpenPdfWithDefaultApplication(string filePath)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(filePath);
                startInfo.UseShellExecute = true;
                startInfo.Verb = "open";
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el archivo PDF. Error: " + ex.Message);
            }
        }

        private void btnPurcharseBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestOpenPdf_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            String qprocedure = "viewinvoice";


            if (dataBase.ExecuteQuery(qprocedure))
            {
                grdVistaFactura.Rows.Clear();

                while (dataBase.table.Read())
                {
                    grdVistaFactura.Rows.Add(Convert.ToString(dataBase.table.GetInt32(0)), dataBase.table.GetString(1), dataBase.table.GetString(3), Convert.ToString(dataBase.table.GetDateTime(4)), dataBase.table.GetString(5), dataBase.table.GetString(6));
                }

            }
            else
            {

                MessageBox.Show("Error en la base de datos");
            }
            dataBase.CloseConnection();
        }
    }
}

