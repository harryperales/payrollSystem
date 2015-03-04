using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using System.Data.SqlClient;

namespace PayrollSystem.service
{
    public class UserService : UserServiceInterface
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\JenuNagil\Documents\GitHub\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlDataReader;

        public UserService()
        {
            sqlCmd.Connection = sqlCon;
        }

        public List<User> fetchAllUsers()
        {
            //sqlCon.Open();
            //sqlCmd.CommandText = "Select * from User;";
            //sqlCmd.ExecuteNonQuery();
            //sqlCmd.Clone();
            List<User> users = new List<User>();

            sqlCon.Open();
            sqlCmd.CommandText = "SELECT [User].id, [User].username, [User].password, [User].status, [User].role, Role.id AS roleId, Role.type FROM [User] INNER JOIN Role ON [User].role = Role.id";
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    User user = new User();
                    user.role = new Role();
                    user.id = Int32.Parse(sqlDataReader["id"].ToString());
                    user.username = sqlDataReader["username"].ToString();
                    user.status = sqlDataReader["status"].ToString().Equals("Enable") ? AccountStatus.Enable : AccountStatus.Disable;
                    user.password = sqlDataReader["password"].ToString();
                    user.role.id = Int32.Parse(sqlDataReader["roleId"].ToString());
                    user.role.type = sqlDataReader["type"].ToString();
                    users.Add(user);
                }
            }
            sqlCon.Close();
            //throw new NotImplementedException();

            return users;
        }

        public bool validateUser(User user)
        {
            return false;
        }

        public User createUser(User user)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "INSERT INTO [User] (username, password, role, status) VALUES (@username, @password, @roleId, @status);SELECT CAST(scope_identity() AS int)";
            sqlCmd.Parameters.AddWithValue("@username", user.username);
            sqlCmd.Parameters.AddWithValue("@password", user.password);
            sqlCmd.Parameters.AddWithValue("@roleId", user.role.id);
            sqlCmd.Parameters.AddWithValue("@status", "Enable");
            user.id = (int)sqlCmd.ExecuteScalar();
            sqlCon.Close();

            return user;
        }

        public User fetchUser(User user)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT [User].id, [User].username, [User].password, [User].status, [User].role, Role.id AS roleId, Role.type FROM [User] INNER JOIN Role ON [User].role = Role.id WHERE [User].username=@username AND [User].password=@password";
            sqlCmd.Parameters.AddWithValue("@username", user.username);
            sqlCmd.Parameters.AddWithValue("@password", user.password);
            sqlDataReader = sqlCmd.ExecuteReader();
            User existingUser = new User();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    existingUser.role = new Role();
                    existingUser.id = Int32.Parse(sqlDataReader["id"].ToString());
                    existingUser.username = sqlDataReader["username"].ToString();
                    existingUser.password = sqlDataReader["password"].ToString();
                    existingUser.status = sqlDataReader["status"].ToString().Equals("Enable") ? AccountStatus.Enable : AccountStatus.Disable;
                    existingUser.role.id = Int32.Parse(sqlDataReader["roleId"].ToString());
                    existingUser.role.type = sqlDataReader["type"].ToString();
                }
            }
            else
            {
                existingUser = null;
            }
            sqlCon.Close();

            return existingUser;
        }

        public User updateUser(User user)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "UPDATE [User] set password='"+user.password+"' where id='"+user.id+"'";
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            return user;
        }

        public User updateUserAccountStatus(User user)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "UPDATE [User] SET status = @status WHERE (id = @id)";
            sqlCmd.Parameters.AddWithValue("@status", user.status == AccountStatus.Enable ? "Enable" : "Disable");
            sqlCmd.Parameters.AddWithValue("@id", user.id);

            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            return user;
        }

        public User fetchUserByUsername(User user)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT [User].id, [User].username, [User].password, [User].status, [User].role, Role.id AS roleId, Role.type FROM [User] INNER JOIN Role ON [User].role = Role.id WHERE [User].username='" + user.username + "'";
            sqlDataReader = sqlCmd.ExecuteReader();
            User existingUser = new User();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    existingUser.role = new Role();
                    existingUser.id = Int32.Parse(sqlDataReader["id"].ToString());
                    existingUser.username = sqlDataReader["username"].ToString();
                    existingUser.password = sqlDataReader["password"].ToString();
                    existingUser.status = sqlDataReader["status"].ToString().Equals("Enable") ? AccountStatus.Enable : AccountStatus.Disable;
                    existingUser.role.id = Int32.Parse(sqlDataReader["roleId"].ToString());
                    existingUser.role.type = sqlDataReader["type"].ToString();
                }
            }
            else
            {
                existingUser = null;
            }
            sqlCon.Close();

            return existingUser;
        }
    }
}
