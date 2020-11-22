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
    public partial class ManageCCForm : Form
    {
        public ContoCorrente conto_corrente = new ContoCorrente();

        public ManageCCForm(ContoCorrente cc)
        {
            InitializeComponent();
            this.conto_corrente = cc;
            this.lbl_CC.Text = conto_corrente.GetNumeroConto();
            double saldo = conto_corrente.GetSaldo();
            this.lbl_displaySaldo.Text = saldo.ToString("N"); // converto da double a string perchè nella text box ci vuole una stringa
        }

        private void btn_Preleva_Click(object sender, EventArgs e)
        {
            double new_saldo = 0;
            double importo = double.Parse(this.txt_importo.Text);
            new_saldo = conto_corrente.Preleva(importo);
            if (new_saldo >= 0)
            {
                this.lbl_displaySaldo.Text = new_saldo.ToString("N");
                this.lbl_fondiInsuff.Text = " ";
            }
            else
            {
                this.lbl_fondiInsuff.Text = "Fondi insufficienti!!";
            }
        }

        private void btn_versa_Click(object sender, EventArgs e)
        {
            double new_saldo = 0;
            double importo = double.Parse(this.txt_importo.Text);
            new_saldo = conto_corrente.Deposita(importo);
            this.lbl_displaySaldo.Text = new_saldo.ToString("N");
            this.lbl_fondiInsuff.Text = " ";
        }

        private void btn_esegui_bonifico_Click(object sender, EventArgs e)
        {
            double new_saldo = 0;
            double importo = double.Parse(this.txt_importo_bonifico.Text);
            new_saldo = conto_corrente.Bonifico(importo);
            if (new_saldo >= 0)
            {
                this.lbl_displaySaldo.Text = new_saldo.ToString("N");
                this.lbl_fondiInsuff.Text = " ";
            }
            else
            {
                this.lbl_fondiInsuff2.Text = "Fondi insufficienti!!";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = (LoginForm)Tag;
            loginform.Close();
        }
        private void lbl_CC_Click(object sender, EventArgs e)
        {

        }
    }
}
