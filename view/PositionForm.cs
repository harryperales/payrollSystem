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
    public partial class PositionForm : Form
    {
        AdminDashBoard adminDashboard;
        public PositionForm(AdminDashBoard adminDashboard)
        {
            this.adminDashboard = adminDashboard;
            InitializeComponent();
        }

        private void createPositionButton_Click(object sender, EventArgs e)
        {
            PositionControllerInterface positionController = new PositionController();
            if (positionName.Text != null && salary.Text != null) {
                Position position = new Position();
                position.name = positionName.Text;
                try
                {
                    position.salary = Convert.ToDecimal(salary.Text);
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Please input a valid Salary.");
                    return;
                }
                positionController.addPosition(position);
                FormControllerInterface formController = new FormController();
                formController.showAdminDashBoardForPosition(adminDashboard, this);
            }
        }
    }
}
