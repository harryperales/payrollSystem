using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayrollSystem.controller;
using PayrollSystem.model;

namespace PayrollSystem.view
{
    public partial class EmployeeForm : Form
    {
        AdminDashBoard adminDashboard;
        Employee employee;

        public EmployeeForm(AdminDashBoard adminDashboard)
        {
            this.adminDashboard = adminDashboard;
            InitializeComponent();
            initializeDatePicker();
            initializeGender();
            initializeCivilStatus();
            initializeEmployeeId();
        }

        public EmployeeForm(AdminDashBoard adminDashboard, Employee employee)
        {
            this.adminDashboard = adminDashboard;
            this.employee = employee;
            InitializeComponent();
            initializeEmployeeForm(employee);
        }

        private void initializeEmployeeForm(Employee employee)
        {
            Console.WriteLine("another");
            employeeId.Text = employee.employeeId.ToString();
            username.Enabled = false;
            username.Text = employee.userAccount.username;
            password.Enabled = false;
            confirmPassword.Enabled = false;
            employee.fullName.Replace(",", "");
            char[] delimiterChars = {' '};
            string[] words = employee.fullName.Split(delimiterChars);
            lastname.Text = words[0];
            firstname.Text = words.Length > 0 ? words[1] : "";
            middlename.Text = words.Length > 1 ? words[2]:"";            
            birthdayTimePicker.Value = Convert.ToDateTime(employee.birthDate);
            genderComboBox.Text = employee.gender;
            positionComboBox.Text = employee.jobPosition.name;
            civilStatusComboBox.Text = employee.civilStatus;
            dependents.Text = employee.dependents.ToString();
            address.Text = employee.address;
            contactNumber.Text = employee.contactNumber;
            tin.Text = employee.tin;
            sssId.Text = employee.sssId;
            philHealthId.Text = employee.philHealthId;
            pagIbigId.Text = employee.pagIbigId;
            createEmployeeButton.Text = "Update";
        }

        private void initializeEmployeeId()
        {
            employeeId.Text = DateTime.Now.ToString("yymmddHHmmss");
        }

        private void initializeGender()
        {
            genderComboBox.Text = "Male";
        }

        private void initializeCivilStatus()
        {
            civilStatusComboBox.Text = "Single";
        }

        private void initializeDatePicker()
        {	
            birthdayTimePicker.MinDate = new DateTime(1950, 12, 6);
            birthdayTimePicker.MaxDate = DateTime.Today.AddYears(-15);            
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showAdminDashBoard(adminDashboard);
        }

        private Boolean checkUsernameIfExist(User user)
        {
            UserControllerInterface userController = new UserController();
            if (userController.fetchUserByUsername(user) != null)
            {                
                return false;
            }
            return true;
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeControllerInterface employeeController = new EmployeeController();
            if (createEmployeeButton.Text == "Create")
            {
                if (password.Text != confirmPassword.Text)
                {
                    MessageBox.Show("Password did not matched");
                    password.Text = "";
                    confirmPassword.Text = "";
                    return;
                }
                Employee employee = new Employee();
                employee.employeeId = Convert.ToInt64(employeeId.Text);
                employee.userAccount = new User();
                employee.userAccount.username = username.Text;                
                employee.userAccount.password = password.Text;

                if (checkUsernameIfExist(employee.userAccount))
                {
                    MessageBox.Show("Username is not available anymore, please create another username.");
                    return;
                }
                Role role = new Role();
                employee.userAccount.role = role;
                employee.userAccount.role.id = 2;
                employee.userAccount.role.type = "employee";
                employee.fullName = lastname.Text + ", " + firstname.Text + " " + middlename.Text;
                employee.birthDate = birthdayTimePicker.Text;
                employee.gender = genderComboBox.Text;
                employee.jobPosition = new Position();
                employee.jobPosition.id = 2;
                employee.jobPosition.name = positionComboBox.Text;
                employee.civilStatus = civilStatusComboBox.Text;
                try
                {
                    employee.dependents = Convert.ToInt32(dependents.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Dependents must be a number!");
                    return;
                }
                employee.address = address.Text;
                employee.contactNumber = contactNumber.Text;
                employee.tin = tin.Text;
                employee.sssId = sssId.Text;
                employee.philHealthId = philHealthId.Text;
                employee.pagIbigId = pagIbigId.Text;
                employee.dateEmployed = DateTime.Now.ToString();
                if (employeeController.saveEmployee(employee).id > 0)
                {
                    MessageBox.Show("Successfully added new employee.");
                    FormControllerInterface formController = new FormController();
                    formController.showAdminDashBoard(adminDashboard, this);
                }
                else
                {
                    MessageBox.Show("Please try again, or contact the administrator.");
                    password.Text = "";
                    confirmPassword.Text = "";
                }
            }
            else if (createEmployeeButton.Text == "Update")
            {
                employee.fullName = lastname.Text + ", " + firstname.Text + " " + middlename.Text;
                employee.birthDate = birthdayTimePicker.Text;
                employee.gender = genderComboBox.Text;
                employee.jobPosition.id = 2;
                employee.civilStatus = civilStatusComboBox.Text;
                try
                {
                    employee.dependents = Convert.ToInt32(dependents.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Dependents must be a number!");
                    return;
                }
                employee.address = address.Text;
                employee.contactNumber = contactNumber.Text;
                employee.tin = tin.Text;
                employee.sssId = sssId.Text;
                employee.philHealthId = philHealthId.Text;
                employee.pagIbigId = pagIbigId.Text;
                if (employeeController.updateEmployee(employee) != null)
                {
                    MessageBox.Show("Successfully updated employee.");
                    FormControllerInterface formController = new FormController();
                    formController.showAdminDashBoard(adminDashboard, this);
                }
                else
                {
                    MessageBox.Show("Please try again, or contact the administrator.");
                }
            }
        }
    }
}
