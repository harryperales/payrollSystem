using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public class MiscService: MiscServiceInterface
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\projects\PayrollSystem\PayrollSystem v1.0\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlDataReader;

        public MiscService ()
        {
            sqlCmd.Connection = sqlCon;
        }

        public Miscellaneous addMisc(Miscellaneous miscellaneous)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "INSERT INTO [Miscellaneous] (name, description, amount, type) VALUES (@name, @description, @amount, @type);SELECT CAST(scope_identity() AS int)";
            sqlCmd.Parameters.AddWithValue("@name", miscellaneous.name);
            sqlCmd.Parameters.AddWithValue("@description", miscellaneous.description);
            sqlCmd.Parameters.AddWithValue("@amount", miscellaneous.amount);
            sqlCmd.Parameters.AddWithValue("@type", miscellaneous.type);
            miscellaneous.id = (int)sqlCmd.ExecuteScalar();
            sqlCon.Close();
            Console.WriteLine(miscellaneous.id);

            return miscellaneous;
        }
    }
}
