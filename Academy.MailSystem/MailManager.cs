using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.MailSystem
{
    public class MailManager
    {
        public event MailManagerEventHandler MailArrived;

        public void SimulateMailArrived(string from, string to, string subject, string body)
        {
            MailEventArgs args = new MailEventArgs()
            {
                Body = body,
                From = from,
                Subject = subject,
                To = to
            };

            if (MailArrived != null) // se qualcuno si è sottoscritto
            {
                foreach (var item in MailArrived.GetInvocationList().ToList())
                {
                    MailManagerEventHandler mm_eh = (MailManagerEventHandler)item;
                    // downcast di ciascun delegate dentro la lista da delegate generico a delegate del nostro tipo
                    // per vedere cosa vuole in input item. 
                    // Perchè GetInvocationList restituisce di default un array di delegate generici
                    mm_eh(this, args);
                    // this perchè è MailManager, cioè colui che solleva l'evento
                }
            }

            // oppure:
            if (MailArrived != null)
            {
                MailArrived(this, args);
            }

            // oppure:
            MailArrived?.Invoke(this, args);
        }
    }
}
