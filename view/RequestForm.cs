using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayrollSystem.service;
using PayrollSystem.model;
using PayrollSystem.controller;

namespace PayrollSystem.view
{
    public partial class RequestForm : Form
    {
        private AdminDashBoard adminDashboard;
        private int requestId;
        public RequestForm(AdminDashBoard adminDashboard, int requestId)
        {
            this.adminDashboard = adminDashboard;
            this.requestId = requestId;
            InitializeComponent();
            initializeForm(requestId);
        }

        private void hideOvertimeFields()
        {
            overtimeWorkHourLabel.Visible = false;
            overtimeWokingHour.Visible = false;
        }

        private void showOvertimeFields()
        {
            overtimeWorkHourLabel.Visible = true;
            overtimeWokingHour.Visible = true;
        }

        private void initializeForm(int requestId)
        {
            RequestServiceInterface requestService = new RequestService();
            Request request = requestService.fetchById(requestId);

            requestedBy.Text = request.employee.fullName.ToString();
            dateRequested.Text = request.dateFiled.ToString("MM/dd/yyyy");
            requestType.Text = request.name;
            status.Text = request.status.ToString();
            description.Text = request.description;

            if (!status.Text.Equals("Pending"))
            {
                approveButton.Visible = false;
                disapproveButton.Visible = false;
            }
            if (request.name.Equals("OVERTIME"))
            {
                overtimeWokingHour.Text = request.dateFiled.ToString("HH:mm");
                showOvertimeFields();
            }
            else if (request.name.Equals("CashAdvance"))
            {
                hideOvertimeFields();
                string[] descriptionAmount = request.description.Split('@');
                description.Text = descriptionAmount[0];
                cashAdvanceAmount.Text = descriptionAmount[1];
                cashAdvanceAmountLabel.Visible = true;
                cashAdvanceAmount.Visible = true;
            }
            else
            {
                hideOvertimeFields();
            }
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showAdminDashBoard(this, adminDashboard);
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            RequestControllerInterface requestController = new RequestController();
            requestController.updateRequestStatusById(requestId, "approved");

            FormControllerInterface formController = new FormController();
            formController.showAdminDashBoard(this, adminDashboard);
        }

        private void disapproveButton_Click(object sender, EventArgs e)
        {
            RequestControllerInterface requestController = new RequestController();
            requestController.updateRequestStatusById(requestId, "disapproved");

            FormControllerInterface formController = new FormController();
            formController.showAdminDashBoard(this, adminDashboard);
        }

    }
}
