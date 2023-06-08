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

namespace ClinicalApplication
{
    public partial class frmPayroll : Form
    {
        public const decimal IGSS_VALUE = 0.0483M;
        public const decimal ISR_VALUE = 0.10M;
        public const decimal VALIDATE_ISR = 4000.01m;

        public frmPayroll()
        {
            InitializeComponent();
        }

        private void btnPurcharseBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPayroll_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            String qprocedure;
            qprocedure = "viewUsersById @id='" + SG.user.ClincId + "'";

            if (dataBase.ExecuteQuery(qprocedure))
            {
                grdPayroll.Rows.Clear();
                closeChanges();

                while (dataBase.table.Read())
                {
                    grdPayroll.Rows.Add(dataBase.table.GetString(0), dataBase.table.GetString(4), dataBase.table.GetInt32(6), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                }
                openChanges();
            }
            else
            {
                MessageBox.Show("Error en la base de datos");
            }
            dataBase.CloseConnection();
            calculateCells();
        }

        private void grdPayroll_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            calculateCells();
        }

        private void calculateCells()
        {
            int columnIndex = 3;

            foreach (DataGridViewRow row in grdPayroll.Rows)
            {
                // Verificar si la celda en la columna deseada tiene un valor
                DataGridViewCell cell = row.Cells[columnIndex];
                if (cell.Value != null && cell.Value != DBNull.Value)
                {
                    // Obtener los valores de las celdas a sumar
                    decimal overtime = Convert.ToDecimal(row.Cells[2].Value);
                    decimal SalaryBase = Convert.ToDecimal(row.Cells[3].Value);

                    // Realizar la suma
                    decimal suma = (SalaryBase / 160) * overtime;

                    // Asignar el resultado a la celda deseada
                    closeChanges();
                    row.Cells[4].Value = suma;
                    openChanges();
                }

                closeChanges();
                row.Cells[7].Value = Convert.ToDecimal(row.Cells[2].Value) + Convert.ToDecimal(row.Cells[4].Value) + Convert.ToDecimal(row.Cells[5].Value) + Convert.ToDecimal(row.Cells[6].Value);
                row.Cells[8].Value = (Convert.ToDecimal(row.Cells[7].Value) - Convert.ToDecimal(row.Cells[6].Value)) * IGSS_VALUE;
                openChanges();

                if (row.Cells[2].Value != null)
                {
                    decimal valorCelda = Convert.ToDecimal(row.Cells[2].Value);
                    if (valorCelda > VALIDATE_ISR)
                    {
                        closeChanges();
                        row.Cells[9].Value = (decimal)valorCelda * ISR_VALUE;
                        openChanges();
                    }
                }

                closeChanges();
                row.Cells[13].Value = Convert.ToDecimal(row.Cells[8].Value) + Convert.ToDecimal(row.Cells[9].Value) + Convert.ToDecimal(row.Cells[10].Value) + Convert.ToDecimal(row.Cells[11].Value) + Convert.ToDecimal(row.Cells[12].Value);
                row.Cells[14].Value = Convert.ToDecimal(row.Cells[7].Value) - Convert.ToDecimal(row.Cells[13].Value);
                openChanges();
            }

            decimal totalAccrued = 0;
            decimal totalDiscounts = 0;
            decimal totalLiquid = 0;
            decimal cellValue = 0;

            foreach (DataGridViewRow row in grdPayroll.Rows)
            {
                cellValue = Convert.ToDecimal(row.Cells[7].Value);
                totalAccrued += cellValue;
                cellValue = Convert.ToDecimal(row.Cells[13].Value);
                totalDiscounts += cellValue;
                cellValue = Convert.ToDecimal(row.Cells[14].Value);
                totalLiquid += cellValue;
            }

            lblTotalAccrued.Text = "Total Devengado: Q" + totalAccrued.ToString();
            lblTotalDiscounts.Text = "Total Descuentos: Q" + totalDiscounts.ToString();
            lblTotalLiquid.Text = "Total Liquido: Q" + totalLiquid.ToString();
        }

        private void closeChanges()
        {
            grdPayroll.CellValueChanged -= grdPayroll_CellValueChanged_1;
        }

        private void openChanges()
        {
            grdPayroll.CellValueChanged += grdPayroll_CellValueChanged_1;
        }
    }
}
