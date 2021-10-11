using DataAccess.TableDataGateway;

namespace BussinesLayer.DomainModel
{
    public class UserDomainModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Pass { get; set; }
        public string Address { get; set; }

        public static bool Login(string name, string pass)
        {
            var tdg = new UserTableDataGataway();
            var user = tdg.GetUserByName(name);

            if (user.Pass == pass)
            {
                return true;
            }

            return false;
        }

        public static bool Logout()
        {
            return true;
        }
    }
}
