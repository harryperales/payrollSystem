using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public interface MiscControllerInterface
    {
        List<Miscellaneous> viewAllMisc();

        Miscellaneous addMisc(Miscellaneous miscellaneous);

        Miscellaneous fetchMiscByName(string selectedMisc);

        Miscellaneous updateMiscellaneous(Miscellaneous miscellaneous);
    }
}
