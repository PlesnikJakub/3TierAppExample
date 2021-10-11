using DataAccess.TableDataGateway;

namespace BussinesLayer.TransactionScript
{
    public class Login
    {
        public bool Execute(string name, string pass)
        {
            var tdg = new UserTableDataGataway();
            var user = tdg.GetUserByName(name);

            if (user.Pass == pass)
            {
                return true;
            }

            return false;
        }
    }
}
