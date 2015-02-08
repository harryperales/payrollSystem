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
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\JenuNagil\Documents\Visual Studio 2008\Projects\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
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
            sqlCmd.CommandText = "SELECT [User].id, [User].username, [User].password, [User].role, Role.id AS roleId, Role.type FROM [User] INNER JOIN Role ON [User].role = Role.id";
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    User user = new User();
                    user.role = new Role();
                    Console.WriteLine(sqlDataReader["id"].ToString());
                    Console.WriteLine(sqlDataReader["username"].ToString());
                    Console.WriteLine(sqlDataReader["password"].ToString());
                    Console.WriteLine(sqlDataReader["role"].ToString());
                    user.id = Int32.Parse(sqlDataReader["id"].ToString());
                    user.username = sqlDataReader["username"].ToString();
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
            return true;
        }

        public User createUser(User user)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "INSERT INTO [User] (username, password, role) VALUES (@username, @password, @roleId);SELECT CAST(scope_identity() AS int)";
            sqlCmd.Parameters.AddWithValue("@username", user.username);
            sqlCmd.Parameters.AddWithValue("@password", user.password);
            sqlCmd.Parameters.AddWithValue("@roleId", user.role.id);
            user.id = (int)sqlCmd.ExecuteScalar();
            sqlCon.Close();
            Console.WriteLine(user.id);

            return user;
        }

        public User fetchUser(User user)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT [User].id, [User].username, [User].password, [User].role, Role.id AS roleId, Role.type FROM [User] INNER JOIN Role ON [User].role = Role.id WHERE [User].username='"+user.username+"' AND [User].password='"+user.password+"'";
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
                    existingUser.role.id = Int32.Parse(sqlDataReader["roleId"].ToString());
                    existingUser.role.type = sqlDataReader["type"].ToString();
                }
                Console.WriteLine("hello");
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
            Console.WriteLine(user.password);
            Console.WriteLine(user.id);
            sqlCon.Open();
            sqlCmd.CommandText = "UPDATE [User] set password='"+user.password+"' where id='"+user.id+"'";
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            return user;
        }

        public User fetchUserByUsername(User user)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT [User].id, [User].username, [User].password, [User].role, Role.id AS roleId, Role.type FROM [User] INNER JOIN Role ON [User].role = Role.id WHERE [User].username='" + user.username + "'";
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
