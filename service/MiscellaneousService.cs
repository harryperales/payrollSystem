using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using System.Data.SqlClient;

namespace PayrollSystem.service
{
    public class MiscellaneousService : MiscellaneousServiceInterface
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\JenuNagil\Documents\GitHub\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlDataReader;

        public MiscellaneousService()
        {
            sqlCmd.Connection = sqlCon;
        }

        public List<Miscellaneous> fetchMiscellaneousByDeductionType(Employee employee)
        {
            List<Miscellaneous> miscs = new List<Miscellaneous>();
            Miscellaneous misc = new Miscellaneous();

            misc.name = "SSS";
            misc.type = MiscType.Deductions;
            misc.amount = Convert.ToDecimal("100.00");

            miscs.Add(misc);


            Miscellaneous miscPagibig = new Miscellaneous();

            miscPagibig.name = "PagIbig";
            miscPagibig.type = MiscType.Deductions;
            miscPagibig.amount = Convert.ToDecimal("100.00");

            miscs.Add(miscPagibig);

            Miscellaneous miscPhilHealth = new Miscellaneous();

            miscPhilHealth.name = "PagIbig";
            miscPhilHealth.type = MiscType.Deductions;
            miscPhilHealth.amount = Convert.ToDecimal("130.00");

            miscs.Add(miscPhilHealth);

            return miscs;
        }

        public List<Miscellaneous> fetchMiscellaneousByBenefitType(Employee employee)
        {
            List<Miscellaneous> miscs = new List<Miscellaneous>();
            Miscellaneous foodAllowance = new Miscellaneous();
            Miscellaneous transportationAllowance = new Miscellaneous();
            foodAllowance = fetchMiscellaneousByName("FoodAllowance");
            transportationAllowance = fetchMiscellaneousByName("TransportationAllowance");
            
            miscs.Add(foodAllowance);
            miscs.Add(transportationAllowance);

            return miscs;
        }

        private Miscellaneous fetchMiscellaneousByName(string miscellaneousName)
        {
            Miscellaneous miscellaneous = new Miscellaneous();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT id, name, description, amount, type From Miscellaneous WHERE name = @name";
            sqlCmd.Parameters.AddWithValue("@name", miscellaneousName);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    miscellaneous = new Miscellaneous();
                    miscellaneous.id = Int32.Parse(sqlDataReader["id"].ToString());
                    miscellaneous.name = sqlDataReader["name"].ToString();
                    miscellaneous.description = sqlDataReader["description"].ToString();
                    miscellaneous.amount = Convert.ToDecimal(sqlDataReader["amount"].ToString());
                    miscellaneous.type = MiscType.Benefits;
                }
            }

            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return miscellaneous;
        }

        public List<Miscellaneous> fetchBonusMiscellaneousByDescriptionAsDate(Employee employee, DateTime startDatePeriod, DateTime endDatePeriod)
        {
            List<Miscellaneous> bonuses = new List<Miscellaneous>();
            var dates = Enumerable.Range(0, (endDatePeriod - startDatePeriod).Days + 1).Select(d => startDatePeriod.AddDays(d));

            foreach (var date in dates)
            {
                Miscellaneous bonus = fetchBonusMiscellaneousByDate(employee, date);
                if (bonus != null && !bonus.Equals(""))
                {
                    bonuses.Add(bonus);
                }
            }

            return bonuses;
        }

        public Miscellaneous fetchBonusMiscellaneousByDate(Employee employee, DateTime date)
        {
            Miscellaneous bonus = null;
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT EmployeeMiscellaneous.id, Miscellaneous.id AS miscellaneousId, Miscellaneous.description, Miscellaneous.amount, Miscellaneous.type FROM EmployeeMiscellaneous INNER JOIN Miscellaneous ON EmployeeMiscellaneous.miscellaneousId = Miscellaneous.id WHERE (EmployeeMiscellaneous.employeeId = @employeeNumber) AND (description LIKE @date);";
            sqlCmd.Parameters.AddWithValue("@employeeNumber", employee.id);
            sqlCmd.Parameters.AddWithValue("@date", "%" + date.ToString("MM/dd/yyyy") + "%");
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    bonus = new Miscellaneous();
                    bonus.id = Int32.Parse(sqlDataReader["miscellaneousId"].ToString());
                    bonus.description = sqlDataReader["description"].ToString();
                    bonus.amount = Convert.ToDecimal(sqlDataReader["amount"].ToString());
                    bonus.type = MiscType.Benefits;
                }                
            }

            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return bonus;
        }

        public Miscellaneous fetchById(int miscellaneousId)
        {
            Miscellaneous misc = new Miscellaneous();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT id, name, description, amount, type From Miscellaneous WHERE id = @miscellaneousId;";
            sqlCmd.Parameters.AddWithValue("@miscellaneousId", miscellaneousId);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    misc.id = Int32.Parse(sqlDataReader["id"].ToString());
                    misc.name = sqlDataReader["name"].ToString();
                    misc.description = sqlDataReader["description"].ToString();
                    misc.amount = Convert.ToDecimal(sqlDataReader["amount"].ToString());
                    misc.type = sqlDataReader["type"].ToString().Equals("Deduction") ? MiscType.Deductions : MiscType.Benefits;
                }
            }
            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return misc;
        }
    }
}
