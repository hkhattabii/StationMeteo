using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace stationMeteo
{
    public class Database
    {
        OleDbConnection connection;
        OleDbTransaction transaction;

        public Database()
        {
            connect();
        }

        public void connect()
        {
            connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=C:\\Users\\hcodi\\Desktop\\COURS\\Q4\\C#\\DB_UserAccess.accdb";
        }

        public String getPermission()
        {
            connection.Open();
            //transaction = connection.BeginTransaction();

            String request = "SELECT * FROM permission";
            OleDbCommand command = new OleDbCommand(request, connection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
            }
            reader.Close();
            connection.Close();

            return "";
        }

        public User loginUser(String username, String password)
        {
            connection.Open(); 
            Dictionary<String, Object> row = new Dictionary<String, Object>();
            
            String query = @"SELECT * FROM [user] INNER JOIN [permission] ON user.permissionID = permission.permissionID WHERE [username] = ? AND [password] = ? ";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@p1", username);
            command.Parameters.AddWithValue("@p2", password);
            OleDbDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                connection.Close();
                return null;
 
            }
            reader.Read();
            row.Add("ID", reader["userID"]);
            row.Add("username", reader["username"]);
            row.Add("password", reader["password"]);
            
            row.Add("permission", new Dictionary<String, Object> {
                {"permissionID", reader["permission.permissionID"].ToString()},
                {"name", reader["name"].ToString()},
                {"allowCreateID", reader["allowCreateID"] },
                {"allowDestroyID", reader["allowDestroyID"] },
                {"allowConfigAlarm", reader["allowConfigAlarm"] },
                {"allowUserCreation", reader["allowUserCreation"] },

            });
            
            connection.Close();

            return new User(row);

        } 

        public List<User> getUsers()
        {
            connection.Open();
            List<User> users = new List<User>();
            Dictionary<String, Object> row = new Dictionary<String, Object>();

            String query = "SELECT * FROM [user] INNER JOIN [permission] ON user.permissionID = permission.permissionID";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                row.Add("ID", reader["userID"]);
                row.Add("username", reader["username"]);
                row.Add("password", reader["password"]);
                row.Add("permission", new Dictionary<String, Object> {
                {"permissionID", reader["permission.permissionID"].ToString()},
                {"name", reader["name"].ToString()},
                {"allowCreateID", reader["allowCreateID"] },
                {"allowDestroyID", reader["allowDestroyID"]  },
                {"allowConfigAlarm", reader["allowConfigAlarm"] },
                {"allowUserCreation", reader["allowUserCreation"] },
                });
                users.Add(new User(row));
                row.Clear();
            }

            connection.Close();




            return users;
        }

        public User createUser(String username, String password, int role)
        {

            connection.Open();
            String query = @"INSERT INTO [user]([username], [password], [permissionID]) VALUES(?,?,?)";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@p1", username);
            command.Parameters.AddWithValue("@p2", password);
            command.Parameters.AddWithValue("@p3", role);
            command.ExecuteNonQuery();
            connection.Close();

            return null;
        }

        
    }


}
