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
        Position position;
        public PositionForm(AdminDashBoard adminDashboard)
        {
            this.adminDashboard = adminDashboard;
            InitializeComponent();
        }

        public PositionForm(AdminDashBoard adminDashboard, Position position)
        {
            this.adminDashboard = adminDashboard;
            this.position = position;
            InitializeComponent();
            initialPositionUpdatesForm(position);
        }

        private void createPositionButton_Click(object sender, EventArgs e)
        {
            PositionControllerInterface positionController = new PositionController();
            if (createPositionButton.Text == "Create Position")
            {
                if (positionName.Text != null && salary.Text != null)
                {
                    Position position = new Position();
                    position.name = positionName.Text;
                    position.salary = salary.Text;
                    positionController.addPosition(position);
                    FormControllerInterface formController = new FormController();
                    formController.showAdminDashBoardForPosition(adminDashboard, this);
                }
            }
            else if (createPositionButton.Text == "Update")
            {
                position.name = positionName.Text;
                position.salary = salary.Text;
                if (positionController.updatePosition(position) != null)
                {
                    MessageBox.Show("Successfully updated position.");
                    FormControllerInterface formController = new FormController();
                    formController.showAdminDashBoardForPosition(adminDashboard, this);
                }
                else
                {
                    MessageBox.Show("Please try again, or contact the administrator.");
                }
            }
        }

        private void initialPositionUpdatesForm(Position position)
        {
            positionName.Text = position.name;
            salary.Text = position.salary;
            createPositionButton.Text = "Update";
        }
    }
}
