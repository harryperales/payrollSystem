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
        SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\JenuNagil\Documents\GitHub\PayrollSystem\PayrollSystem\Payroll.mdf;Integrated Security=True;User Instance=True");
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
            sqlCmd.CommandText = "SELECT id, name, description, requestedDate ,dateRequested From Request WHERE employeeId = @employeeNumber AND name = @name AND dateRequested LIKE @date AND status = @status;";
            sqlCmd.Parameters.AddWithValue("@employeeNumber", employee.id);
            sqlCmd.Parameters.AddWithValue("@name", "OVERTIME");
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
                    request.requestedDate = Convert.ToDateTime(sqlDataReader["requestedDate"].ToString());
                    request.dateFiled = Convert.ToDateTime(sqlDataReader["dateRequested"].ToString());
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

        public List<Request> fetchLeaveRequest(Employee employee, DateTime startDatePeriod, DateTime endDatePeriod)
        {
            var dates = Enumerable.Range(0, (endDatePeriod - startDatePeriod).Days + 1).Select(d => startDatePeriod.AddDays(d));
            List<Request> requests = new List<Request>();
            foreach (var date in dates)
            {
                Request request = fetchEmployeeApprovedLeaveRequestByDate(employee, date);
                if (request != null)
                {
                    requests.Add(request);
                }
            }

            return requests;
        }

        public Request fetchEmployeeApprovedLeaveRequestByDate(Employee employee, DateTime date)
        {
            Request request = new Request();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT id, name, description, requestedDate, dateRequested From Request WHERE employeeId = @employeeNumber AND dateRequested LIKE @date AND status = @status AND name LIKE @name;";
            sqlCmd.Parameters.AddWithValue("@employeeNumber", employee.id);
            sqlCmd.Parameters.AddWithValue("@name", "%LEAVE%");
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
                    request.requestedDate = Convert.ToDateTime(sqlDataReader["requestedDate"].ToString());
                    request.dateFiled = Convert.ToDateTime(sqlDataReader["dateRequested"].ToString());
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

        public List<Request> fetchAllPendingRequests()
        {
            List<Request> requests = new List<Request>();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT Request.id, Request.name, Request.status, Request.description, "
            + "Request.dateRequested, Employee.id AS employeeId, Employee.employeeId AS employeeNumber, "
            + "Employee.userAccountId, Employee.fullName, Employee.birthDate, Employee.gender, "
            + "Employee.civilStatus, Employee.dependents, Employee.address, "
            + "Employee.contactNumber, Employee.tin, Employee.sssId, Employee.pagIbigId, "
            + "Employee.philHealthId, Employee.dateEmployed, Employee.jobPositionId FROM Request INNER JOIN "
            + "Employee ON Request.employeeId = Employee.id WHERE (Request.status = @status)";
            sqlCmd.Parameters.AddWithValue("@status", "pending");
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Request request = new Request();
                    request.id = Int32.Parse(sqlDataReader["id"].ToString());
                    Employee employee = new Employee();
                    employee.id = Int32.Parse(sqlDataReader["id"].ToString());
                    employee.employeeId = Int64.Parse(sqlDataReader["employeeNumber"].ToString());
                    employee.fullName = sqlDataReader["fullName"].ToString();
                    employee.birthDate = sqlDataReader["birthDate"].ToString();
                    employee.gender = sqlDataReader["gender"].ToString();
                    employee.civilStatus = sqlDataReader["civilStatus"].ToString();
                    employee.dependents = Int32.Parse(sqlDataReader["dependents"].ToString());
                    employee.address = sqlDataReader["address"].ToString();
                    employee.contactNumber = sqlDataReader["contactNumber"].ToString();
                    employee.tin = sqlDataReader["tin"].ToString();
                    employee.sssId = sqlDataReader["sssId"].ToString();
                    employee.pagIbigId = sqlDataReader["pagIbigId"].ToString();
                    employee.philHealthId = sqlDataReader["philHealthId"].ToString();
                    employee.dateEmployed = sqlDataReader["dateEmployed"].ToString();

                    request.employee = employee;
                    request.name = sqlDataReader["name"].ToString();
                    request.status = RequestStatus.Pending;
                    request.description = sqlDataReader["description"].ToString();
                    request.dateFiled = Convert.ToDateTime(sqlDataReader["dateRequested"].ToString());
                    requests.Add(request);
                }
            }
            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return requests;
        }

        public Request fetchPendingRequestById(int requestId)
        {
            Request request = new Request();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT Request.id, Request.name, Request.status, Request.description, "
            + "Request.dateRequested, Employee.id AS employeeId, Employee.employeeId AS employeeNumber, "
            + "Employee.userAccountId, Employee.fullName, Employee.birthDate, Employee.gender, "
            + "Employee.civilStatus, Employee.dependents, Employee.address, "
            + "Employee.contactNumber, Employee.tin, Employee.sssId, Employee.pagIbigId, "
            + "Employee.philHealthId, Employee.dateEmployed, Employee.jobPositionId FROM Request INNER JOIN "
            + "Employee ON Request.employeeId = Employee.id WHERE (Request.status = @status) AND Request.id = @requestId";
            sqlCmd.Parameters.AddWithValue("@status", "pending");
            sqlCmd.Parameters.AddWithValue("@requestId", requestId); 
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    request.id = Int32.Parse(sqlDataReader["id"].ToString());
                    Employee employee = new Employee();
                    employee.id = Int32.Parse(sqlDataReader["id"].ToString());
                    employee.employeeId = Int64.Parse(sqlDataReader["employeeNumber"].ToString());
                    employee.fullName = sqlDataReader["fullName"].ToString();
                    employee.birthDate = sqlDataReader["birthDate"].ToString();
                    employee.gender = sqlDataReader["gender"].ToString();
                    employee.civilStatus = sqlDataReader["civilStatus"].ToString();
                    employee.dependents = Int32.Parse(sqlDataReader["dependents"].ToString());
                    employee.address = sqlDataReader["address"].ToString();
                    employee.contactNumber = sqlDataReader["contactNumber"].ToString();
                    employee.tin = sqlDataReader["tin"].ToString();
                    employee.sssId = sqlDataReader["sssId"].ToString();
                    employee.pagIbigId = sqlDataReader["pagIbigId"].ToString();
                    employee.philHealthId = sqlDataReader["philHealthId"].ToString();
                    employee.dateEmployed = sqlDataReader["dateEmployed"].ToString();

                    request.employee = employee;
                    request.name = sqlDataReader["name"].ToString();
                    request.status = RequestStatus.Pending;
                    request.description = sqlDataReader["description"].ToString();
                    request.dateFiled = Convert.ToDateTime(sqlDataReader["dateRequested"].ToString());
                }
            }
            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return request;
        }

        public Request updateRequestStatusById(int requestId, string status)
        {
            Request request = fetchById(requestId);
            sqlCon.Open();
            sqlCmd.CommandText = "UPDATE Request SET status = @status WHERE (id = @id);";
            sqlCmd.Parameters.AddWithValue("@status", status);
            sqlCmd.Parameters.AddWithValue("@id", requestId);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            if (status == "approved")
            {
                EmployeeServiceInterface employeeService = new EmployeeService();
                Employee employee = employeeService.fetchEmployeeById(request.employee.id);

                LeaveCreditServiceInterface leaveCreditsService = new LeaveCreditService();
                LeaveCredits leaveCredits = leaveCreditsService.fetchLeaveCreditsByEmployee(employee);
                if (request.name.Equals("Vacation Leave"))
                {
                    leaveCredits.vacationLeaveCredits -= 1;
                }
                else if (request.name.Equals("Sick Leave"))
                {
                    leaveCredits.sickLeaveCredits -= 1;
                }
                else if (request.name.Equals("Bereavement Leave"))
                {
                    leaveCredits.bereavementLeaveCredits -= 1;
                }
                else if (request.name.Equals("Paternity Leave"))
                {
                    leaveCredits.paternityLeaveCredits -= 1;
                }
                else if (request.name.Equals("Emergency Leave"))
                {
                    leaveCredits.emergencyLeaveCredits -= 1;
                }
                else if (request.name.Equals("Birthday Leave"))
                {
                    leaveCredits.emergencyLeaveCredits -= 1;
                }
                EmployeeLeaveCredits employeeLeaveRequest = leaveCreditsService.updateEmployeeLeaveCredits(employee, leaveCredits);
            }
            return request;
        }

        public Request fetchById(int requestId)
        {
            Request request = new Request();
            Employee employee = new Employee();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT Request.id, Request.name, Request.status, Request.description, "
            + "Request.dateRequested, Employee.id AS employeeId, Employee.employeeId AS employeeNumber, "
            + "Employee.userAccountId, Employee.fullName, Employee.birthDate, Employee.gender, "
            + "Employee.civilStatus, Employee.dependents, Employee.address, "
            + "Employee.contactNumber, Employee.tin, Employee.sssId, Employee.pagIbigId, "
            + "Employee.philHealthId, Employee.dateEmployed, Employee.jobPositionId FROM Request INNER JOIN "
            + "Employee ON Request.employeeId = Employee.id WHERE (Request.id = @requestId)";
            sqlCmd.Parameters.AddWithValue("@requestId", requestId);
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    request.id = Int32.Parse(sqlDataReader["id"].ToString());
                    employee.id = Int32.Parse(sqlDataReader["employeeId"].ToString());
                    employee.employeeId = Int64.Parse(sqlDataReader["employeeNumber"].ToString());
                    employee.fullName = sqlDataReader["fullName"].ToString();
                    employee.birthDate = sqlDataReader["birthDate"].ToString();
                    employee.gender = sqlDataReader["gender"].ToString();
                    employee.civilStatus = sqlDataReader["civilStatus"].ToString();
                    employee.dependents = Int32.Parse(sqlDataReader["dependents"].ToString());
                    employee.address = sqlDataReader["address"].ToString();
                    employee.contactNumber = sqlDataReader["contactNumber"].ToString();
                    employee.tin = sqlDataReader["tin"].ToString();
                    employee.sssId = sqlDataReader["sssId"].ToString();
                    employee.pagIbigId = sqlDataReader["pagIbigId"].ToString();
                    employee.philHealthId = sqlDataReader["philHealthId"].ToString();
                    employee.dateEmployed = sqlDataReader["dateEmployed"].ToString();

                    request.employee = employee;
                    Console.WriteLine(employee.fullName);
                    request.name = sqlDataReader["name"].ToString();
                    string status = sqlDataReader["status"].ToString();
                    request.description = sqlDataReader["description"].ToString();
                    request.dateFiled = Convert.ToDateTime(sqlDataReader["dateRequested"].ToString());
                    if (status.Equals("approved"))
                    {
                        request.status = RequestStatus.Approved;
                    }
                    else if (status.Equals("disapproved"))
                    {
                        request.status = RequestStatus.Disapproved;
                    }
                    else if (status.Equals("pending"))
                    {
                        request.status = RequestStatus.Pending;
                    }
                    request.dateFiled = Convert.ToDateTime(sqlDataReader["dateRequested"].ToString());
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

        public List<Request> fetchAllApprovedRequests()
        {
            List<Request> requests = new List<Request>();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT Request.id, Request.name, Request.status, Request.description, "
            + "Request.dateRequested, Employee.id AS employeeId, Employee.employeeId AS employeeNumber, "
            + "Employee.userAccountId, Employee.fullName, Employee.birthDate, Employee.gender, "
            + "Employee.civilStatus, Employee.dependents, Employee.address, "
            + "Employee.contactNumber, Employee.tin, Employee.sssId, Employee.pagIbigId, "
            + "Employee.philHealthId, Employee.dateEmployed, Employee.jobPositionId FROM Request INNER JOIN "
            + "Employee ON Request.employeeId = Employee.id WHERE (Request.status = @status)";
            sqlCmd.Parameters.AddWithValue("@status", "approved");
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Request request = new Request();
                    request.id = Int32.Parse(sqlDataReader["id"].ToString());
                    Employee employee = new Employee();
                    employee.id = Int32.Parse(sqlDataReader["id"].ToString());
                    employee.employeeId = Int64.Parse(sqlDataReader["employeeNumber"].ToString());
                    employee.fullName = sqlDataReader["fullName"].ToString();
                    employee.birthDate = sqlDataReader["birthDate"].ToString();
                    employee.gender = sqlDataReader["gender"].ToString();
                    employee.civilStatus = sqlDataReader["civilStatus"].ToString();
                    employee.dependents = Int32.Parse(sqlDataReader["dependents"].ToString());
                    employee.address = sqlDataReader["address"].ToString();
                    employee.contactNumber = sqlDataReader["contactNumber"].ToString();
                    employee.tin = sqlDataReader["tin"].ToString();
                    employee.sssId = sqlDataReader["sssId"].ToString();
                    employee.pagIbigId = sqlDataReader["pagIbigId"].ToString();
                    employee.philHealthId = sqlDataReader["philHealthId"].ToString();
                    employee.dateEmployed = sqlDataReader["dateEmployed"].ToString();

                    request.employee = employee;
                    request.name = sqlDataReader["name"].ToString();
                    request.status = RequestStatus.Approved;
                    request.description = sqlDataReader["description"].ToString();
                    request.dateFiled = Convert.ToDateTime(sqlDataReader["dateRequested"].ToString());
                    requests.Add(request);
                }
            }
            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return requests;
        }

        public Request createRequest(Request request)
        {
            sqlCon.Open();
            sqlCmd.CommandText = "INSERT INTO Request (employeeId, name, status, requestedDate, description, dateRequested) "
                + "VALUES(@employeeId, @name, @status, @requestedDate, @description, @dateRequested);SELECT CAST(scope_identity() AS int)";
            sqlCmd.Parameters.AddWithValue("@employeeId", request.employee.id);
            sqlCmd.Parameters.AddWithValue("@name", request.name);
            sqlCmd.Parameters.AddWithValue("@status", "pending");
            sqlCmd.Parameters.AddWithValue("@requestedDate", request.requestedDate.ToString("MM/dd/yyyy HH:mm"));
            sqlCmd.Parameters.AddWithValue("@description", request.description);
            sqlCmd.Parameters.AddWithValue("@dateRequested", request.dateFiled.ToString("MM/dd/yyyy HH:mm"));
            request.id = (int)sqlCmd.ExecuteScalar();
            sqlCon.Close();
            return request;
        }

        public List<Request> fetchPendingRequestByEmployee(Employee employee)
        {
            List<Request> requests = new List<Request>();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT id, name, description, requestedDate, dateRequested From Request WHERE employeeId = @employeeNumber AND status = @status ORDER BY id DESC;";
            sqlCmd.Parameters.AddWithValue("@employeeNumber", employee.id);
            sqlCmd.Parameters.AddWithValue("@status", "pending");
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Request request = new Request();
                    request.id = Int32.Parse(sqlDataReader["id"].ToString());
                    request.employee = employee;
                    request.name = sqlDataReader["name"].ToString();
                    request.description = sqlDataReader["description"].ToString();
                    request.requestedDate = Convert.ToDateTime(sqlDataReader["requestedDate"].ToString());
                    request.dateFiled = Convert.ToDateTime(sqlDataReader["dateRequested"].ToString());
                    requests.Add(request);
                }
            }
            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return requests;
        }

        public List<Request> fetchApprovedRequestByEmployee(Employee employee)
        {
            List<Request> requests = new List<Request>();
            sqlCon.Open();
            sqlCmd.CommandText = "SELECT id, name, description, requestedDate, dateRequested From Request WHERE employeeId = @employeeNumber AND status = @status ORDER BY id DESC;";
            sqlCmd.Parameters.AddWithValue("@employeeNumber", employee.id);
            sqlCmd.Parameters.AddWithValue("@status", "approved");
            sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Request request = new Request();
                    request.id = Int32.Parse(sqlDataReader["id"].ToString());
                    request.employee = employee;
                    request.name = sqlDataReader["name"].ToString();
                    request.description = sqlDataReader["description"].ToString();
                    request.requestedDate = Convert.ToDateTime(sqlDataReader["requestedDate"].ToString());
                    request.dateFiled = Convert.ToDateTime(sqlDataReader["dateRequested"].ToString());
                    requests.Add(request);
                }
            }
            sqlCmd.Parameters.Clear();
            sqlCon.Close();
            return requests;
        }
    }
}
