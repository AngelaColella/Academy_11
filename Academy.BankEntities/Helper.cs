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
            if (numChars <= 36)
            {
                Guid newGuid = Guid.NewGuid();
                string s_newGuid = newGuid.ToString();
                cc = s_newGuid.Substring(0, numChars);

            }
            return cc;
        }
    }
}
