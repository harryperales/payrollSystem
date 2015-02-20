using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayrollSystem.controller;
using PayrollSystem.view;
using PayrollSystem.model;

namespace PayrollSystem.view
{
    public partial class MiscellaneousForm : Form
    {
        AdminDashBoard adminDashboard;
        Miscellaneous miscellaneous;

        public MiscellaneousForm(AdminDashBoard adminDashBoard)
        {
            this.adminDashboard = adminDashBoard;
            InitializeComponent();
        }

        public MiscellaneousForm(AdminDashBoard adminDashBoard, Miscellaneous misc)
        {
            this.adminDashboard = adminDashBoard;
            this.miscellaneous = misc;
            InitializeComponent();
            initializeMiscUpdateForm(misc);
        }

        private void initializeMiscUpdateForm(Miscellaneous misc)
        {
            Console.Write("Misc form another:" + misc.name);
            miscName.Text = misc.name;
            miscDescription.Text = misc.description;
            miscAmount.Text = Convert.ToString(misc.amount);
            // miscType.Text = misc.type;
            addMiscButton.Text = "Update";
        }

        private void addMiscButton_Click(object sender, EventArgs e)
        {
            MiscControllerInterface miscController = new MiscellaneousController();
            if (addMiscButton.Text == "Add")
            {
                if (miscName.Text != null && miscAmount.Text != null)
                {
                    Miscellaneous misc = new Miscellaneous();
                    misc.name = miscName.Text;
                    misc.description = miscDescription.Text;
                    misc.type = miscType.Text == "Benefits" ? MiscType.Benefits : MiscType.Deductions;
                    misc.amount = Convert.ToDecimal(miscAmount.Text);
                    miscController.addMisc(misc);
                    FormControllerInterface formController = new FormController();
                    formController.showAdminDashBoardForMisc(adminDashboard, this);
                }
            }
            else if (addMiscButton.Text == "Update")
            {
                miscellaneous.name = miscName.Text;
                miscellaneous.description = miscDescription.Text;
                miscellaneous.amount = Convert.ToDecimal(miscAmount.Text);
                miscellaneous.type = miscType.Text == "Benefits" ? MiscType.Benefits : MiscType.Deductions;
                if (miscController.updateMiscellaneous(miscellaneous) != null)
                {
                    MessageBox.Show("Successfully updated.");
                    FormControllerInterface formController = new FormController();
                    formController.showAdminDashBoardForMisc(adminDashboard, this);
                }
                else
                {
                    MessageBox.Show("Please try again, or contact the administrator.");
                }
            }
        }
    }
}
