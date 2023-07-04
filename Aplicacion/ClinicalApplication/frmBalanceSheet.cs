using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTextSharp.tool.xml.html.HTML;

namespace ClinicalApplication
{
    public partial class frmBalanceSheet : Form
    {
        public frmBalanceSheet()
        {
            InitializeComponent();
        }

        private void frmBalanceSheet_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            String qprocedure;
            qprocedure = "viewBalanceSheetActive";

            if (dataBase.ExecuteQuery(qprocedure))
            {
                grdBalanceSheetActive.Rows.Clear();
                grdBalanceSheetActive.Rows.Add("", "Activo Circulante", "");

                while (dataBase.table.Read())
                {
                    grdBalanceSheetActive.Rows.Add("", dataBase.table.GetString(1), dataBase.table.GetDecimal(2));
                }
                grdBalanceSheetActive.Rows[4].Cells[2].Value = getSumInventary();
                grdBalanceSheetActive.Rows[0].Cells[2].ReadOnly = true;
                grdBalanceSheetActive.Rows[2].Cells[2].ReadOnly = true;
                grdBalanceSheetActive.Rows[4].Cells[2].ReadOnly = true;
                grdBalanceSheetActive.Rows[5].Cells[2].ReadOnly = true;
                grdBalanceSheetActive.Rows[9].Cells[2].ReadOnly = true;
                grdBalanceSheetActive.Rows[10].Cells[2].ReadOnly = true;
                foreach (DataGridViewColumn column in grdBalanceSheetActive.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                calculateCellsActive();
            }
            else
            {
                MessageBox.Show("Error en la base de datos");
            }
            dataBase.CloseConnection();


            qprocedure = "viewBalanceSheetPassiveCapital";
            if (dataBase.ExecuteQuery(qprocedure))
            {
                grdBalanceSheetPassiveCapital.Rows.Clear();
                grdBalanceSheetPassiveCapital.Rows.Add("", "Pasivo Circulante", "");

                while (dataBase.table.Read())
                {
                    grdBalanceSheetPassiveCapital.Rows.Add("", dataBase.table.GetString(1), dataBase.table.GetDecimal(2));
                }

                DataGridViewRow newRow = new DataGridViewRow();

                newRow.Cells.Add(new DataGridViewTextBoxCell());
                newRow.Cells.Add(new DataGridViewTextBoxCell());
                newRow.Cells.Add(new DataGridViewTextBoxCell());

                // Establecer los valores de las celdas
                newRow.Cells[0].Value = "";
                newRow.Cells[1].Value = "Capital";
                newRow.Cells[2].Value = "";

                // Insertar la nueva fila en el índice especificado
                grdBalanceSheetPassiveCapital.Rows.Insert(6, newRow);
                grdBalanceSheetPassiveCapital.Rows[8].Cells[2].Value = getNetIncome();

                grdBalanceSheetPassiveCapital.Rows[0].Cells[2].ReadOnly = true;
                grdBalanceSheetPassiveCapital.Rows[3].Cells[2].ReadOnly = true;
                grdBalanceSheetPassiveCapital.Rows[5].Cells[2].ReadOnly = true;
                grdBalanceSheetPassiveCapital.Rows[6].Cells[2].ReadOnly = true;
                grdBalanceSheetPassiveCapital.Rows[8].Cells[2].ReadOnly = true;
                grdBalanceSheetPassiveCapital.Rows[9].Cells[2].ReadOnly = true;
                grdBalanceSheetPassiveCapital.Rows[10].Cells[2].ReadOnly = true;
                foreach (DataGridViewColumn column in grdBalanceSheetPassiveCapital.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                calculateCellsPassiveCapital();
            }
            else
            {
                MessageBox.Show("Error en la base de datos");
            }
            dataBase.CloseConnection();
        }

        private void btnPurcharseBack_Click(object sender, EventArgs e)
        {
            int rowIdCounterActive = 1;
            int rowIdCounterPassiveCapital = 1;
            int counter_register = 1;

            foreach (DataGridViewRow row in grdBalanceSheetActive.Rows)
            {
                DataBase dataBase = new DataBase();
                string qprocedure;

                decimal quantity;

                if (row.Cells[2].Value != null && !string.IsNullOrEmpty(row.Cells[2].Value.ToString()))
                {
                    if (decimal.TryParse(row.Cells[2].Value.ToString(), out quantity))
                    {
                        qprocedure = "updateBalanceSheetActive @rowId=" + rowIdCounterActive;
                        qprocedure = qprocedure + ",@quantity=" + quantity;

                        if (dataBase.ExecuteQuery(qprocedure))
                        {
                            counter_register += 1;
                            rowIdCounterActive += 1;
                        }
                    }
                }

                dataBase.CloseConnection();
            }
            foreach (DataGridViewRow row in grdBalanceSheetPassiveCapital.Rows)
            {
                DataBase dataBase = new DataBase();
                string qprocedure;

                string counts = "'" + Convert.ToString(row.Cells[1].Value) + "'";
                decimal quantity;

                if (row.Cells[2].Value != null && !string.IsNullOrEmpty(row.Cells[2].Value.ToString()))
                {
                    if (decimal.TryParse(row.Cells[2].Value.ToString(), out quantity))
                    {
                        qprocedure = "updateBalanceSheetPassiveCapital @rowId=" + rowIdCounterPassiveCapital;
                        qprocedure = qprocedure + ",@quantity=" + quantity;

                        if (dataBase.ExecuteQuery(qprocedure))
                        {
                            counter_register += 1;
                            rowIdCounterPassiveCapital += 1;
                        }
                    }
                }

                dataBase.CloseConnection();
            }

            if (counter_register == 19)
            {
                MessageBox.Show("Se ha registrado correctamente");
            }

            this.Close();
        }

        private void grdBalanceSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdBalanceSheetActive_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }

