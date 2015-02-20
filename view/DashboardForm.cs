using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayrollSystem.model;
using PayrollSystem.controller;

namespace PayrollSystem.view
{
    public partial class DashboardForm : Form
    {
        LoginForm login;
        User user;
        public DashboardForm(LoginForm login, User user)
        {
            this.login = login;
            this.user = user;
            InitializeComponent();
            username.Text = user.username;
            loadPayrollList();
        }

        private void loadPayrollList()
        {
            PayrollControllerInterface payrollController = new PayrollController();
            List<Payslip> payroll = payrollController.fetchUserPayrolls(user);
            userPayrollListBox.Items.Clear();
            foreach(Payslip payslip in payroll)
            {
                userPayrollListBox.Items.Add(payslip.id+".)"+payslip.startDatePeriod.ToString("MM/dd/yyyy") + "-" + payslip.endDatePeriod.ToString("MM/dd/yyyy"));
            }
        }

        private void userPayrollListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                userPayrollListBox.SelectedIndex = l.SelectedIndex;
                Console.WriteLine(userPayrollListBox.SelectedItem.ToString());
            }
        }

        private void viewPayrollButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                int payslipId = Convert.ToInt32(userPayrollListBox.SelectedItem.ToString().Split('.')[0]);
                PayrollControllerInterface payrollController = new PayrollController();
                Payslip payslip = payrollController.fetchPayslipById(payslipId);

                EmployeeControllerInterface employeeController = new EmployeeController();
                payslip.employee = employeeController.fetchEmployeeByUsername(user.username);

                FormControllerInterface formController = new FormController();
                formController.showUserPayroll(this, payslip);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("No item selected: " + ex.Message);
            //}
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showLoginWindow(login);
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showLoginWindow(this, login);
        }
    }
}
