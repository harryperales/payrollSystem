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
    public partial class PayrollSheet : Form
    {
        private DateTime startDatePeriod;
        private DateTime endDatePeriod;
        public PayrollSheet()
        {
            InitializeComponent();
            initializeDataGrid();
        }

        private void initializeDataGrid()
        {
            PayrollControllerInterface payrollController = new PayrollController();
            List<Payslip> payrollSheet = payrollController.fetchPayroll();
            payrollSheetDataGridView.DataSource = ConvertListToDataTable(payrollSheet);
        }

        private static DataTable ConvertListToDataTable(List<Payslip> payrollSheet)
        {
            // New table.
            DataTable table = new DataTable();
            // Add columns.
            table.Columns.Add("Date Created");
            table.Columns.Add("Employee Number");
            table.Columns.Add("Start Date");
            table.Columns.Add("End Date");
            table.Columns.Add("Base Pay");
            table.Columns.Add("Tax");
            table.Columns.Add("SSS");
            table.Columns.Add("Pag-Ibig");
            table.Columns.Add("PhilHealth");
            table.Columns.Add("13th Month Pay");
            table.Columns.Add("Net Pay");
            

            // Add rows.
            foreach (var payslip in payrollSheet)
            {
                Console.WriteLine(payslip.netPay);
	            table.Rows.Add(payslip.dateCreated, payslip.employee.employeeId, payslip.startDatePeriod,
                payslip.endDatePeriod, payslip.basePay, payslip.taxDeduction, payslip.sssDeduction, payslip.pagIbigDeduction,
                payslip.philHealthDeduction, payslip.thirteenMonthPay, payslip.netPay);
            }

            return table;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showAdminDashBoard(this);
        }
    }
}
