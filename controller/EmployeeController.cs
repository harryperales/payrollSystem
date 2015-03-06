using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.service;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public class EmployeeController : EmployeeControllerInterface
    {
        EmployeeServiceInterface employeeService;
        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }

        public EmployeeController(EmployeeServiceInterface employeeService)
        {
            this.employeeService = employeeService;
        }

        public Employee saveEmployee(Employee employee)
        {
            return employeeService.saveEmployee(employee);
        }

        public Employee fetchEmployeeByUsername(string usernameOrEmployeeId)
        {
            return employeeService.fetchEmployeeByUsername(usernameOrEmployeeId);
        }

        public Employee updateEmployee(Employee employee)
        {
            return employeeService.updateEmployee(employee);
        }

        public Employee fetchEmployeeByEmployeeIdNumber(long employeeNumber)
        {
            return employeeService.fetchEmployeeByEmployeeIdNUmber(employeeNumber);
        }

        public Employee fetchEmployeeById(int employeeId)
        {
            return employeeService.fetchEmployeeById(employeeId);
        }
    }
}
