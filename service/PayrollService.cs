using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public class PayrollService : PayrollServiceInterface
    {
        public List<Payroll> fetchUserPayrolls(User user)
        {
            List<Payroll> payrolls = new List<Payroll>();
            Payroll payroll = new Payroll();
            payroll.startDate = new DateTime();
            payroll.endDate = new DateTime();

            payrolls.Add(payroll);
            return payrolls;
        }
    }
}
