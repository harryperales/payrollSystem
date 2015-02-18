using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public class MiscService : MiscServiceInterface
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\projects\PayrollSystem\PayrollSystem v1.0\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlDataReader;

        public MiscService()
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


        public List<Miscellaneous> fetchAllMisc()
        {
            List<Miscellaneous> misc = new List<Miscellaneous>();

            sqlCon.Open();
            sqlCmd.CommandText = "SELECT [Miscellaneous].id, [Miscellaneous].name, [Miscellaneous].amount, [Miscellaneous].type, [Miscellaneous].description FROM [Miscellaneous]";
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Miscellaneous miscellaneous = new Miscellaneous();

                    miscellaneous.id = Int32.Parse(sqlDataReader["id"].ToString());
                    miscellaneous.name = sqlDataReader["name"].ToString();
                    miscellaneous.amount = Decimal.Parse(sqlDataReader["amount"].ToString());
                    // miscellaneous.type = MiscType.Parse(sqlDataReader["type"].ToString());
                    miscellaneous.description = sqlDataReader["description"].ToString();
                    misc.Add(miscellaneous);
                }
            }
            sqlCon.Close();

            return misc;
        }

        public Miscellaneous fetchMiscByName(string selectedMisc)
        {
            Miscellaneous misc = new Miscellaneous();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT id, name, amount, type, description FROM Miscellaneous "
                         + "WHERE (name = @name);";
            sqlCmd.Parameters.AddWithValue("@name", selectedMisc);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    misc.id = Int32.Parse(sqlDataReader["id"].ToString());
                    misc.name = sqlDataReader["name"].ToString();
                    misc.description = sqlDataReader["description"].ToString();
                    //misc.type = MiscType.Parse(sqlDataReader["type"].ToString()); 
                    misc.amount = Decimal.Parse(sqlDataReader["amount"].ToString());
                }
            }
            else
            {
                Console.WriteLine("nothing");
            }
            sqlCon.Close();
            return misc;
        }

        public Miscellaneous updateMiscellaneous(Miscellaneous miscellaneous)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "UPDATE [Miscellaneous] SET name = @name, description = @description, amount = @amount, type = @type  WHERE (id = @id)";
            sqlCmd.Parameters.AddWithValue("@name", miscellaneous.name);
            sqlCmd.Parameters.AddWithValue("@description", miscellaneous.description);
            sqlCmd.Parameters.AddWithValue("@amount", miscellaneous.amount);
            sqlCmd.Parameters.AddWithValue("@type", miscellaneous.type);
            sqlCmd.Parameters.AddWithValue("@id", miscellaneous.id);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            return miscellaneous;
        }
    }
}
