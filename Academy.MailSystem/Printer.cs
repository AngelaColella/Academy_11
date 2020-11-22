using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.MailSystem
{
    public class Printer
    {
        private MailManager _mm; //l'underscore c'è perchè è private
        public Printer(MailManager mm)
        {
            this._mm = mm;
            this._mm.MailArrived += _mm_MailArrived;
            // si ottiene con this.evento += tab tab
            // per semplicità si può anche scrivere così quello che ho scritto in fax e si 
            // sottintendono tutti i passaggi 

        }

        private void _mm_MailArrived(object sender, MailEventArgs args)
        {
            Console.WriteLine("I'm a fax \r\n Mail From: {0} \t\t, Mail to: {1}", args.From, args.To);
        }
    }
}
