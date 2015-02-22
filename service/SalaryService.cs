using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using System.IO;
using System.Diagnostics;

namespace PayrollSystem.service
{
    public class SalaryService : SalaryServiceInterface
    {
        private int SINGLE_MARRIED_LOWER_LIMIT = 2;
        private int SINGLE_MARRIED_UPPER_LIMIT = 3;
        private int SINGLE1_MARRIED1_LOWER_LIMIT = 4;
        private int SINGLE1_MARRIED1_UPPER_LIMIT = 5;
        private int SINGLE2_MARRIED2_LOWER_LIMIT = 6;
        private int SINGLE2_MARRIED2_UPPER_LIMIT = 7;
        private int SINGLE3_MARRIED3_LOWER_LIMIT = 8;
        private int SINGLE3_MARRIED3_UPPER_LIMIT = 9;
        private int SINGLE4_MARRIED4_LOWER_LIMIT = 10;
        private int SINGLE4_MARRIED4_UPPER_LIMIT = 11;

        private HolidayServiceInterface holidayService;
        public SalaryService()
        {
            holidayService = new HolidayService();
        }

        public decimal calculatePeriodSalary(List<Attendance> attendances, decimal dailyBasedSalary)
        {
            List<Holiday> holidays = holidayService.fetchHolidays();
            decimal periodSalary = 0.00M;
            decimal perHourBasedSalary = 0.00M;
            perHourBasedSalary = decimal.Divide(dailyBasedSalary, 8.00M);
            Console.WriteLine("attendancesCount" + attendances.Count);
            foreach (Attendance attendance in attendances)
            {
                TimeSpan breakTimeHour = fetchOneHourBreakTimeSpan();

                TimeSpan timeSpent = calculateTimeSpent(attendance);

                timeSpent -= breakTimeHour;
                TimeSpan validTimeSpent = fetchValidDutyHoursTimeSpan();

                // enforcing timeSpent to have an 8 hours only, if the user has an overtime, they should file an overtime request
                if (timeSpent > validTimeSpent)
                {
                    timeSpent = validTimeSpent;
                }
                if (timeSpent < new TimeSpan(0))
                {
                    timeSpent = new TimeSpan(0);
                }
                decimal calculatedSalaryWithTimeSpent = calculatePerHourSalaryFromHoursSpent(perHourBasedSalary, Convert.ToDecimal(timeSpent.Hours));

                decimal convertedMinutesToHour = decimal.Divide(timeSpent.Minutes, 59);
                calculatedSalaryWithTimeSpent += calculatePerHourSalaryFromHoursSpent(perHourBasedSalary, convertedMinutesToHour);

                periodSalary += calculatedSalaryWithTimeSpent;

                foreach (Holiday holiday in holidays)
                {

                    if (!holiday.date.ToString("MM/dd/yyyy").Equals(attendance.timeIn.ToString("MM/dd/yyyy")))
                    {
                        //nothing to do, just to skip the loop
                    } 
                    else if (holiday.holidayWages == HolidayWages.NonRegular)
                    {
                        Console.WriteLine("non-regular");
                        periodSalary += decimal.Multiply(dailyBasedSalary, 0.30M); // add 30% of daily Salary
                    }
                    else if (holiday.holidayWages == HolidayWages.Regular)
                    {
                        Console.WriteLine("regular");
                        periodSalary += dailyBasedSalary; // add 100% daily salary
                    }

                }
            }
            return periodSalary;
        }

        private static TimeSpan fetchValidDutyHoursTimeSpan()
        {
            return Convert.ToDateTime("08:00:00") - Convert.ToDateTime("00:00:00");
        }

        private static TimeSpan calculateTimeSpent(Attendance attendance)
        {
            return Convert.ToDateTime(attendance.timeOut.ToString("hh:mm:ss tt")) - Convert.ToDateTime(attendance.timeIn.ToString("hh:mm:ss tt"));
        }

        private static TimeSpan fetchOneHourBreakTimeSpan()
        {
            return Convert.ToDateTime("01:00:00") - Convert.ToDateTime("00:00:00");
        }

        private decimal calculatePerHourSalaryFromHoursSpent(decimal perHourBasedSalary, decimal hour)
        {
            return decimal.Multiply(perHourBasedSalary, hour);
        }

