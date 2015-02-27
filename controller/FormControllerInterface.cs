﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.view;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public interface FormControllerInterface
    {
        void showDashboard(LoginForm loginForm, User user);

        void showUserPayroll(DashboardForm dashboardForm, User user);

        void showLoginWindow(LoginForm loginForm);

        void showEmployeeForm(AdminDashBoard adminDashboard);

        void showAdminDashBoard(AdminDashBoard adminDashboard);

        void showAdminDashBoard(AdminDashBoard adminDashboard, EmployeeForm employeeForm);

        void showDashboardForm(DashboardForm dashboardForm);

        void showEmployeeForm(AdminDashBoard adminDashBoard, Employee employee);

        void showUpdateUserForm(AdminDashBoard adminDashBoard, User user);

        void showAdminDashBoard(AdminDashBoard adminDashboard, UpdateUserForm updateUserForm);

        void showAdminDashBoardForPosition(AdminDashBoard adminDashboard, PositionForm positionForm);

        void showAdminDashBoardForMisc(AdminDashBoard adminDashboard, MiscellaneousForm miscForm);

        void showPositionForm(AdminDashBoard adminDashboard);

        void showMiscForm(AdminDashBoard adminDashboard);

        void index();

        void showLoginWindow(TimeInOutForm timeInOutForm);

        void closeTimeInOutForm(TimeInOutForm timeInOutForm);

        void closeLoginForm(LoginForm loginForm, TimeInOutForm timeInOutForm);

        void showLoginWindow(AdminDashBoard adminDashBoard, LoginForm loginForm);

        void showLoginWindow(DashboardForm dashboardForm, LoginForm login);

        void showRequestFormById(AdminDashBoard adminDashBoard, int requestId);

        void showAdminDashBoard(RequestForm requestForm, AdminDashBoard adminDashboard);

        void showDashboardForm(PayrollForm payrollForm, DashboardForm dashboardForm);

        void showUserPayroll(DashboardForm dashboardForm, Payslip payslip);

        void showUserPayroll(AdminDashBoard adminDashBoard, Payslip payslip);

        void showAdminDashboardForm(PayrollForm payrollForm, AdminDashBoard adminDashboardForm);

        void showDashboardForm(CashAdvanceForm cashAdvanceForm, DashboardForm dashboardForm);

        void showCashAdvanceForm(DashboardForm dashboardForm, Employee employee);

        void showAdminDashBoard(PayrollSheet payrollSheet);

        void showPayrollSheet();
    }
}
