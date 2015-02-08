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
        public PayrollForm(DashboardForm dashboardForm, User user)
        {
            this.user = user;
            this.dashboardForm = dashboardForm;
            InitializeComponent();
        }

        private void PayrollForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showDashboardForm(dashboardForm);
        }
    }
}
