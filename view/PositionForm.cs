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
            loadPosition();
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
                MessageBox.Show("Successfully added.");
                FormControllerInterface formController = new FormController();
                formController.showAdminDashBoardForPosition(adminDashboard, this);
            }
        }

        public void loadPosition()
        {
            positionComboBox.Items.Clear();
            PositionControllerInterface positionController = new PositionController();
            List<Position> positions = positionController.viewAllPosition();
            foreach (Position position in positions)
            {
                positionComboBox.Items.Add(position.name);
                if (positionComboBox.SelectedIndex == -1) positionComboBox.Text = position.name;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Position position = new Position();
            PositionControllerInterface positionController = new PositionController();
            Console.WriteLine(positionComboBox.Text);
            position = positionController.fetchPositionByName(positionComboBox.Text);
            try
            {
                position.salary = Convert.ToDecimal(updateSalary.Text);
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Please input a valid Salary.");
                return;
            }

            positionController.updatePosition(position);
            MessageBox.Show("Successfully updated");
            FormControllerInterface formController = new FormController();
            formController.showAdminDashBoardForPosition(adminDashboard, this);
            
        }
    }
}
