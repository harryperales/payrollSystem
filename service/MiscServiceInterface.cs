using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public interface MiscServiceInterface
    {
        List<Miscellaneous> fetchAllMisc();

        Miscellaneous addMisc(Miscellaneous misc);

        Miscellaneous fetchMiscByName(string selectedMisc);

        Miscellaneous updateMiscellaneous(Miscellaneous miscellaneous);
    }
}
