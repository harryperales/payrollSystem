﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public interface HolidayServiceInterface
    {

        List<Holiday> fetchHolidays();
    }
}
