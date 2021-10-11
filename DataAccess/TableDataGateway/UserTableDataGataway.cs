using DataAccess.Entity;

namespace DataAccess.TableDataGateway
{
    public class UserTableDataGataway
    {
        public string GetUsersPassword(string name)
        {
            // TODO SOME SQL
            return "Batman";
        }

        public UserEntity GetUserByName(string name)
        {
            // SQL VOODOOO       
            return new UserEntity()
            {
                Name = name,
                Pass = "batman",
                Address = "Ova",
                Age = 28
            };
        }
    }
}