            if (e.RowIndex == 2)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }

            if (e.RowIndex == 5)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }

            if (e.RowIndex == 9)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }

            if (e.RowIndex == 10)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }
        }

        private void grdBalanceSheetPassiveCapital_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }

            if (e.RowIndex == 3)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }

            if (e.RowIndex == 5)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }

            if (e.RowIndex == 6)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }

            if (e.RowIndex == 9)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }

            if (e.RowIndex == 10)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }
        }

        private void calculateCellsActive()
        {
            //Efectivo Total
            if (grdBalanceSheetActive.Rows.Count > 1 && grdBalanceSheetActive.Rows[1].Cells[2].Value != null)
            {
                grdBalanceSheetActive.Rows[2].Cells[2].Value = Convert.ToDecimal(grdBalanceSheetActive.Rows[1].Cells[2].Value);
            }
            //Activo Circulante Total
            if (grdBalanceSheetActive.Rows.Count > 1 && grdBalanceSheetActive.Rows[3].Cells[2].Value != null || grdBalanceSheetActive.Rows.Count > 1 && grdBalanceSheetActive.Rows[4].Cells[2].Value != null)
            {
                grdBalanceSheetActive.Rows[5].Cells[2].Value = Convert.ToDecimal(grdBalanceSheetActive.Rows[3].Cells[2].Value) + Convert.ToDecimal(grdBalanceSheetActive.Rows[4].Cells[2].Value);
            }
            //Activo Largo Plazo Total
            if (grdBalanceSheetActive.Rows.Count > 1 && grdBalanceSheetActive.Rows[6].Cells[2].Value != null || grdBalanceSheetActive.Rows.Count > 1 && grdBalanceSheetActive.Rows[7].Cells[2].Value != null || grdBalanceSheetActive.Rows.Count > 1 && grdBalanceSheetActive.Rows[8].Cells[2].Value != null)
            {
                grdBalanceSheetActive.Rows[9].Cells[2].Value = Convert.ToDecimal(grdBalanceSheetActive.Rows[6].Cells[2].Value) + Convert.ToDecimal(grdBalanceSheetActive.Rows[7].Cells[2].Value) + Convert.ToDecimal(grdBalanceSheetActive.Rows[8].Cells[2].Value);
            }
            //Activos Totales
            if (grdBalanceSheetActive.Rows.Count > 1 && grdBalanceSheetActive.Rows[2].Cells[2].Value != null || grdBalanceSheetActive.Rows.Count > 1 && grdBalanceSheetActive.Rows[5].Cells[2].Value != null || grdBalanceSheetActive.Rows.Count > 1 && grdBalanceSheetActive.Rows[9].Cells[2].Value != null)
            {
                grdBalanceSheetActive.Rows[10].Cells[2].Value = Convert.ToDecimal(grdBalanceSheetActive.Rows[2].Cells[2].Value) + Convert.ToDecimal(grdBalanceSheetActive.Rows[5].Cells[2].Value) + Convert.ToDecimal(grdBalanceSheetActive.Rows[9].Cells[2].Value);
            }
        }

        private void grdBalanceSheetActive_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calculateCellsActive();
        }

        private void calculateCellsPassiveCapital()
        {
            //IVA por Pagar
            if (grdBalanceSheetPassiveCapital.Rows.Count > 1 && grdBalanceSheetPassiveCapital.Rows[1].Cells[2].Value != null || grdBalanceSheetPassiveCapital.Rows.Count > 1 && grdBalanceSheetPassiveCapital.Rows[2].Cells[2].Value != null)
            {
                grdBalanceSheetPassiveCapital.Rows[2].Cells[2].Value = (decimal)(((double)getNetIncome() / 1.12) * 0.12);
            }
            //Total Pasivo Circulante
            if (grdBalanceSheetPassiveCapital.Rows.Count > 1 && grdBalanceSheetPassiveCapital.Rows[1].Cells[2].Value != null || grdBalanceSheetPassiveCapital.Rows.Count > 1 && grdBalanceSheetPassiveCapital.Rows[2].Cells[2].Value != null)
            {
                grdBalanceSheetPassiveCapital.Rows[3].Cells[2].Value = Convert.ToDecimal(grdBalanceSheetPassiveCapital.Rows[1].Cells[2].Value) + Convert.ToDecimal(grdBalanceSheetPassiveCapital.Rows[2].Cells[2].Value);
            }
            //Total Pasivos Largo Plazo
            if (grdBalanceSheetPassiveCapital.Rows.Count > 1 && grdBalanceSheetPassiveCapital.Rows[4].Cells[2].Value != null)
            {
                grdBalanceSheetPassiveCapital.Rows[5].Cells[2].Value = Convert.ToDecimal(grdBalanceSheetPassiveCapital.Rows[4].Cells[2].Value);
            }
            //Capital Total
            if (grdBalanceSheetPassiveCapital.Rows.Count > 1 && grdBalanceSheetPassiveCapital.Rows[7].Cells[2].Value != null || grdBalanceSheetPassiveCapital.Rows.Count > 1 && grdBalanceSheetPassiveCapital.Rows[8].Cells[2].Value != null)
            {
                grdBalanceSheetPassiveCapital.Rows[9].Cells[2].Value = Convert.ToDecimal(grdBalanceSheetPassiveCapital.Rows[7].Cells[2].Value) + Convert.ToDecimal(grdBalanceSheetPassiveCapital.Rows[8].Cells[2].Value);
            }
            //Total Capital y Pasivos
            if (grdBalanceSheetPassiveCapital.Rows.Count > 1 && grdBalanceSheetPassiveCapital.Rows[3].Cells[2].Value != null || grdBalanceSheetPassiveCapital.Rows.Count > 1 && grdBalanceSheetPassiveCapital.Rows[5].Cells[2].Value != null || grdBalanceSheetPassiveCapital.Rows.Count > 1 && grdBalanceSheetPassiveCapital.Rows[9].Cells[2].Value != null)
            {
                grdBalanceSheetPassiveCapital.Rows[10].Cells[2].Value = Convert.ToDecimal(grdBalanceSheetPassiveCapital.Rows[3].Cells[2].Value) + Convert.ToDecimal(grdBalanceSheetPassiveCapital.Rows[5].Cells[2].Value) + Convert.ToDecimal(grdBalanceSheetPassiveCapital.Rows[9].Cells[2].Value);
            }
        }

        private void grdBalanceSheetPassiveCapital_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calculateCellsPassiveCapital();
        }

        private decimal getNetIncome()
        {
            DataBase dataBase = new DataBase();
            String qprocedure;
            qprocedure = "GetNetIncome";
            decimal x = 0;

            if (dataBase.ExecuteQuery(qprocedure))
            {                
                while (dataBase.table.Read())
                {
                    x = dataBase.table.GetDecimal(0);                    
                }
                return x;
            }
            else
            {
                return 0;
                MessageBox.Show("Error en la base de datos");
            }
            dataBase.CloseConnection();
        }

        private decimal getSumInventary()
        {
            DataBase dataBase = new DataBase();
            String qprocedure;
            qprocedure = "viewInventoryByClinic @clinicId='" + SG.user.ClincId + "'";
            decimal counter = 0;

            if (dataBase.ExecuteQuery(qprocedure))
            {
                while (dataBase.table.Read())
                {
                    counter += dataBase.table.GetInt32(5) * dataBase.table.GetDecimal(6);
                }
                return counter;
            }
            else
            {
                return counter;
                MessageBox.Show("Error en la base de datos");
            }
            dataBase.CloseConnection();
        }
    }
}
