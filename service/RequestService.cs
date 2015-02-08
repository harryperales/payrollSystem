using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using System.Data.SqlClient;

namespace PayrollSystem.service
{
    public class RequestService : RequestServiceInterface
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\JenuNagil\Documents\Visual Studio 2008\Projects\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataReader sqlDataReader;

        public RequestService()
        {
            sqlCmd.Connection = sqlCon;
        }

        public List<Request> fetchOvertimeRequests(Employee employee, DateTime startDatePeriod, DateTime endDatePeriod)
        {
            var dates = Enumerable.Range(0, (endDatePeriod - startDatePeriod).Days + 1).Select(d => startDatePeriod.AddDays(d));
            List<Request> requests = new List<Request>();
            foreach (var date in dates)
            {
                Request request = fetchEmployeeApprovedOvertimeRequestByDate(employee, date);
                if (request != null)
                {
                    requests.Add(request);
                }
            }

            return requests;
        }

        public Request fetchEmployeeApprovedOvertimeRequestByDate(Employee employee, DateTime date)
        {
            Request request = new Request();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT id, name, description From Request WHERE employeeId = @employeeNumber AND dateRequested LIKE @date AND status = @status;";
            sqlCmd.Parameters.AddWithValue("@employeeNumber", employee.id);
            sqlCmd.Parameters.AddWithValue("@date", "%" + date.ToString("MM/dd/yyyy") + "%");
            sqlCmd.Parameters.AddWithValue("@status", "approved");
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    request.id = Int32.Parse(sqlDataReader["id"].ToString());
                    request.employee = employee;
                    request.name = sqlDataReader["name"].ToString();
                    request.description = sqlDataReader["description"].ToString();
                }
            }
            else
            {
                request = null;
            }
            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return request;
        }
    }
}
