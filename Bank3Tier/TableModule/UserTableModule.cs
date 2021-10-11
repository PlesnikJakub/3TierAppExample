using DataAccess.TableDataGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.TableModule
{
    public class UserTableModule
    {
        public bool Login(string name, string pass)
        {
            var tdg = new UserTableDataGataway();
            var user = tdg.GetUserByName(name);

            if(user.Pass == pass)
            {
                return true;
            }

            return false;
        }

        public bool Logout()
        {
            return true;
        }

        // ADD MORE 
        // CREATE 
        // GET 
        // VERIFY
    }
}
