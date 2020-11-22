using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BankEntities
{
    public class Helper
    {
        public static string GetNumConto(int numChars) //
        {
            string cc = ""; 
            if (numChars <= 36) // la Giud ha 36 caratteri, quindi se il numero di conto avesse più di 36 caratteri, non si potrebbe usare solo una Guid
            {
                Guid newGuid = Guid.NewGuid(); // Guid = Globally Unique IDentifier (ha 128 bit = 16 byte)
                string s_newGuid = newGuid.ToString();
                cc = s_newGuid.Substring(0, numChars);
            }
            return cc;
        }
    }
}
