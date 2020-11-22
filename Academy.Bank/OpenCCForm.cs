using Academy.BankEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Bank
{
    public partial class OpenCCForm : Form
    {
        private IDataManager datamanager;
        private string CurrentUser;
        public OpenCCForm(string username)
        {
            InitializeComponent();

            datamanager = new FileSystemDataManager();
            this.CurrentUser = username;
            this.label3.Text = CurrentUser; // voglio che nella label3 sia mostrato lo username inserito nella LoginForm
            string numConto = Helper.GetNumConto(20); // il numero di conto deve essere generato causalmente e mostrato subito nella label5
            // 20 è il numero di caratteri di cui è composto il numero di conto 
            this.label5.Text = numConto;
        }
        public OpenCCForm()
        {
            datamanager = new FileSystemDataManager();
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = (LoginForm)Tag;
            loginform.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            string username = this.label3.Text;
            string numconto = this.label5.Text;
            string nome = this.txt_Nome.Text;
            string cognome = this.txt_Cognome.Text;
            string cf = this.txt_CF.Text;

            ContoCorrente newCC = new ContoCorrente(numconto);

            Cliente newCliente = new Cliente()
            {
                Username = username,
                FirstName = nome,
                LastName = cognome,
                CF = cf,
                MioConto = newCC
            };

            bool result = datamanager.CreateNewCliente(newCliente);
            if (result)
            {
                ManageCCForm manageform = new ManageCCForm(newCC);
                manageform.Tag = this;
                manageform.Show();
                this.Hide();
            }
            else
            {
                this.label9.Text = "Error";
            }

        }

        private void btn_Annulla_Click(object sender, EventArgs e)
        {
            this.txt_Nome.Text = " ";
            this.txt_Cognome.Text = " ";
            this.txt_CF.Text = " ";
        }
    }
}
