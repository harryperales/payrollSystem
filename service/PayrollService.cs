using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using System.Data.SqlClient;

namespace PayrollSystem.service
{
    public class PayrollService : PayrollServiceInterface
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\JenuNagil\Documents\GitHub\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlDataReader;

        public PayrollService()
        {
            sqlCmd.Connection = sqlCon;
        }
        public List<Payroll> fetchUserPayrolls(User user)
        {
            List<Payroll> payrolls = new List<Payroll>();
            Payroll payroll = new Payroll();
            payroll.startDate = new DateTime();
            payroll.endDate = new DateTime();

            payrolls.Add(payroll);
            return payrolls;
        }

        public Payslip createPayslip(Employee employee, Payslip payslip)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "INSERT INTO Payroll (dateCreated, employeeId, startDate, endDate, basePay, netPay, taxDeduction) VALUES (@dateCreated, @employeeId, @startDate, @endDate, @basePay, @netPay, @taxDeduction);SELECT CAST(scope_identity() AS int)";
            sqlCmd.Parameters.AddWithValue("@dateCreated", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
            sqlCmd.Parameters.AddWithValue("@employeeId", employee.id);
            sqlCmd.Parameters.AddWithValue("@startDate", payslip.startDatePeriod.ToString("MM/dd/yyyy hh:mm:ss tt"));
            sqlCmd.Parameters.AddWithValue("@endDate", payslip.endDatePeriod.ToString("MM/dd/yyyy hh:mm:ss tt"));
            sqlCmd.Parameters.AddWithValue("@basePay", payslip.basePay);
            sqlCmd.Parameters.AddWithValue("@netPay", payslip.netPay);
            sqlCmd.Parameters.AddWithValue("@taxDeduction", payslip.taxDeduction);
            payslip.id = (int)sqlCmd.ExecuteScalar();
            sqlCon.Close();

            createPayslipWithMiscellaneous(payslip);

            return payslip;
        }

        private void createPayslipWithMiscellaneous(Payslip payslip)
        {
            Console.WriteLine("im here");
            foreach( Miscellaneous misc in payslip.miscellaneous) {
                Console.WriteLine(misc.type+ "- "+ misc.id);
                sqlCon.Open();
                sqlCmd.CommandText = "INSERT INTO PayslipMiscellaneous (payslipId, miscellaneousId) VALUES (@payslipId, @miscellaneousId);";
                sqlCmd.Parameters.AddWithValue("@payslipId", payslip.id);
                sqlCmd.Parameters.AddWithValue("@miscellaneousId", misc.id);
                sqlCon.Close();
            }
        }
    }
}
