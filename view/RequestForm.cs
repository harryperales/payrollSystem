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

        private void initializeForm(int requestId)
        {
            RequestServiceInterface requestService = new RequestService();
            Request request = requestService.fetchPendingRequestById(requestId);

            requestedBy.Text = request.employee.fullName;
            dateRequested.Text = request.dateRequested.ToString("MM/dd/yyyy");
            requestType.Text = request.name;
            status.Text = request.status.ToString();
            description.Text = request.description;
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
