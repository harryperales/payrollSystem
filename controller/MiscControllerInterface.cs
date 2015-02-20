﻿using System;
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
    }
}
