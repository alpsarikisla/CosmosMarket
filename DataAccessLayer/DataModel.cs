using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        public User UserLogin(string userName, string password)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM Users WHERE UserName=@username AND Password=@password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("username", userName);
                cmd.Parameters.AddWithValue("password", password);
                con.Open();
                User u = null;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    u= new User();
                    u.ID = reader.GetInt32(0);
                    u.Name = reader.GetString(1);
                    u.Surname = reader.GetString(2);
                    u.UserName = reader.GetString(3);
                    u.Password = reader.GetString(4);
                    u.Status = reader.GetBoolean(5);
                }
                return u;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
