using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public class PositionService : PositionServiceInterface
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\JenuNagil\Documents\GitHub\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlDataReader;

        public PositionService()
        {
            sqlCmd.Connection = sqlCon;
        }

        public Position addPosition(Position position)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "INSERT INTO [Position] (name, salary) VALUES (@name, @salary);SELECT CAST(scope_identity() AS int)";
            sqlCmd.Parameters.AddWithValue("@name", position.name);
            sqlCmd.Parameters.AddWithValue("@salary", position.salary);
            position.id = (int)sqlCmd.ExecuteScalar();
            sqlCon.Close();
            Console.WriteLine(position.id);

            return position;
        }
    }
}
