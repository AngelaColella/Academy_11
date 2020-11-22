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
    public partial class LoginForm : Form
    {
        private IDataManager datamanager;
        public LoginForm()
        {
            datamanager = new FileSystemDataManager();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // salva in due variabili ciò che è stato inserito nelle text box
            string username = this.txt_username.Text;
            string password = this.txt_password.Text;

            if (datamanager.LoginIsOK(username, password)) // controllo che user e pw coincidano con quelli riportati sul file
            {
                if (datamanager.UserIsAnOwner(username)) // controllo che lo user sia un cliente.
                    // Se ha inserito user e pw correttamente ed è un cliente, apro la Form per la gestione del conto
                {
                    ContoCorrente cc = datamanager.GetContocorrenteByUsername(username);
                    // istanza al ContoCorrente che ha come username quello inserito
                    ManageCCForm manageform = new ManageCCForm(cc);
                    manageform.Tag = this;
                    manageform.Show();
                    this.Hide();
                }
                else // se lo user, che ha effettuate un login corretto, non è un Cliente, si apre la Form per l'apertura del conto
                {
                    OpenCCForm openform = new OpenCCForm(username);
                    openform.Tag = this;
                    // this si riferisce alla LoginForm. Per vedere a cosa riferisce this, basta andarci sopra con il mouse
                    // Tag è una proprietà della classe Form, che dice chi ha creato la Form
                    // Quindi ora dentro Tag c'è un puntatore alla LoginForm. 
                    // Questo passaggio è necessario per poter “salvare in una variabile temporanea” Tag la LoginForm, che altrimenti non saprei come recuperare dopo averla nascosta
                    openform.Show();
                    this.Hide();
                }
            }
            else
            {
                this.lbl_loginerror.Text = "Invalid Credentials!";
            }
        }
    }
}
