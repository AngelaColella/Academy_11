using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BankEntities
{
    public class FileSystemDataManager : IDataManager
    {
        private string bankDir = @"C:\Users\angela.colella\Documents\Angela\Academy\Bank_Files";
        private string usersFileName;
        private string clientiFileName;
        private string ccFileName;
        private string movimentiFileName;

        public FileSystemDataManager()
        {
            usersFileName = Path.Combine(bankDir, "Users.txt");
            clientiFileName = Path.Combine(bankDir, "Clienti.txt");
            ccFileName = Path.Combine(bankDir, "ContiCorrenti.txt");
            movimentiFileName = Path.Combine(bankDir, "Movimenti.txt");
        }

        public bool CreateNewCliente(Cliente newCliente)
        {
            bool result;

            try
            {
                using (System.IO.StreamWriter sw_clienti = File.AppendText(clientiFileName))
                {

                    string s_new_cliente = newCliente.Username + ";" +
                                         newCliente.FirstName + ";" +
                                         newCliente.LastName + ";" +
                                         newCliente.CF;
                    sw_clienti.WriteLine(s_new_cliente); // scrive una riga sul file Clienti con tutte le info
                    sw_clienti.Close();
                }

                using (System.IO.StreamWriter sw_cc = File.AppendText(ccFileName))
                {
                    ContoCorrente new_cc = newCliente.MioConto;
                    string s_new_cc = new_cc.GetNumeroConto() + ";" + new_cc.GetSaldo() + ";" + newCliente.Username;
                    sw_cc.WriteLine(s_new_cc); // scrive una riga sul file ContiCorrenti con tutte le info
                    sw_cc.Close();
                }

                result = true;
            }
            catch (Exception excp)
            {
                result = false;
            }
            return result;
        }

        public ContoCorrente GetContocorrenteByUsername(string username)
        {
            ContoCorrente cc_result = null;

            using (System.IO.StreamReader file = new System.IO.StreamReader(ccFileName))
            {
                string line;
                char[] chararray = new char[1]; 
                chararray[0] = ';';
                while (!String.IsNullOrEmpty(line = file.ReadLine())) 
                {
                    String[] s = line.Split(chararray);
                    string registered_user = s[2]; // 2 perchè nel file ContiCorrenti lo user è il terzo campo
                    if (username == registered_user)
                    {
                        cc_result = new ContoCorrente(s[0]);
                        break;
                    }
                }
                file.Close();
            }

            return cc_result;
        }

        public bool LoginIsOK(string username, string password)
        {
            // si verifica che login e password siano inseriti nel file Users e si verifica che user e pw coincidano
            bool result = false;
            string line;
            char[] chararray = new char[1]; // se scrivessi char[] chararray; starei dichiarando un puntatore vuoto
            chararray[0] = ';'; // il ; nel file Users separa lo user dalla password

            System.IO.StreamReader file = new System.IO.StreamReader(usersFileName);
            while ((line = file.ReadLine()) != null) 
            {
                String[] s = line.Split(chararray);
                string registered_user = s[0];
                string registered_pw = s[1];
                if (username == registered_user && password == registered_pw)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public bool UserIsAnOwner(string username) // si controlla il file ContiCorrenti
        {
            bool result = false;
            string line;
            char[] chararray = new char[1];
            chararray[0] = ';';
            using (System.IO.StreamReader file = new System.IO.StreamReader(ccFileName))
            {
                while (!String.IsNullOrEmpty(line = file.ReadLine())) //se il file è vuoto, non è detto che la stringa risulti null, ma magari empty
                {
                    String[] s = line.Split(chararray);
                    string registered_user = s[2]; // 2 perchè nel file ContiCorrenti lo user è il terzo campo
                    if (username == registered_user)
                    {
                        result = true;
                        break;
                    }
                }
                file.Close();
            }
            return result;
        }
    }
}
