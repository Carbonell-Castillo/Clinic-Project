using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iTextSharp.tool.xml.html.HTML;

namespace ClinicalApplication
{
    internal class Invoice
    {
        private int id;
        private String clinicId;
        private int userId;
        private String date;
        private String nit;
        private String user;
        private String name;
        private String doc;
        private byte[] docData;

        public Invoice()
        {
        }

        public Invoice(int id, string clinicId, int userId, string date, string nit, string user, string name, string doc, byte[] docData)
        {
            this.id = id;
            this.clinicId = clinicId;
            this.userId = userId;
            this.date = date;
            this.nit = nit;
            this.user = user;
            this.name = name;
            this.doc = doc;
            this.docData = docData;
        }

        public int Id { get => id; set => id = value; }
        public string ClinicId { get => clinicId; set => clinicId = value; }
        public int UserId { get => userId; set => userId = value; }
        public string Date { get => date; set => date = value; }
        public string Nit { get => nit; set => nit = value; }
        public string User { get => user; set => user = value; }
        public string Name { get => name; set => name = value; }
        public string Doc { get => doc; set => doc = value; }
        public byte[] DocData { get => docData; set => docData = value; }

        public bool Save()
        {
            DataBase dataBase = new DataBase();

            try
            {
                dataBase.Connect();

                // Crear un nuevo comando para llamar al procedimiento almacenado
                SqlCommand command = new SqlCommand();
                command.CommandText = "addInvoice";
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros al comando
                command.Parameters.AddWithValue("@clinicId", clinicId);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                command.Parameters.AddWithValue("@nit", nit);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@docData", docData);

                command.Connection = dataBase.Connection;

                // Ejecutar el procedimiento almacenado
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
                return false;
            }
            finally
            {
                dataBase.CloseConnection();
            }
        }

    }

}

