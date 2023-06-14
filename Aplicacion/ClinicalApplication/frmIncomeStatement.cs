using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClinicalApplication
{
    public partial class frmIncomeStatement : Form
    {
        decimal impuesto = 0.25M;

        public frmIncomeStatement()
        {
            InitializeComponent();
        }

        private void grdIncomeStatement_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calculateCells();
        }

        private void frmIncomeStatement_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            String qprocedure;
            qprocedure = "viewIncomeStatement";

            if (dataBase.ExecuteQuery(qprocedure))
            {
                grdIncomeStatement.Rows.Clear();

                while (dataBase.table.Read())
                {
                    grdIncomeStatement.Rows.Add("", dataBase.table.GetString(1), dataBase.table.GetDecimal(2));
                }
                grdIncomeStatement.Rows[0].Cells[2].ReadOnly = true;
                grdIncomeStatement.Rows[2].Cells[2].ReadOnly = true;
                grdIncomeStatement.Rows[5].Cells[2].ReadOnly = true;
                grdIncomeStatement.Rows[6].Cells[2].ReadOnly = true;
                grdIncomeStatement.Rows[9].Cells[2].ReadOnly = true;
                grdIncomeStatement.Rows[11].Cells[2].ReadOnly = true;
                foreach (DataGridViewColumn column in grdIncomeStatement.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                calculateCells();
            }
            else
            {
                MessageBox.Show("Error en la base de datos");
            }
            dataBase.CloseConnection();



        }

        private void calculateCells()
        {
            //Ganancia Bruta
            if (grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[0].Cells[2].Value != null || grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[1].Cells[2].Value != null)
            {
                grdIncomeStatement.Rows[2].Cells[2].Value = Convert.ToDecimal(grdIncomeStatement.Rows[0].Cells[2].Value) + Convert.ToDecimal(grdIncomeStatement.Rows[1].Cells[2].Value);
            }
            //Gastos Totales de Operación
            if (grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[3].Cells[2].Value != null || grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[4].Cells[2].Value != null)
            {
                grdIncomeStatement.Rows[5].Cells[2].Value = Convert.ToDecimal(grdIncomeStatement.Rows[3].Cells[2].Value) + Convert.ToDecimal(grdIncomeStatement.Rows[4].Cells[2].Value);
            }
            //Ingresos de Operación
            if (grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[2].Cells[2].Value != null || grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[5].Cells[2].Value != null)
            {
                grdIncomeStatement.Rows[6].Cells[2].Value = Convert.ToDecimal(grdIncomeStatement.Rows[2].Cells[2].Value) - Convert.ToDecimal(grdIncomeStatement.Rows[5].Cells[2].Value);
            }
            //Ingresos Antes de Impuestos
            if (grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[6].Cells[2].Value != null || grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[7].Cells[2].Value != null || grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[8].Cells[2].Value != null)
            {
                grdIncomeStatement.Rows[9].Cells[2].Value = (Convert.ToDecimal(grdIncomeStatement.Rows[6].Cells[2].Value) + Convert.ToDecimal(grdIncomeStatement.Rows[8].Cells[2].Value)) - Convert.ToDecimal(grdIncomeStatement.Rows[7].Cells[2].Value);
            }

            if (grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[9].Cells[2].Value != null)
            {
                grdIncomeStatement.Rows[10].Cells[2].Value = Convert.ToDecimal(grdIncomeStatement.Rows[9].Cells[2].Value) * impuesto;
            }

            if (grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[9].Cells[2].Value != null || grdIncomeStatement.Rows.Count > 1 && grdIncomeStatement.Rows[10].Cells[2].Value != null)
            {
                grdIncomeStatement.Rows[11].Cells[2].Value = Convert.ToDecimal(grdIncomeStatement.Rows[9].Cells[2].Value) - Convert.ToDecimal(grdIncomeStatement.Rows[10].Cells[2].Value);
            }
        }

        private void btnPurcharseBack_Click(object sender, EventArgs e)
        {
            int rowIdCounter = 1;
            int counter_register = 1;

            foreach (DataGridViewRow row in grdIncomeStatement.Rows)
            {
                DataBase dataBase = new DataBase();
                string qprocedure;

                string counts = "'" + Convert.ToString(row.Cells[1].Value) + "'";
                decimal quantity = Convert.ToDecimal(row.Cells[2].Value);

                qprocedure = "UpdateIncomeStatement @rowId=" + rowIdCounter;
                qprocedure = qprocedure + ",@counts=" + counts;
                qprocedure = qprocedure + ",@quantity=" + quantity;

                if (dataBase.ExecuteQuery(qprocedure))
                {
                    counter_register += 1;
                }

                dataBase.CloseConnection();
                rowIdCounter += 1;
            }

            if (counter_register >= 12)
            {
                MessageBox.Show("Los datos de la tabla han sido almacenados");
            }
            else
            {
                MessageBox.Show("Error en la base de datos");
            }

            this.Close();
        }

        private void grdIncomeStatement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

            if (e.RowIndex == 11)
            {
                DataGridViewCellStyle cellStyle = e.CellStyle;
                Font boldFont = new Font(cellStyle.Font, FontStyle.Bold);
                cellStyle.Font = boldFont;
                e.CellStyle = cellStyle;
            }
        }
    }


}
