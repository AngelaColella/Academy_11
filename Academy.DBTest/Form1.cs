using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.DBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clienti_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=WINAPIUZIYVIF6L\SQLEXPRESS;Initial Catalog=AcademyDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            // creazione dell'oggetto connesione. é nello using perchè alla fine ne farò la dispose
            {
                String sqlcmdText = "SELECT [ID],[FirstName],[LastName],[FiscalCode] FROM [AcademyDB].[dbo].[Clients]";
                // questa stringa si copia dalla query MSSQL

                SqlCommand cmd = new SqlCommand(sqlcmdText, conn);
                // oggetto che associa la connessione alla query 

                conn.Open();
                // apro la connessione sempre prima di eseguire il comando 

                SqlDataReader dr = cmd.ExecuteReader();
                // dr "si posiziona" all'inizio della tabella

                while (dr.Read())
                // Read restituisce un bool e posiziona in un array i campi della tabella
                {
                    string firstName = dr[1].ToString();
                    string lastName = dr[2].ToString();

                    string item = firstName + " " + lastName;
                    this.lst_Clienti.Items.Add(item);
                }
                conn.Close();
            }
        }
    }
}
