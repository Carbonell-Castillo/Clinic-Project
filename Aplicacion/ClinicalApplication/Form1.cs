using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using static iTextSharp.tool.xml.html.HTML;

namespace ClinicalApplication
{
    public partial class frmFactura : Form
    {

        public frmFactura()
        {
            InitializeComponent();
        }


        private void btnCrearPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            grdPreviewBill.Rows.Add(txtType.Text, "1", "Consulta", txtConsultPrice.Text, txtConsultPrice.Text);

            string paginathtml_texto = Properties.Resources.plantilla.ToString();
            paginathtml_texto = paginathtml_texto.Replace("@nombre", txtNameClient.Text);
            paginathtml_texto = paginathtml_texto.Replace("@nit", txtNITClient.Text);
            paginathtml_texto = paginathtml_texto.Replace("@tipo", txtType.Text);

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in grdPreviewBill.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Importe"].Value.ToString());
            }
            paginathtml_texto = paginathtml_texto.Replace("@FILAS", filas);
            paginathtml_texto = paginathtml_texto.Replace("@TOTAL", total.ToString());


            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(120, 120);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 100);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(paginathtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            String qprocedure;
            qprocedure = "viewInventoryByClinic @clinicId='" + SG.user.ClincId + "'";

            if (dataBase.ExecuteQuery(qprocedure))
            {
                cboMedicaments.Items.Clear();
                grdPreviewBill.Rows.Clear();

                while (dataBase.table.Read())
                {
                    cboMedicaments.Items.Add(dataBase.table.GetString(4));
                }
            }
            else
            {
                MessageBox.Show("Error en la base de datos");
            }
            dataBase.CloseConnection();

            grdPreviewBill.Columns.Add("Nombre", "Nombre");
            grdPreviewBill.Columns.Add("Cantidad", "Cantidad");
            grdPreviewBill.Columns.Add("Descripcion", "Descripcion");
            grdPreviewBill.Columns.Add("PrecioUnitario", "Precio Unitario");
            grdPreviewBill.Columns.Add("Importe", "Importe");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMedicament_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            String qprocedure;
            qprocedure = "viewInventoryByClinic @clinicId='" + SG.user.ClincId + "'";
            decimal price = 0;

            if (dataBase.ExecuteQuery(qprocedure))
            {
                while (dataBase.table.Read())
                {
                    string x = dataBase.table.GetString(4);
                    if (x.Equals(cboMedicaments.Text))
                    {
                        price = dataBase.table.GetDecimal(6);
                    }
                }
            }
            else
            {

                MessageBox.Show("Error en la base de datos");
            }
            dataBase.CloseConnection();


            int indice_fila = grdPreviewBill.Rows.Add();
            DataGridViewRow row = grdPreviewBill.Rows[indice_fila];

            row.Cells["Nombre"].Value = cboMedicaments.Text;
            row.Cells["Cantidad"].Value = txtQuantity.Text;
            row.Cells["Descripcion"].Value = txtDescription.Text;
            row.Cells["PrecioUnitario"].Value = price;
            row.Cells["Importe"].Value = decimal.Parse(txtQuantity.Text) * price;
        }

        private void btnPurcharseBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
