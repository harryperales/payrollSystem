using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public interface MiscControllerInterface
    {
        Miscellaneous addMisc(Miscellaneous miscellaneous);

        Miscellaneous fetchFoodAllowance();

        Miscellaneous fetchTranspoAllowance();

        Miscellaneous addMiscByEmployee(Miscellaneous foodAllowanceBenefits, Employee employee);

        Miscellaneous fetchMiscellaneousBenefitByNameAndEmployee(Employee employee, string benefitName);

        Miscellaneous updateMiscellaneousBenefitAmountById(Miscellaneous allowance);
    }
}
