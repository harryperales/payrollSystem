using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using PayrollSystem.service;

namespace PayrollSystem.controller
{
    public class LeaveCreditsController : LeaveCreditsControllerInteface
    {
        private LeaveCreditServiceInterface leaveCreditService;
        private int VACATION_LEAVE_CREDITS = 12;
        private int SICK_LEAVE_CREDITS = 12;
        private int PATERNITY_LEAVE_CREDITS = 7;
        private int EMERGENCY_LEAVE_CREDITS = 3;
        private int BIRTHDAY_LEAVE_CREDITS = 1;
        private int BEREAVEMENT_LEAVE_CREDITS = 3;

        public LeaveCreditsController(LeaveCreditServiceInterface leaveCreditService)
        {
            this.leaveCreditService = leaveCreditService;
        }

        public LeaveCreditsController()
        {
            leaveCreditService = new LeaveCreditService();
        }

        public EmployeeLeaveCredits resetEmployeeLeaveCredits(Employee employee)
        {
            LeaveCredits leaveCredits = new LeaveCredits();
            leaveCredits.vacationLeaveCredits = VACATION_LEAVE_CREDITS;
            leaveCredits.sickLeaveCredits = SICK_LEAVE_CREDITS;
            leaveCredits.paternityLeaveCredits = PATERNITY_LEAVE_CREDITS;
            leaveCredits.emergencyLeaveCredits = EMERGENCY_LEAVE_CREDITS;
            leaveCredits.birthdayLeaveCredits = BIRTHDAY_LEAVE_CREDITS;
            leaveCredits.bereavementLeaveCredits = BEREAVEMENT_LEAVE_CREDITS;
            return leaveCreditService.updateEmployeeLeaveCredits(employee, leaveCredits);
        }

        public LeaveCredits fetchLeaveCreditsByEmployee(Employee employee)
        {
            return leaveCreditService.fetchLeaveCreditsByEmployee(employee);
        }
    }
}
