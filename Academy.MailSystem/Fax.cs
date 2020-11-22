using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.MailSystem
{
    public class Fax
    {
        private MailManager _mm; //l'underscore c'è perchè è private
        public Fax(MailManager mm) // nel costruttore avviene la sottoscrizione
        {
            this._mm = mm;
            MailManagerEventHandler del = new MailManagerEventHandler(mm_MailArrived);
            this._mm.MailArrived += del; // invoco add_MailArrived(del)
        }

        public void mm_MailArrived(object sender, MailEventArgs args)
        {
            Console.WriteLine("I'm a fax \r\n Mail From: {0} \t\t, Mail to: {1}", args.From, args.To);
        }
    }
}
