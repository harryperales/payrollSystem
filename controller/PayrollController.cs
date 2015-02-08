using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.service;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public class PayrollController : PayrollControllerInterface
    {
        PayrollServiceInterface payrollService;
        public PayrollController()
        {
            payrollService = new PayrollService();
        }
        public List<Payroll> fetchUserPayrolls(User user)
        {
            return payrollService.fetchUserPayrolls(user);
        }
    }
}
