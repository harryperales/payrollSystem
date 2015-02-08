using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public interface EmployeeControllerInterface
    {
        Employee saveEmployee(Employee employee);

        Employee fetchEmployeeByUsername(string usernameOrEmployeeId);

        Employee updateEmployee(Employee employee);
    }
}
