using DataAccess.Entity;
using DataAccess.Shared;
using System.Data;
using System.Data.SqlClient;

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
            var dataTable = new DataTable();
            string sql = "SELECT * FROM STUDENTS;";

            var builder = DBConnector.GetBuilder();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            // return dataTable;



            return new UserEntity()
            {
                Name = name,
                Pass = "batman",
                Address = "Ova",
                Age = 28
            };
        }

        public DataTable FindByName(string name)
        {
            var dataTable = new DataTable();
            string sql = "SELECT * FROM CUSTOMERS WHERE NAME = @name;";
            using (SqlConnection connection = new SqlConnection(DBConnector.GetBuilder().ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }
    }
}
