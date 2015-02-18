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
    public partial class PayrollForm : Form
    {
        User user;
        DashboardForm dashboardForm;
        private Payslip payslip;
        public PayrollForm(DashboardForm dashboardForm, User user)
        {
            this.user = user;
            this.dashboardForm = dashboardForm;
            InitializeComponent();
        }

        public PayrollForm(DashboardForm dashboardForm, Payslip payslip)
        {
            this.payslip = payslip;
            this.dashboardForm = dashboardForm;
            InitializeComponent();
            initializeForm(payslip);
        }

        private void initializeForm(Payslip payslip)
        {
            employeeFullName.Text = payslip.employee.fullName;
        }

        private void PayrollForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showDashboardForm(dashboardForm);
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showDashboardForm(this, dashboardForm);
        }
    }
}
