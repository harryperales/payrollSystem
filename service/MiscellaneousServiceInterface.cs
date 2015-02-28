using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public interface MiscellaneousServiceInterface
    {
        List<Miscellaneous> fetchMiscellaneousByDeductionType(Employee employee);

        List<Miscellaneous> fetchMiscellaneousByBenefitType(Employee employee);

        List<Miscellaneous> fetchBonusMiscellaneousByDescriptionAsDate(Employee employee, DateTime startDatePeriod, DateTime endDatePeriod);

        Miscellaneous fetchById(int miscellaneousId);

        Miscellaneous fetchMiscellaneousByName(string miscellaneousName);

        Miscellaneous createThirteenMonthBenefit(Employee employee);

        Miscellaneous createTransportationBenefit(Employee employee);

        Miscellaneous calculateThirteenMonth(Employee employee, DateTime endDatePeriod);

        Miscellaneous fetchEmployeeMiscellaneousBenefitByEmployeeId(Employee employee, string miscellaneousName);

        Miscellaneous createMiscellaenousByEmployee(Miscellaneous miscellaneous, Employee employee);

        Miscellaneous updateMiscellaneousBenefitAmountById(Miscellaneous allowance);
    }
}
