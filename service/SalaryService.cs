using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public class SalaryService : SalaryServiceInterface
    {
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
            foreach (Attendance attendance in attendances)
            {
                TimeSpan breakTimeHour = Convert.ToDateTime("01:00:00") - Convert.ToDateTime("00:00:00");

                TimeSpan timeSpent = Convert.ToDateTime(attendance.timeOut.ToString("hh:mm:ss tt")) - Convert.ToDateTime(attendance.timeIn.ToString("hh:mm:ss tt"));

                timeSpent -= breakTimeHour;
                TimeSpan validTimeSpent = Convert.ToDateTime("08:00:00") - Convert.ToDateTime("00:00:00");

                // enforcing timeSpent to have an 8 hours only, if the user has an overtime, they should file an overtime request
                if (timeSpent > validTimeSpent)
                {
                    timeSpent = validTimeSpent;
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
                        periodSalary += decimal.Multiply(dailyBasedSalary, 0.30M); // add 30% of daily Salary
                    }
                    else if (holiday.holidayWages == HolidayWages.Regular)
                    {
                        periodSalary += dailyBasedSalary; // add 100% daily salary
                    }

                }
            }
            return periodSalary;
        }

        private decimal calculatePerHourSalaryFromHoursSpent(decimal perHourBasedSalary, decimal hour)
        {
            return decimal.Multiply(perHourBasedSalary, hour);
        }

        public decimal calculatePeriodSalaryWithOvertimeRequests(List<Request> overtimeRequests, decimal dailyBasedSalary)
        {
            decimal perHourBasedSalary = 0.00M;
            perHourBasedSalary = decimal.Divide(dailyBasedSalary, 8.00M);
            int numberOfApprovedOvertimeRequests = overtimeRequests.Count;
            decimal semiOvertimeTotalPercentage = decimal.Multiply(numberOfApprovedOvertimeRequests, 0.30M);
            decimal finalOvertimeTotalPercentage = decimal.Add(semiOvertimeTotalPercentage, 1.00M);
            decimal periodSalaryWithOvertime = decimal.Multiply(perHourBasedSalary, finalOvertimeTotalPercentage);
            return periodSalaryWithOvertime;
        }
    }
}
