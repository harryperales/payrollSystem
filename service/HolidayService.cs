using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using System.Data.SqlClient;

namespace PayrollSystem.service
{
    public class HolidayService : HolidayServiceInterface
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\JenuNagil\Documents\Visual Studio 2008\Projects\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlDataReader;

        public HolidayService()
        {
            sqlCmd.Connection = sqlCon;
        }

        public List<Holiday> fetchHolidays()
        {
            List<Holiday> holidays = new List<Holiday>();

            sqlCon.Open();
            sqlCmd.CommandText = "SELECT id, name, description, date, status FROM Holiday;";
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Holiday holiday = new Holiday();
                    holiday.id = Int32.Parse(sqlDataReader["id"].ToString());
                    holiday.name = sqlDataReader["name"].ToString();
                    holiday.description = sqlDataReader["description"].ToString();
                    holiday.date = Convert.ToDateTime(sqlDataReader["date"].ToString());
                    holiday.holidayWages = sqlDataReader["status"].ToString() == "Regular" ? HolidayWages.Regular : HolidayWages.NonRegular;

                    holidays.Add(holiday);
                }
            }
            sqlCon.Close();
            return holidays;
        }
    }
}
