using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.MailSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            MailManager mm = new MailManager(); // istanzio mailmanager 

            Fax fax = new Fax(mm); // istanzio le classi fax e printer
            Printer printer = new Printer(mm);

            mm.SimulateMailArrived("Topolino", "Minnie", "Cena", "Usciamo stasera?");
            mm.SimulateMailArrived("Minni", "Topolino", "Cena", "Esco con Pippo");
        }
    }
}
