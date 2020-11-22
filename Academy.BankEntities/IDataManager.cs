using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BankEntities
{
    public interface IDataManager
    {
        bool LoginIsOK(string username, string password);
        bool UserIsAnOwner(string username);
        bool CreateNewCliente(Cliente newCliente);
        ContoCorrente GetContocorrenteByUsername(string username);
    }
}
