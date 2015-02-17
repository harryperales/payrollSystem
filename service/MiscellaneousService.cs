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
            misc.amount = Convert.ToDecimal("150.00");

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
            Miscellaneous misc = new Miscellaneous();

            misc.name = "Food";
            misc.type = MiscType.Deductions;
            misc.amount = Convert.ToDecimal("75.00");

            miscs.Add(misc);

            Miscellaneous misc2 = new Miscellaneous();

            misc2.name = "Transportation";
            misc2.type = MiscType.Deductions;
            misc2.amount = Convert.ToDecimal("150.00");

            miscs.Add(misc);

            return miscs;
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
                    bonus.type = sqlDataReader["type"].ToString() == "Benefits" ? MiscType.Benefits : MiscType.Deductions;
                }                
            }

            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return bonus;
        }
    }
}
