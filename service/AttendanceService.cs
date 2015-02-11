using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using System.Data.SqlClient;

namespace PayrollSystem.service
{
    public class AttendanceService : AttendanceServiceInterface
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\JenuNagil\Documents\GitHub\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlDataReader;

        public AttendanceService()
        {
            sqlCmd.Connection = sqlCon;
        }

        public List<Attendance> fetchEmployeeAttendance(DateTime startDatePeriod, DateTime endDatePeriod, Employee employee)
        {
            var dates = Enumerable.Range(0, (endDatePeriod - startDatePeriod).Days + 1).Select(d => startDatePeriod.AddDays(d));

            List<Attendance> attendanceSheet = new List<Attendance>();
            foreach (var date in dates)
            {
                Attendance attendance = fetchEmployeeAttendanceByDate(employee, date);
                if (attendance != null)
                {
                    attendanceSheet.Add(attendance);
                }
            }
            return attendanceSheet;
        }

        public Attendance fetchEmployeeAttendanceByDate(Employee employee, DateTime date)
        {
            Attendance attendance = new Attendance();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT id, timeIn, timeOut From Attendance WHERE employeeId = @employeeNumber AND timeIn LIKE @date;";
            sqlCmd.Parameters.AddWithValue("@employeeNumber", employee.id);
            sqlCmd.Parameters.AddWithValue("@date", "%" + date.ToString("MM/dd/yyyy") + "%");
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    attendance.id = Int32.Parse(sqlDataReader["id"].ToString());
                    attendance.employee = employee;
                    attendance.timeIn = Convert.ToDateTime(sqlDataReader["timeIn"].ToString());
                    attendance.timeOut = Convert.ToDateTime(sqlDataReader["timeOut"].ToString());
                    TimeSpan offSet = new TimeSpan(0);
                    TimeSpan ts = Convert.ToDateTime(attendance.timeOut.ToString("hh:mm:ss tt")) - Convert.ToDateTime(attendance.timeIn.ToString("hh:mm:ss tt"));
                    attendance.employee = employee;
                }
            }
            else
            {
                attendance = null;
            }

            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return attendance;
        }
    }
}
