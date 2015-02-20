using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public class EmployeeService : EmployeeServiceInterface
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\JenuNagil\Documents\GitHub\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlDataReader;

        public EmployeeService()
        {
            sqlCmd.Connection = sqlCon;
        }

        public Employee saveEmployee(Employee employee)
        {
            UserServiceInterface userService = new UserService();
            User user = userService.createUser(employee.userAccount);
            if (user.id > 0)
            {
                Console.WriteLine(user.id);
                sqlCon.Open();
                sqlCmd.CommandText = "INSERT into [Employee] (employeeId, userAccountId, fullName, "
                + "birthDate, gender, civilStatus, dependents, address, contactNumber, tin, "
                + "sssId, philHealthId, pagIbigId, dateEmployed, jobPositionId) "
                + "values(@employeeId, @userAccountId, @fullName, "
                + "@birthDate, @gender, @civilStatus, @dependents, "
                + "@address, @contactNumber, @tin, @sssId, @philHealthId, @pagIbigId, "
                + "@dateEmployed, @jobPositionId);SELECT CAST(scope_identity() AS int)";
                sqlCmd.Parameters.AddWithValue("@employeeId", employee.employeeId);
                sqlCmd.Parameters.AddWithValue("@userAccountId", user.id);
                sqlCmd.Parameters.AddWithValue("@fullName", employee.fullName);
                sqlCmd.Parameters.AddWithValue("@birthDate", employee.birthDate);
                sqlCmd.Parameters.AddWithValue("@gender", employee.gender);
                sqlCmd.Parameters.AddWithValue("@civilStatus", employee.civilStatus);
                sqlCmd.Parameters.AddWithValue("@dependents", employee.dependents);
                sqlCmd.Parameters.AddWithValue("@address", employee.address);
                sqlCmd.Parameters.AddWithValue("@contactNumber", employee.contactNumber);
                sqlCmd.Parameters.AddWithValue("@tin", employee.tin);
                sqlCmd.Parameters.AddWithValue("@sssId", employee.sssId);
                sqlCmd.Parameters.AddWithValue("@philHealthId", employee.philHealthId);
                sqlCmd.Parameters.AddWithValue("@pagIbigId", employee.pagIbigId);
                sqlCmd.Parameters.AddWithValue("@dateEmployed", employee.dateEmployed);
                sqlCmd.Parameters.AddWithValue("@jobPositionId", employee.jobPosition.id);
                employee.id = (int)sqlCmd.ExecuteScalar();
                sqlCon.Close();
                return employee;
            }
            return null;
        }

        public Employee fetchEmployeeByUsername(string usernameOrEmployeeId)
        {
            Employee employee = new Employee();
            employee.userAccount = new User();
            employee.jobPosition = new Position();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT [Employee].id, [Employee].employeeId, [Employee].fullName, [User].username, [Employee].birthDate, [Employee].gender, "
                         + "[Employee].civilStatus, [Employee].dependents, [Employee].address, [Employee].contactNumber, [Employee].tin, [Employee].sssId, [Employee].pagIbigId, [Employee].philHealthId, "
                         + "[Employee].dateEmployed, [Employee].jobPositionId, [Position].name, [Position].salary, [Employee].userAccountId "
                         + "FROM [Employee] INNER JOIN [User] ON [Employee].userAccountId = [User].id INNER JOIN "
                         + "[Position] ON [Employee].jobPositionId = [Position].id "
                         + "WHERE ([User].username = @username);";
            sqlCmd.Parameters.AddWithValue("@username", usernameOrEmployeeId);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    employee.id = Int32.Parse(sqlDataReader["id"].ToString());
                    employee.employeeId = Int64.Parse(sqlDataReader["employeeId"].ToString());
                    employee.userAccount.username = sqlDataReader["username"].ToString();
                    employee.fullName = sqlDataReader["fullName"].ToString();
                    employee.gender = sqlDataReader["gender"].ToString();
                    employee.birthDate = sqlDataReader["birthDate"].ToString();
                    employee.civilStatus = sqlDataReader["civilStatus"].ToString();
                    employee.dependents = Int32.Parse(sqlDataReader["dependents"].ToString());
                    employee.address = sqlDataReader["address"].ToString();
                    employee.contactNumber = sqlDataReader["contactNumber"].ToString();
                    employee.tin = sqlDataReader["tin"].ToString();
                    employee.sssId = sqlDataReader["sssId"].ToString();
                    employee.philHealthId = sqlDataReader["philHealthId"].ToString();
                    employee.pagIbigId = sqlDataReader["pagIbigId"].ToString();
                    employee.dateEmployed = sqlDataReader["dateEmployed"].ToString();
                    employee.jobPosition.id = Int32.Parse(sqlDataReader["jobPositionId"].ToString());
                    employee.jobPosition.name = sqlDataReader["name"].ToString();
                    employee.jobPosition.salary = Convert.ToDecimal(sqlDataReader["salary"].ToString());
                }
            }
            else
            {
                employee = null;
                Console.WriteLine("nothing");
            }
            sqlCon.Close();
            return employee;
        }

        public Employee updateEmployee(Employee employee)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "UPDATE [Employee] SET fullName = @fullName, birthDate = @birthDate, gender = @gender, civilStatus = @civilStatus, " 
            + "address = @address, contactNumber = @contactNumber, tin = @tin, sssId = @sssId, "
            + "pagIbigId = @pagIbigId, philHealthId = @philHealthId, dateEmployed = @dateEmployed, "
            + "jobPositionId = @jobPositionId WHERE (id = @id)";
            sqlCmd.Parameters.AddWithValue("@fullName", employee.fullName);
            sqlCmd.Parameters.AddWithValue("@birthDate", employee.birthDate);
            sqlCmd.Parameters.AddWithValue("@gender", employee.gender);
            sqlCmd.Parameters.AddWithValue("@civilStatus", employee.civilStatus);
            sqlCmd.Parameters.AddWithValue("@dependents", employee.dependents);
            sqlCmd.Parameters.AddWithValue("@address", employee.address);
            sqlCmd.Parameters.AddWithValue("@contactNumber", employee.contactNumber);
            sqlCmd.Parameters.AddWithValue("@tin", employee.tin);
            sqlCmd.Parameters.AddWithValue("@sssId", employee.sssId);
            sqlCmd.Parameters.AddWithValue("@philHealthId", employee.philHealthId);
            sqlCmd.Parameters.AddWithValue("@pagIbigId", employee.pagIbigId);
            sqlCmd.Parameters.AddWithValue("@dateEmployed", employee.dateEmployed);
            sqlCmd.Parameters.AddWithValue("@jobPositionId", employee.jobPosition.id);
            sqlCmd.Parameters.AddWithValue("@id", employee.id);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            return employee;
        }

        public Employee fetchEmployeeByEmployeeIdNUmber(long employeeNumber)
        {
            Employee employee = new Employee();
            employee.userAccount = new User();
            employee.jobPosition = new Position();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT [Employee].id, [Employee].employeeId, [Employee].fullName, [User].username, [Employee].birthDate, [Employee].gender, "
                         + "[Employee].civilStatus, [Employee].dependents, [Employee].address, [Employee].contactNumber, [Employee].tin, [Employee].sssId, [Employee].pagIbigId, [Employee].philHealthId, "
                         + "[Employee].dateEmployed, [Employee].jobPositionId, [Position].name, [Position].salary, [Employee].userAccountId "
                         + "FROM [Employee] INNER JOIN [User] ON [Employee].userAccountId = [User].id INNER JOIN "
                         + "[Position] ON [Employee].jobPositionId = [Position].id "
                         + "WHERE Employee.employeeId = @employeeId;";
            sqlCmd.Parameters.AddWithValue("@employeeId", employeeNumber);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    employee.id = Int32.Parse(sqlDataReader["id"].ToString());
                    employee.employeeId = Int64.Parse(sqlDataReader["employeeId"].ToString());
                    employee.userAccount.username = sqlDataReader["username"].ToString();
                    employee.fullName = sqlDataReader["fullName"].ToString();
                    employee.gender = sqlDataReader["gender"].ToString();
                    employee.birthDate = sqlDataReader["birthDate"].ToString();
                    employee.civilStatus = sqlDataReader["civilStatus"].ToString();
                    employee.dependents = Int32.Parse(sqlDataReader["dependents"].ToString());
                    employee.address = sqlDataReader["address"].ToString();
                    employee.contactNumber = sqlDataReader["contactNumber"].ToString();
                    employee.tin = sqlDataReader["tin"].ToString();
                    employee.sssId = sqlDataReader["sssId"].ToString();
                    employee.philHealthId = sqlDataReader["philHealthId"].ToString();
                    employee.pagIbigId = sqlDataReader["pagIbigId"].ToString();
                    employee.dateEmployed = sqlDataReader["dateEmployed"].ToString();
                    employee.jobPosition.id = Int32.Parse(sqlDataReader["jobPositionId"].ToString());
                    employee.jobPosition.name = sqlDataReader["name"].ToString();
                    employee.jobPosition.salary = Convert.ToDecimal(sqlDataReader["salary"].ToString());
                }
            }
            else
            {
                employee = null;
                Console.WriteLine("nothing");
            }
            sqlCon.Close();
            return employee;
        }
    }
}