        public decimal calculateDailyBasedSalaryWithOvertimeRequests(List<Request> overtimeRequests, decimal dailyBasedSalary)
        {
            List<Holiday> holidays = holidayService.fetchHolidays();
            decimal totalOvertimeSalary = 0.00M;
            decimal perHourBasedSalary = 0.00M;
            perHourBasedSalary = decimal.Divide(dailyBasedSalary, 8.00M);
            decimal perHourBasedSalaryWithAddedPercent = 0.00M;
            Boolean isOvertimeDateFallsToHoliday = false;
            foreach (Request overtimeRequest in overtimeRequests)
            {
                foreach (Holiday holiday in holidays)
                {

                    if (overtimeRequestDateIsJustARegularDay(overtimeRequest, holiday))
                    {
                    }
                    else if (overtimeDateIsEqualToNonRegularHoliday(overtimeRequest, holiday))
                    {
                        // add 30% of daily Salary
                        perHourBasedSalaryWithAddedPercent = perHourBasedSalary + decimal.Multiply(0.30M, perHourBasedSalary);
                        totalOvertimeSalary += decimal.Multiply(Convert.ToDateTime(overtimeRequest.requestedDate).Hour, perHourBasedSalaryWithAddedPercent);
                        decimal convertedMinToHour = decimal.Divide(Convert.ToDateTime(overtimeRequest.requestedDate).Minute, 59);
                        totalOvertimeSalary += decimal.Multiply(convertedMinToHour, perHourBasedSalaryWithAddedPercent);
                        isOvertimeDateFallsToHoliday = true;
                    }
                    else if (overtimeDateIsEqualToRegularHoliday(overtimeRequest, holiday))
                    {
                        // add 100% daily salary
                        perHourBasedSalaryWithAddedPercent = perHourBasedSalary + perHourBasedSalary;
                        totalOvertimeSalary += decimal.Multiply(Convert.ToDateTime(overtimeRequest.requestedDate).Hour, perHourBasedSalaryWithAddedPercent);
                        decimal convertedMinToHour = decimal.Divide(Convert.ToDateTime(overtimeRequest.requestedDate).Minute, 59);
                        totalOvertimeSalary += decimal.Multiply(convertedMinToHour, perHourBasedSalaryWithAddedPercent);
                        isOvertimeDateFallsToHoliday = true;
                    }
                }
                if (!isOvertimeDateFallsToHoliday)
                {
                    perHourBasedSalaryWithAddedPercent = perHourBasedSalary + decimal.Multiply(0.25M, perHourBasedSalary);
                    totalOvertimeSalary += decimal.Multiply(Convert.ToDateTime(overtimeRequest.requestedDate).Hour, perHourBasedSalaryWithAddedPercent);
                    decimal convertedMinToHour = decimal.Divide(Convert.ToDateTime(overtimeRequest.requestedDate).Minute, 59);
                    totalOvertimeSalary += decimal.Multiply(convertedMinToHour, perHourBasedSalaryWithAddedPercent);
                }
                else
                {
                    isOvertimeDateFallsToHoliday = false;
                }
            }
            return totalOvertimeSalary;
        }

        private static bool overtimeDateIsEqualToRegularHoliday(Request overtimeRequest, Holiday holiday)
        {
            return overtimeRequest.requestedDate.ToString("MM/dd/yyyy").Equals(holiday.date.ToString("MM/dd/yyyy")) && holiday.holidayWages == HolidayWages.Regular;
        }

        private static bool overtimeDateIsEqualToNonRegularHoliday(Request overtimeRequest, Holiday holiday)
        {
            return overtimeRequest.requestedDate.ToString("MM/dd/yyyy").Equals(holiday.date.ToString("MM/dd/yyyy")) && holiday.holidayWages == HolidayWages.NonRegular;
        }

        private static bool overtimeRequestDateIsJustARegularDay(Request overtimeRequest, Holiday holiday)
        {
            return !holiday.date.ToString("MM/dd/yyyy").Equals(overtimeRequest.requestedDate.ToString("MM/dd/yyyy")) && !overtimeRequest.requestedDate.DayOfWeek.ToString().Equals("Sunday");
        }

