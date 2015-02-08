using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using PayrollSystem.view;

namespace PayrollSystem.controller
{
    public class FormController : FormControllerInterface
    {

        public void showDashboard(LoginForm loginForm, User user)
        {
            if (user.role.type == "admin")
            {
                AdminDashBoard adminDashboardForm = new AdminDashBoard(loginForm, user);
                loginForm.Hide();
                adminDashboardForm.ShowDialog();
            }
            else
            {
                DashboardForm dashboardForm = new DashboardForm(loginForm, user);
                loginForm.Hide();
                dashboardForm.ShowDialog();
            }
        }

        public void showUserPayroll(DashboardForm dashboardForm, User user)
        {
            PayrollForm payrollForm = new PayrollForm(dashboardForm, user);
            dashboardForm.Hide();
            payrollForm.ShowDialog();
        }

        public void showLoginWindow(LoginForm loginForm)
        {
            loginForm.Show();
        }

        public void showEmployeeForm(AdminDashBoard adminDashBoard)
        {
            EmployeeForm employeeForm = new EmployeeForm(adminDashBoard);
            adminDashBoard.Hide();
            employeeForm.ShowDialog();
        }

        public void showAdminDashBoard(AdminDashBoard adminDashboard)
        {
            adminDashboard.loadUsers();
            adminDashboard.Show();
        }

        public void showAdminDashBoard(AdminDashBoard adminDashboard, EmployeeForm employeeForm)
        {
            employeeForm.Close();
            adminDashboard.Show();
        }

        public void showDashboardForm(DashboardForm dashboardForm)
        {
            dashboardForm.Show();
        }

        public void showEmployeeForm(AdminDashBoard adminDashBoard, Employee employee)
        {
            EmployeeForm employeeForm = new EmployeeForm(adminDashBoard, employee);
            employeeForm.ShowDialog();
        }

        public void showUpdateUserForm(AdminDashBoard adminDashBoard, User user)
        {
            UpdateUserForm updateUserForm = new UpdateUserForm(adminDashBoard, user);
            adminDashBoard.Hide();
            updateUserForm.ShowDialog();
        }

        public void showAdminDashBoard(AdminDashBoard adminDashboard, UpdateUserForm updateUserForm)
        {
            updateUserForm.Close();
            adminDashboard.Show();
        }
    }
}
