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

        public List<Position> fetchAllPosition()
        {
            List<Position> position = new List<Position>();

            sqlCon.Open();
            sqlCmd.CommandText = "SELECT [Position].id, [Position].name, [Position].salary FROM [Position]";
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Position pos = new Position();

                    pos.id = Int32.Parse(sqlDataReader["id"].ToString());
                    pos.name = sqlDataReader["name"].ToString();
                    pos.salary = Convert.ToDecimal(sqlDataReader["salary"].ToString());
                    position.Add(pos);
                }
            }
            sqlCon.Close();

            return position;
        }

        public Position fetchPositionByName(string selectedPosition)
        {
            Position position = new Position();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT id, name, salary FROM Position WHERE (name = @name);";
            sqlCmd.Parameters.AddWithValue("@name", selectedPosition);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    position.id = Int32.Parse(sqlDataReader["id"].ToString());
                    position.name = sqlDataReader["name"].ToString();
                    position.salary = Convert.ToDecimal(sqlDataReader["salary"].ToString());
                    //misc.type = MiscType.Parse(sqlDataReader["type"].ToString()); 
                    //misc.amount = Decimal.Parse(sqlDataReader["amount"].ToString());
                }
            }
            else
            {
                Console.WriteLine("nothing");
            }
            sqlCon.Close();
            return position;
        }

        public Position updatePosition(Position position)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "UPDATE [Position] SET salary = @salary WHERE (id = @id)";
            sqlCmd.Parameters.AddWithValue("@salary", position.salary);
            sqlCmd.Parameters.AddWithValue("@id", position.id);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            return position;
        }

        public Position fetchPositionById(int positionId)
        {
            Position position = new Position();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT id, name, salary FROM Position WHERE (id = @id);";
            sqlCmd.Parameters.AddWithValue("@id", positionId);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    position.id = Int32.Parse(sqlDataReader["id"].ToString());
                    position.name = sqlDataReader["name"].ToString();
                    position.salary = Convert.ToDecimal(sqlDataReader["salary"].ToString());
                }
            }
            else
            {
                Console.WriteLine("nothing");
            }
            sqlCon.Close();
            return position;
        }
    }
}
