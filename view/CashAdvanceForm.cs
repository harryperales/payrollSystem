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
    public partial class CashAdvanceForm : Form
    {
        private DashboardForm dashboardForm;
        private Employee employee;
        public CashAdvanceForm(DashboardForm dashboardForm, Employee employee)
        {
            this.dashboardForm = dashboardForm;
            this.employee = employee;
            InitializeComponent();
        }

        private void initializeEmployeeInformation()
        {
            employeeName.Text = employee.fullName;
            employeeNumber.Text = employee.employeeId.ToString();
            dateFiled.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showDashboardForm(this, dashboardForm);
        }

        private void cashAdvanceButton_Click(object sender, EventArgs e)
        {
            decimal amount = 0.00M;
            try
            {
                amount = Convert.ToDecimal(cashAdvanceAmount.Text);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception:" + ex.Message);
                showErrorMessage("Please input a valid amount.");
                return;
            }

            if (requestDescription.Text.Equals(""))
            {
                showErrorMessage("Reason must not be empty.");
                return;
            }

            if (requestDescription.Text.Contains("@"))
            {
                showErrorMessage("Reason must not contain a @ character.");
                return;
            }

            RequestControllerInterface requestController = new RequestController();
            
            Request request = new Request();
            request.employee = employee;
            request.name = "CashAdvance";
            request.requestedDate = DateTime.Now;
            request.dateFiled = DateTime.Now;
            request.description = requestDescription.Text + " @" + amount.ToString();

            request = requestController.createCashAdvanceRequest(request);

            MessageBox.Show("Successfully create cash advance request.");
            FormControllerInterface formController = new FormController();
            formController.showDashboardForm(this, dashboardForm);
        }

        private void showErrorMessage(string errorMessage)
        {
            errorMessageLabel.Text = errorMessage;
            errorMessageLabel.Visible = true;
        }
    }
}
