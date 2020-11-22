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
            this.Close(); // chiusura della OpenCCForm
            LoginForm loginform = (LoginForm)Tag;
            // sto costruendo il riferimento a LoginForm tramite Tag
            // Tag è di tipo Object, e punta a LoginForm, quindi posso fare un downcast alla LoginForm in modo da poterne vedere le proprietà

            loginform.Close(); // è necessario fare la chiusura della LoginForm perchè altirmenti resterebbe aperta 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            // quando l'utente conferma, si salvano i dati inseriti nelle seguenti stringhe
            string username = this.label3.Text;
            string numconto = this.label5.Text;
            string nome = this.txt_Nome.Text;
            string cognome = this.txt_Cognome.Text;
            string cf = this.txt_CF.Text;

            // si crea un nuovo conto con il numconto 
            ContoCorrente newCC = new ContoCorrente(numconto);

            // si crea un nuovo cliente con i dati inseriti
            Cliente newCliente = new Cliente()
            {
                Username = username,
                FirstName = nome,
                LastName = cognome,
                CF = cf,
                MioConto = newCC
            };

            // si insrisce il nuovo cliente nel file clienti
            bool result = datamanager.CreateNewCliente(newCliente);
            if (result) //  Se l'operazione va a buon fine, si dà la possibilità di gestire il conto
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
           // il bottone annulla sostituisce i dati inseriti con spazi vuoti
            this.txt_Nome.Text = " ";
            this.txt_Cognome.Text = " ";
            this.txt_CF.Text = " ";
        }
    }
}
