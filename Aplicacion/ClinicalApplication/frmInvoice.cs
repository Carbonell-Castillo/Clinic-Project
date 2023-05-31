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
using System.Xml.Linq;
using System.Collections;

namespace ClinicalApplication
{


    public partial class frmFactura : Form
    {
        ElementInvoice elementInvoice = new ElementInvoice();
        public frmFactura()
        {
            InitializeComponent();
        }

        private byte[] GeneratePdfFromHtml(string htmlContent)
        {
            using (MemoryStream outputStream = new MemoryStream())
            {
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, outputStream);

                pdfDoc.Open();

                using (StringReader sr = new StringReader(htmlContent))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();

                byte[] pdfData = outputStream.ToArray();
                return pdfData;
            }
        }
        private void btnCrearPDF_Click(object sender, EventArgs e)
        {
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

            byte[] docData = GeneratePdfFromHtml(paginathtml_texto);

            Invoice invoice = new Invoice();
            Boolean validation = false;

            try
            {
                invoice.ClinicId = SG.user.ClincId;
                invoice.UserId = Int32.Parse(SG.user.UserId);
                invoice.Nit = txtNITClient.Text;
                invoice.Name = txtNameClient.Text;
                invoice.DocData = docData;


                validation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error datos invalidos");
            }

            if (validation) { }
            if (invoice.Save())
            {
                MessageBox.Show("Registro Guardado");
            }

            UpdateQuantityElements();
        }

        public void UpdateQuantityElements()
        {

            Inventory inventory = new Inventory();
            foreach (ElementInvoice element in elements)
            {
                inventory.Id = elementInvoice.Id1;
                inventory.Quantity = elementInvoice.Quantity1;

                if (inventory.updateQuantity())
                {
                    MessageBox.Show("Actualizado");
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
        decimal price = 0;
        int quantityExistProduct = 0;
        String idElement = "";

        ArrayList elements = new ArrayList();
        private void btnAddMedicament_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                int quantity = int.Parse(txtQuantity.Text);
                if (quantityExistProduct >= 1 && quantity <= quantityExistProduct)
                {
                    //We added element of the list


                    int indice_fila = grdPreviewBill.Rows.Add();
                    DataGridViewRow row = grdPreviewBill.Rows[indice_fila];

                    row.Cells["Nombre"].Value = cboMedicaments.Text;
                    row.Cells["Cantidad"].Value = txtQuantity.Text;
                    row.Cells["Descripcion"].Value = txtDescription.Text;
                    row.Cells["PrecioUnitario"].Value = price;
                    row.Cells["Importe"].Value = decimal.Parse(txtQuantity.Text) * price;
                    quantityExistProduct = quantityExistProduct - quantity;
                    elementInvoice.Id1 = "2";
                    elementInvoice.Quantity1 = quantityExistProduct;

                    elements.Add(elementInvoice);
                }
                else
                {
                    MessageBox.Show("Excede la cantidad, actualmente existe: " + quantityExistProduct);
                }
            }
            else
            {
                MessageBox.Show("Datos vacios");
            }
        }

        public bool validateData()
        {
            return !string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtDescription.Text)
                    && !string.IsNullOrEmpty(txtNameClient.Text) && !string.IsNullOrEmpty(txtNITClient.Text)
                    && !string.IsNullOrEmpty(txtType.Text) && !string.IsNullOrEmpty(txtConsultPrice.Text)
                    && cboMedicaments.SelectedIndex > -1;
        }

        private void btnPurcharseBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMedicaments_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            String qprocedure;
            qprocedure = "viewInventoryByClinic @clinicId='" + SG.user.ClincId + "'";


            if (dataBase.ExecuteQuery(qprocedure))
            {

                while (dataBase.table.Read())
                {
                    string x = dataBase.table.GetString(4);
                    if (x.Equals(cboMedicaments.Text))
                    {
                        price = dataBase.table.GetDecimal(6);
                        quantityExistProduct = dataBase.table.GetInt32(5);
                        idElement = dataBase.table.GetString(0);
                    }
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
