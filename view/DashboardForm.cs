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
            PayrollControllerInterface payrollController = new PayrollController();
            List<Payroll> payrolls = payrollController.fetchUserPayrolls(user);
            loadPayrollList(payrolls);
        }

        private void loadPayrollList(List<Payroll> payrolls)
        {
            userPayrollListBox.Items.Clear();
            foreach(Payroll payroll in payrolls)
            {
                userPayrollListBox.Items.Add(payroll.startDate + "-" + payroll.endDate);
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
            FormControllerInterface formController = new FormController();
            formController.showUserPayroll(this, user);
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showLoginWindow(login);
        }
    }
}