        public decimal calculateDailBasedSalaryWithLeaveRequest(List<Request> leaveRequests, decimal dailyBasedSalary)
        {
            List<Holiday> holidays = holidayService.fetchHolidays();
            decimal totalSalaryWithLeaveRequest = 0.00M;
            decimal perHourBasedSalary = 0.00M;
            perHourBasedSalary = decimal.Divide(dailyBasedSalary, 8.00M);
            foreach (Request leaveRequest in leaveRequests)
            {
                decimal calculatedSalaryWithHoursSpent = calculatePerHourSalaryFromHoursSpent(perHourBasedSalary, 8.00M);
                totalSalaryWithLeaveRequest += calculatedSalaryWithHoursSpent;
            }
            return totalSalaryWithLeaveRequest;
        }

        public decimal fetchTotalDeductions(List<Miscellaneous> deductions)
        {
            decimal totalDeductions = 0.00M;
            foreach (Miscellaneous deduction in deductions)
            {
                totalDeductions += deduction.amount;
            }
            return totalDeductions;
        }

        public decimal fetchTotalAmountOfBenefits(List<Miscellaneous> benefits, List<Attendance> attendances, List<Request> leaveRequests)
        {
            decimal totalAmountFromBenefits = 0.00M;
            foreach (Attendance attendance in attendances)
            {
                foreach (Miscellaneous benefit in benefits)
                {
                    totalAmountFromBenefits += benefit.amount;
                }
            }


            foreach (Request leaveRequest in leaveRequests)
            {
                foreach (Miscellaneous benefit in benefits)
                {
                    totalAmountFromBenefits += benefit.amount;
                }
            }
            return totalAmountFromBenefits;
        }

        public decimal fetchTotalBonus(List<Miscellaneous> bonuses)
        {
            decimal totalBonus = 0.00M;
            foreach (Miscellaneous bonus in bonuses)
            {
                totalBonus += bonus.amount;
            }

            return totalBonus;
        }

        public decimal calculatePeriodSalaryTax(Employee employee, decimal periodSalary)
        {
            decimal taxAmountToBeDeducted = 00.0M;
            if ((employee.civilStatus.Equals("Single") || employee.civilStatus.Equals("Married")) && employee.dependents == 0)
            {
                taxAmountToBeDeducted = fetchTaxCalculatedAmountForDeduction(periodSalary, SINGLE_MARRIED_LOWER_LIMIT, SINGLE_MARRIED_UPPER_LIMIT);
                Console.WriteLine(taxAmountToBeDeducted);
            }
            else if ((employee.civilStatus.Equals("Single") || employee.civilStatus.Equals("Married")) && employee.dependents == 1)
            {
                taxAmountToBeDeducted = periodSalary - fetchTaxCalculatedAmountForDeduction(periodSalary, SINGLE1_MARRIED1_LOWER_LIMIT, SINGLE1_MARRIED1_UPPER_LIMIT);
            }
            else if ((employee.civilStatus.Equals("Single") || employee.civilStatus.Equals("Married")) && employee.dependents == 2)
            {
                taxAmountToBeDeducted = periodSalary - fetchTaxCalculatedAmountForDeduction(periodSalary, SINGLE2_MARRIED2_LOWER_LIMIT, SINGLE2_MARRIED2_UPPER_LIMIT);
            }
            else if ((employee.civilStatus.Equals("Single") || employee.civilStatus.Equals("Married")) && employee.dependents == 3)
            {
                taxAmountToBeDeducted = periodSalary - fetchTaxCalculatedAmountForDeduction(periodSalary, SINGLE3_MARRIED3_LOWER_LIMIT, SINGLE3_MARRIED3_UPPER_LIMIT);
            }
            else if ((employee.civilStatus.Equals("Single") || employee.civilStatus.Equals("Married")) && employee.dependents == 4)
            {
                taxAmountToBeDeducted = periodSalary - fetchTaxCalculatedAmountForDeduction(periodSalary, SINGLE4_MARRIED4_LOWER_LIMIT, SINGLE4_MARRIED4_UPPER_LIMIT);
            }
            else if ((employee.civilStatus.Equals("Single") || employee.civilStatus.Equals("Married")) && employee.dependents > 4)
            {
                taxAmountToBeDeducted = periodSalary;
            }
            return taxAmountToBeDeducted;
        }

