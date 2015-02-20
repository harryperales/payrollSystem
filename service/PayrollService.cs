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
        public List<Payslip> fetchUserPayrolls(User user)
        {
            EmployeeServiceInterface employeeService = new EmployeeService();
            Employee employee = employeeService.fetchEmployeeByUsername(user.username);
            List<Payslip> payroll = new List<Payslip>();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT * From Payroll WHERE employeeId = @employeeId ORDER BY id DESC;";
            sqlCmd.Parameters.AddWithValue("@employeeId", employee.id);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Payslip payslip = new Payslip();
                    payslip.id = Int32.Parse(sqlDataReader["id"].ToString());
                    payslip.dateCreated = Convert.ToDateTime(sqlDataReader["dateCreated"].ToString());
                    payslip.startDatePeriod = Convert.ToDateTime(sqlDataReader["startDate"].ToString());
                    payslip.endDatePeriod = Convert.ToDateTime(sqlDataReader["endDate"].ToString());
                    payslip.basePay = Convert.ToDecimal(sqlDataReader["basePay"].ToString());
                    payslip.taxDeduction = Convert.ToDecimal(sqlDataReader["taxDeduction"].ToString());
                    payslip.netPay = Convert.ToDecimal(sqlDataReader["netPay"].ToString());
                    payslip.sssDeduction = Convert.ToDecimal(sqlDataReader["sssDeduction"].ToString());
                    payslip.pagIbigDeduction = Convert.ToDecimal(sqlDataReader["pagIbigDeduction"].ToString());
                    payslip.philHealthDeduction = Convert.ToDecimal(sqlDataReader["philHealthDeduction"].ToString());

                    payroll.Add(payslip);
                }
            }
            sqlCon.Close();
            return payroll;
        }

        public Payslip createPayslip(Employee employee, Payslip payslip)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "INSERT INTO Payroll (dateCreated, employeeId, startDate, endDate, basePay, netPay, taxDeduction, sssDeduction, pagIbigDeduction, philHealthDeduction) "
            + "VALUES (@dateCreated, @employeeId, @startDate, @endDate, @basePay, @netPay, @taxDeduction, @sssDeduction, @pagIbigDeduction, @philHealthDeduction);SELECT CAST(scope_identity() AS int)";
            sqlCmd.Parameters.AddWithValue("@dateCreated", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
            sqlCmd.Parameters.AddWithValue("@employeeId", employee.id);
            sqlCmd.Parameters.AddWithValue("@startDate", payslip.startDatePeriod.ToString("MM/dd/yyyy hh:mm:ss tt"));
            sqlCmd.Parameters.AddWithValue("@endDate", payslip.endDatePeriod.ToString("MM/dd/yyyy hh:mm:ss tt"));
            sqlCmd.Parameters.AddWithValue("@basePay", payslip.basePay);
            sqlCmd.Parameters.AddWithValue("@netPay", payslip.netPay);
            sqlCmd.Parameters.AddWithValue("@taxDeduction", payslip.taxDeduction);
            sqlCmd.Parameters.AddWithValue("@sssDeduction", payslip.sssDeduction);
            sqlCmd.Parameters.AddWithValue("@pagIbigDeduction", payslip.pagIbigDeduction);
            sqlCmd.Parameters.AddWithValue("@philHealthDeduction", payslip.philHealthDeduction);
            payslip.id = (int)sqlCmd.ExecuteScalar();
            sqlCon.Close();

            createPayslipWithMiscellaneous(payslip);
            createPayslipWithRequest(payslip);

            return payslip;
        }

        private void createPayslipWithRequest(Payslip payslip)
        {
            foreach (Request request in payslip.requests)
            {
                sqlCon.Open();
                sqlCmd.CommandText = "INSERT INTO PayslipRequest (payslipId, requestId) VALUES (@payslipId, @requestId);";
                sqlCmd.Parameters.AddWithValue("@payslipId", payslip.id);
                sqlCmd.Parameters.AddWithValue("@requestId", request.id);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Parameters.Clear();
                sqlCon.Close();
            }
        }

        private void createPayslipWithMiscellaneous(Payslip payslip)
        {
            foreach( Miscellaneous misc in payslip.miscellaneous) {
                sqlCon.Open();
                sqlCmd.CommandText = "INSERT INTO PayslipMiscellaneous (payslipId, miscellaneousId) VALUES (@payslipId, @miscellaneousId);";
                sqlCmd.Parameters.AddWithValue("@payslipId", payslip.id);
                sqlCmd.Parameters.AddWithValue("@miscellaneousId", misc.id);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Parameters.Clear();
                sqlCon.Close();
            }
        }

        public Payslip fetchPayslipById(int payslipId)
        {
            Payslip payslip = new Payslip();
            Employee employee = new Employee();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT * From Payroll WHERE id = @payslipId";
            sqlCmd.Parameters.AddWithValue("@payslipId", payslipId);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    payslip.id = Int32.Parse(sqlDataReader["id"].ToString());
                    employee.id = Int32.Parse(sqlDataReader["employeeId"].ToString());
                    payslip.employee = employee;
                    payslip.dateCreated = Convert.ToDateTime(sqlDataReader["dateCreated"].ToString());
                    payslip.startDatePeriod = Convert.ToDateTime(sqlDataReader["startDate"].ToString());
                    payslip.endDatePeriod = Convert.ToDateTime(sqlDataReader["endDate"].ToString());
                    payslip.basePay = Convert.ToDecimal(sqlDataReader["basePay"].ToString());
                    payslip.taxDeduction = Convert.ToDecimal(sqlDataReader["taxDeduction"].ToString());
                    payslip.netPay = Convert.ToDecimal(sqlDataReader["netPay"].ToString());
                    payslip.sssDeduction = Convert.ToDecimal(sqlDataReader["sssDeduction"].ToString());
                    payslip.pagIbigDeduction = Convert.ToDecimal(sqlDataReader["pagIbigDeduction"].ToString());
                    payslip.philHealthDeduction = Convert.ToDecimal(sqlDataReader["philHealthDeduction"].ToString());                    
                }
            }
            sqlCmd.Parameters.Clear();
            sqlCon.Close();

            List<int> requestIds = fetchRequestIdsByPayslipId(payslip.id);
            List<int> miscellaneousIds = fetchMiscellaneousIdsByPayslipId(payslip.id);
            payslip.miscellaneous = new List<Miscellaneous>();
            payslip.requests = new List<Request>();
            RequestServiceInterface requestService = new RequestService();
            foreach (int requestId in requestIds)
            {
                payslip.requests.Add(requestService.fetchById(requestId));
            }

            MiscellaneousServiceInterface miscellaneousService = new MiscellaneousService();
            foreach (int miscellaneousId in miscellaneousIds)
            {
                payslip.miscellaneous.Add(miscellaneousService.fetchById(miscellaneousId));
            }

            //payslip.requests = requestService.
            return payslip;
        }

        private List<int> fetchRequestIdsByPayslipId(int payslipId)
        {
            List<int> requestIds = new List<int>();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT * From PayslipRequest WHERE payslipId = @payslipId ORDER BY id DESC;";
            sqlCmd.Parameters.AddWithValue("@payslipId", payslipId);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    requestIds.Add(Int32.Parse(sqlDataReader["requestId"].ToString()));
                }
            }
            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return requestIds;
        }

        private List<int> fetchMiscellaneousIdsByPayslipId(int payslipId)
        {
            List<int> miscellaneousIds = new List<int>();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT * From PayslipMiscellaneous WHERE payslipId = @payslipId ORDER BY id DESC;";
            sqlCmd.Parameters.AddWithValue("@payslipId", payslipId);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    miscellaneousIds.Add(Int32.Parse(sqlDataReader["miscellaneousId"].ToString()));
                }
            }
            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return miscellaneousIds;
        }

        public List<Payslip> fetchPayroll()
        {
            List<Payslip> payroll = new List<Payslip>();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT * From Payroll ORDER BY id DESC;";
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Payslip payslip = new Payslip();
                    EmployeeServiceInterface employeeService = new EmployeeService();
                    payslip.employee = employeeService.fetchEmployeeById(Int32.Parse(sqlDataReader["employeeId"].ToString()));
                    payslip.id = Int32.Parse(sqlDataReader["id"].ToString());
                    payslip.dateCreated = Convert.ToDateTime(sqlDataReader["dateCreated"].ToString());
                    payslip.startDatePeriod = Convert.ToDateTime(sqlDataReader["startDate"].ToString());
                    payslip.endDatePeriod = Convert.ToDateTime(sqlDataReader["endDate"].ToString());
                    payslip.basePay = Convert.ToDecimal(sqlDataReader["basePay"].ToString());
                    payslip.taxDeduction = Convert.ToDecimal(sqlDataReader["taxDeduction"].ToString());
                    payslip.netPay = Convert.ToDecimal(sqlDataReader["netPay"].ToString());
                    payslip.sssDeduction = Convert.ToDecimal(sqlDataReader["sssDeduction"].ToString());
                    payslip.pagIbigDeduction = Convert.ToDecimal(sqlDataReader["pagIbigDeduction"].ToString());
                    payslip.philHealthDeduction = Convert.ToDecimal(sqlDataReader["philHealthDeduction"].ToString());

                    payroll.Add(payslip);
                }
            }
            sqlCon.Close();
            return payroll;
        }
    }
}
