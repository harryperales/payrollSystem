using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public interface EmployeeServiceInterface
    {
        Employee saveEmployee(Employee employee);

        Employee fetchEmployeeByUsername(string usernameOrEmployeeId);

        Employee updateEmployee(Employee employee);

        Employee fetchEmployeeByEmployeeIdNUmber(long employeeNumber);

        Employee fetchEmployeeById(int employeeId);
    }
}