        private decimal fetchTaxCalculatedAmountForDeduction(decimal periodSalary, int lowerLimitIndex, int upperLimitIndex)
        {
            string fileName = "Tax_Table_Semi_Monthly.csv";
            
            return fetchDeductionAmount(periodSalary, lowerLimitIndex, upperLimitIndex, fileName);
        }

        private decimal fetchDeductionAmount(decimal periodSalary, int lowerLimitIndex, int upperLimitIndex, string fileName)
        {
            string directory = Path.Combine(Environment.CurrentDirectory, "Resources/" + fileName);
            directory = directory.Replace("\\", "/").Replace("/bin/Debug", "");
            directory = directory.Replace("\\", "/").Replace("/bin/Release", "");

            var reader = new StreamReader(File.OpenRead(@directory));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                decimal lowerLimitSalary = 0.00M;
                decimal upperLimitSalary = 0.00M;
                try
                {
                    lowerLimitSalary = Convert.ToDecimal(values[lowerLimitIndex].ToString());
                    upperLimitSalary = Convert.ToDecimal(values[upperLimitIndex].ToString());
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("error log:" + formatException.Message);
                    Console.WriteLine("-----------------------------------");
                }

                if (periodSalary >= lowerLimitSalary && periodSalary <= upperLimitSalary)
                {
                    decimal taxAmountToDeduct = Convert.ToDecimal(values[1].ToString());
                    decimal taxPercent = Convert.ToDecimal(values[0].ToString());
                    //Console.WriteLine(taxAmountToDeduct + "+" + "[(" + periodSalary + "-" + (upperLimitSalary - 1) + ")X" + taxPercent + "]");
                    taxAmountToDeduct += ((periodSalary - (upperLimitSalary - 1)) * taxPercent);

                    return taxAmountToDeduct;
                }
            }
            return 0.00M;
        }

        public decimal fetchSssDeductionsWithPeriodSalary(decimal periodSalary)
        {
            string fileName = "SSS_Table_Semi_Monthly.csv"; 
            string directory = Path.Combine(Environment.CurrentDirectory, "Resources/" + fileName);
            directory = directory.Replace("\\", "/").Replace("/bin/Debug", "");
            directory = directory.Replace("\\", "/").Replace("/bin/Release", "");

            var reader = new StreamReader(File.OpenRead(@directory));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                decimal lowerLimitSalary = 0.00M;
                decimal upperLimitSalary = 0.00M;
                try
                {
                    lowerLimitSalary = Convert.ToDecimal(values[0].ToString());
                    upperLimitSalary = Convert.ToDecimal(values[1].ToString());
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("error log:" + formatException.Message);
                    Console.WriteLine("-----------------------------------");
                }

                if (periodSalary >= lowerLimitSalary && periodSalary <= upperLimitSalary)
                {
                    return Convert.ToDecimal(values[2].ToString());
                }
            }
            return 0.00M;
        }

        public decimal fetchPagIbigDeductionWithPeriodSalary(decimal periodSalary)
        {
            return 100.00M;
        }

        public decimal fetchPhilHealthDeductionWithPeriodSalary(decimal periodSalary)
        {
            string fileName = "PhilHealt_Table_Semi_Monthly.csv";
            string directory = Path.Combine(Environment.CurrentDirectory, "Resources/" + fileName);
            directory = directory.Replace("\\", "/").Replace("/bin/Debug", "");
            directory = directory.Replace("\\", "/").Replace("/bin/Release", "");

            var reader = new StreamReader(File.OpenRead(@directory));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                decimal lowerLimitSalary = 0.00M;
                decimal upperLimitSalary = 0.00M;
                try
                {
                    lowerLimitSalary = Convert.ToDecimal(values[0].ToString());
                    upperLimitSalary = Convert.ToDecimal(values[1].ToString());
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("error log:" + formatException.Message);
                    Console.WriteLine("-----------------------------------");
                }

                if (periodSalary >= lowerLimitSalary && periodSalary <= upperLimitSalary)
                {
                    return Convert.ToDecimal(values[2].ToString());
                }
            }
            return 0.00M;
        }
    }
}
