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
        public MiscellaneousForm(AdminDashBoard adminDashBoard)
        {
            this.adminDashboard = adminDashBoard;
            InitializeComponent();
        }

        private void addMiscButton_Click(object sender, EventArgs e)
        {
            MiscellaneousControllerInterface miscController = new MiscellaneousController();
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
    }
}
