using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using PayrollSystem.view;
using System.Windows.Forms;

namespace PayrollSystem.controller
{
    public class FormController : FormControllerInterface
    {

        public void index()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TimeInOutForm());
        }

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

        public void showAdminDashBoardForPosition(AdminDashBoard adminDashboard, PositionForm positionForm)
        {
            positionForm.Close();
            adminDashboard.Show();
        }

        public void showAdminDashBoardForMisc(AdminDashBoard adminDashboard, MiscellaneousForm miscForm)
        {
            miscForm.Close();
            adminDashboard.Show();
        }

        public void showPositionForm(AdminDashBoard adminDashboard)
        {
            PositionForm positionForm = new PositionForm(adminDashboard);
            positionForm.ShowDialog();
        }

        public void showMiscForm(AdminDashBoard adminDashboard)
        {
            MiscellaneousForm miscForm = new MiscellaneousForm(adminDashboard);
            miscForm.ShowDialog();
        }

        public void showLoginWindow(TimeInOutForm timeInOutForm)
        {
            LoginForm loginForm = new LoginForm(timeInOutForm);
            timeInOutForm.Hide();
            loginForm.ShowDialog();
        }

        public void closeTimeInOutForm(TimeInOutForm timeInOutForm)
        {
            timeInOutForm.Close();
        }

        public void closeLoginForm(LoginForm loginForm, TimeInOutForm timeInOutForm)
        {
            loginForm.Close();
            timeInOutForm.Show();
        }

        public void showLoginWindow(AdminDashBoard adminDashBoard, LoginForm loginForm)
        {
            adminDashBoard.Close();
            loginForm.Show();
        }

        public void showLoginWindow(DashboardForm dashboardForm, LoginForm login)
        {
            dashboardForm.Close();
            login.Show();
        }

        public void showRequestFormById(AdminDashBoard adminDashBoard, int requestId)
        {
            adminDashBoard.Hide();
            RequestForm requestForm = new RequestForm(adminDashBoard, requestId);
            requestForm.Show();
        }

        public void showAdminDashBoard(RequestForm requestForm, AdminDashBoard adminDashboard)
        {
            requestForm.Close();
            adminDashboard.loadPendingRequests();
            adminDashboard.loadApprovedRequests();
            adminDashboard.Show();
        }

        public void showDashboardForm(PayrollForm payrollForm, DashboardForm dashboardForm)
        {
            payrollForm.Close();
            dashboardForm.Show();
        }

        public void showUserPayroll(DashboardForm dashboardForm, Payslip payslip)
        {
            dashboardForm.Hide();
            PayrollForm payrollForm = new PayrollForm(dashboardForm, payslip);
            payrollForm.ShowDialog();
        }

        public void showUserPayroll(AdminDashBoard adminDashBoard, Payslip payslip)
        {
            adminDashBoard.Hide();
            PayrollForm payrollForm = new PayrollForm(adminDashBoard, payslip);
            payrollForm.ShowDialog();
        }

        public void showAdminDashboardForm(PayrollForm payrollForm, AdminDashBoard adminDashboardForm)
        {
            payrollForm.Close();
            adminDashboardForm.Show();
        }
    }
}
