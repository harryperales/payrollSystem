using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PayrollSystem.model;


namespace PayrollSystem.service
{
    public class LeaveCreditService : LeaveCreditServiceInterface
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\JenuNagil\Documents\GitHub\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlDataReader;

        private int VACATION_LEAVE_CREDITS = 12;
        private int SICK_LEAVE_CREDITS = 12;
        private int PATERNITY_LEAVE_CREDITS = 7;
        private int EMERGENCY_LEAVE_CREDITS = 3;
        private int BIRTHDAY_LEAVE_CREDITS = 1;
        private int BEREAVEMENT_LEAVE_CREDITS = 3;

        public LeaveCreditService()
        {
            sqlCmd.Connection = sqlCon;
        }

        public EmployeeLeaveCredits createEmployeeLeaveCredits(Employee employee)
        {
            LeaveCredits leaveCredits = new LeaveCredits();
            leaveCredits.vacationLeaveCredits = VACATION_LEAVE_CREDITS;
            leaveCredits.sickLeaveCredits = SICK_LEAVE_CREDITS;
            leaveCredits.paternityLeaveCredits = PATERNITY_LEAVE_CREDITS;
            leaveCredits.emergencyLeaveCredits = EMERGENCY_LEAVE_CREDITS;
            leaveCredits.birthdayLeaveCredits = BIRTHDAY_LEAVE_CREDITS;
            leaveCredits.bereavementLeaveCredits = BEREAVEMENT_LEAVE_CREDITS;
            sqlCon.Open();
            sqlCmd.CommandText = "INSERT INTO LeaveCredits (vacationLeaveCredit, sickLeaveCredit, "
            + "paternityLeaveCredit, emergencyLeaveCredit, birthdayLeaveCredit, bereavementLeaveCredit) "
            + "VALUES (@vacationLeaveCredit, @sickLeaveCredit, "
            + "@paternityLeaveCredit, @emergencyLeaveCredit, @birthdayLeaveCredit, @bereavementLeaveCredit); "
            + "SELECT CAST(scope_identity() AS int)";
            sqlCmd.Parameters.AddWithValue("@vacationLeaveCredit", leaveCredits.vacationLeaveCredits);
            sqlCmd.Parameters.AddWithValue("@sickLeaveCredit", leaveCredits.sickLeaveCredits);
            sqlCmd.Parameters.AddWithValue("@paternityLeaveCredit", leaveCredits.paternityLeaveCredits);
            sqlCmd.Parameters.AddWithValue("@emergencyLeaveCredit", leaveCredits.emergencyLeaveCredits);
            sqlCmd.Parameters.AddWithValue("@birthdayLeaveCredit", leaveCredits.birthdayLeaveCredits);
            sqlCmd.Parameters.AddWithValue("@bereavementLeaveCredit", leaveCredits.bereavementLeaveCredits);
            leaveCredits.id = (int)sqlCmd.ExecuteScalar();
            sqlCon.Close();

            EmployeeLeaveCredits employeeLeaveCredits = createEmployeeLeaveCredits(employee, leaveCredits);
            return null;
        }

        private EmployeeLeaveCredits createEmployeeLeaveCredits(Employee employee, LeaveCredits leaveCredits)
        {
            EmployeeLeaveCredits employeeLeaveCredits = new EmployeeLeaveCredits();
            sqlCon.Open();
            sqlCmd.CommandText = "INSERT INTO EmployeeLeaveCredits (employeeId, leaveCreditsId) "
            + "VALUES (@employeeId, @leaveCreditsId);SELECT CAST(scope_identity() AS int)";
            sqlCmd.Parameters.AddWithValue("@employeeId", employee.id);
            sqlCmd.Parameters.AddWithValue("@leaveCreditsId", leaveCredits.id);
            employeeLeaveCredits.id = (int)sqlCmd.ExecuteScalar();

            employeeLeaveCredits.employee = employee;
            employeeLeaveCredits.leaveCredits = leaveCredits;
            sqlCon.Close();
            return employeeLeaveCredits;
        }

