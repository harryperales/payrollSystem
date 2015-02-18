using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public interface PayrollServiceInterface
    {
        List<Payslip> fetchUserPayrolls(User user);

        Payslip createPayslip(Employee employee, Payslip payslip);

        Payslip fetchPayslipById(int payslipId);
    }
}
