using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public class MiscellaneousService : MiscellaneousServiceInterface
    {
        public List<Miscellaneous> fetchMiscellaneousByDeductionType(Employee employee)
        {
            List<Miscellaneous> miscs = new List<Miscellaneous>();
            Miscellaneous misc = new Miscellaneous();

            misc.name = "SSS";
            misc.type = MiscType.Deductions;
            misc.amount = Convert.ToDecimal("150.00");

            miscs.Add(misc);


            Miscellaneous miscPagibig = new Miscellaneous();

            miscPagibig.name = "PagIbig";
            miscPagibig.type = MiscType.Deductions;
            miscPagibig.amount = Convert.ToDecimal("100.00");

            miscs.Add(miscPagibig);

            Miscellaneous miscPhilHealth = new Miscellaneous();

            miscPhilHealth.name = "PagIbig";
            miscPhilHealth.type = MiscType.Deductions;
            miscPhilHealth.amount = Convert.ToDecimal("130.00");

            miscs.Add(miscPhilHealth);

            return miscs;
        }
    }
}