        public EmployeeLeaveCredits updateEmployeeLeaveCredits(Employee employee, LeaveCredits leaveCredits)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "UPDATE LeaveCredits SET vacationLeaveCredit = @vacationLeaveCredit, "
            + "sickLeaveCredit =@sickLeaveCredit , paternityLeaveCredit =@paternityLeaveCredit, "
            + "emergencyLeaveCredit =@emergencyLeaveCredit , birthdayLeaveCredit =@birthdayLeaveCredit , "
            + "bereavementLeaveCredit =@bereavementLeaveCredit FROM EmployeeLeaveCredits INNER JOIN "
            + "LeaveCredits ON EmployeeLeaveCredits.leaveCreditsId = LeaveCredits.id "
            + "WHERE EmployeeLeaveCredits.employeeId = @employeeNumber";
            sqlCmd.Parameters.AddWithValue("@employeeNumber", employee.id);
            sqlCmd.Parameters.AddWithValue("@vacationLeaveCredit", leaveCredits.vacationLeaveCredits);
            sqlCmd.Parameters.AddWithValue("@sickLeaveCredit", leaveCredits.sickLeaveCredits);
            sqlCmd.Parameters.AddWithValue("@paternityLeaveCredit", leaveCredits.paternityLeaveCredits);
            sqlCmd.Parameters.AddWithValue("@emergencyLeaveCredit", leaveCredits.emergencyLeaveCredits);
            sqlCmd.Parameters.AddWithValue("@birthdayLeaveCredit", leaveCredits.birthdayLeaveCredits);
            sqlCmd.Parameters.AddWithValue("@bereavementLeaveCredit", leaveCredits.bereavementLeaveCredits);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            EmployeeLeaveCredits employeeLeaveCredits = new EmployeeLeaveCredits();
            employeeLeaveCredits.employee = employee;
            employeeLeaveCredits.leaveCredits = leaveCredits;
            return employeeLeaveCredits;
        }

        public LeaveCredits fetchLeaveCreditsByEmployee(Employee employee)
        {
            LeaveCredits leaveCredits = new LeaveCredits();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT EmployeeLeaveCredits.id, EmployeeLeaveCredits.employeeId, EmployeeLeaveCredits.leaveCreditsId, "
            + "LeaveCredits.vacationLeaveCredit, LeaveCredits.sickLeaveCredit, LeaveCredits.paternityLeaveCredit, "
            + "LeaveCredits.emergencyLeaveCredit, LeaveCredits.birthdayLeaveCredit, LeaveCredits.bereavementLeaveCredit "
            + "FROM EmployeeLeaveCredits INNER JOIN LeaveCredits ON "
            + "EmployeeLeaveCredits.leaveCreditsId = LeaveCredits.id "
            + "WHERE (EmployeeLeaveCredits.employeeId = @employeeId)";
            sqlCmd.Parameters.AddWithValue("@employeeId", employee.id);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    leaveCredits.id = Int32.Parse(sqlDataReader["leaveCreditsId"].ToString());
                    leaveCredits.vacationLeaveCredits = Int32.Parse(sqlDataReader["vacationLeaveCredit"].ToString());
                    leaveCredits.sickLeaveCredits = Int32.Parse(sqlDataReader["sickLeaveCredit"].ToString());
                    leaveCredits.paternityLeaveCredits = Int32.Parse(sqlDataReader["paternityLeaveCredit"].ToString());
                    leaveCredits.emergencyLeaveCredits = Int32.Parse(sqlDataReader["emergencyLeaveCredit"].ToString());
                    leaveCredits.birthdayLeaveCredits = Int32.Parse(sqlDataReader["birthdayLeaveCredit"].ToString());
                    leaveCredits.bereavementLeaveCredits = Int32.Parse(sqlDataReader["bereavementLeaveCredit"].ToString());
                }
            }
            sqlCon.Close();
            return leaveCredits;
        }
    }
}
