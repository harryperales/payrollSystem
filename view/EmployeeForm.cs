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
            initializedEmploymentDate(DateTime.Now);
            loadPosition();
        }

        private void initializeAllowance()
        {
            MiscControllerInterface miscellaneousController = new MiscellaneousController();
            Miscellaneous foodAllowanceBenefits = miscellaneousController.fetchMiscellaneousBenefitByNameAndEmployee(employee, "FoodAllowance");
            Miscellaneous transpoAllowanceBenefits = miscellaneousController.fetchMiscellaneousBenefitByNameAndEmployee(employee, "TransportationAllowance");

            foodAllowance.Text = foodAllowanceBenefits.amount.ToString("0.##");
            transpoAllowance.Text = transpoAllowanceBenefits.amount.ToString("0.##");
        }

        private void initializedEmploymentDate(DateTime dateEmployed)
        {
            employmentDate.Text = dateEmployed.ToString("MM/dd/yyyy");
        }
        private void initializeDependents()
        {
            dependents.Text = "0";
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

        public EmployeeForm(AdminDashBoard adminDashboard, Employee employee)
        {
            this.adminDashboard = adminDashboard;
            this.employee = employee;
            InitializeComponent();
            initializedEmploymentDate(Convert.ToDateTime(employee.dateEmployed));
            initializeEmployeeForm(employee);
            initializeAllowance();
        }

        private void initializeEmployeeForm(Employee employee)
        {
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
            Console.WriteLine(user.username);
            UserControllerInterface userController = new UserController();
            User existingUser = userController.fetchUserByUsername(user);
            Console.WriteLine(existingUser);
            if ( existingUser == null || existingUser.ToString().Equals(""))
            {                
                return false;
            }
            return true;
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeControllerInterface employeeController = new EmployeeController();
            if(username.Text.Equals(""))
            {
                MessageBox.Show("Username cannot be empty.");
                return;
            }

            if (firstname.Text.Equals(""))
            {
                MessageBox.Show("Firstname cannot be empty.");
                return;
            }

            if (middlename.Text.Equals(""))
            {
                MessageBox.Show("Middlename cannot be empty.");
                return;
            }

            if (lastname.Text.Equals(""))
            {
                MessageBox.Show("Lastname cannot be empty.");
                return;
            }

            if (foodAllowance.Text.Equals(""))
            {
                MessageBox.Show("Food Allowance cannot be empty.");
                return;
            }

            if (transpoAllowance.Text.Equals(""))
            {
                MessageBox.Show("Transpo Allowance cannot be empty.");
                return;
            }

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
                employee.jobPosition.id = positionComboBox.SelectedIndex;
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

                decimal foodAllowanceAmount = 0.00M;
                decimal transpoAllowanceAmount = 0.00M;
                try
                {
                    foodAllowanceAmount = Convert.ToDecimal(foodAllowance.Text);
                    transpoAllowanceAmount = Convert.ToDecimal(transpoAllowance.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Allowance amount must be a number!");
                    return;
                }

                if (employeeController.saveEmployee(employee).id > 0)
                {
                    Miscellaneous foodAllowanceBenefits = new Miscellaneous();
                    foodAllowanceBenefits.name = "FoodAllowance";
                    foodAllowanceBenefits.description = "Food Allowance";
                    foodAllowanceBenefits.amount = foodAllowanceAmount;
                    foodAllowanceBenefits.type = MiscType.Benefits;

                    Miscellaneous transpoAllowanceBenefits = new Miscellaneous();
                    transpoAllowanceBenefits.name = "TransportationAllowance";
                    transpoAllowanceBenefits.description = "Transportation Allowance";
                    transpoAllowanceBenefits.amount = transpoAllowanceAmount;
                    transpoAllowanceBenefits.type = MiscType.Benefits;

                    MiscControllerInterface miscellaneousController = new MiscellaneousController();
                    foodAllowanceBenefits = miscellaneousController.addMiscByEmployee(foodAllowanceBenefits, employee);
                    transpoAllowanceBenefits = miscellaneousController.addMiscByEmployee(transpoAllowanceBenefits, employee);

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
                employee.jobPosition.id = positionComboBox.SelectedIndex;
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

                decimal foodAllowanceAmount = 0.00M;
                decimal transpoAllowanceAmount = 0.00M;
                try
                {
                    foodAllowanceAmount = Convert.ToDecimal(foodAllowance.Text);
                    transpoAllowanceAmount = Convert.ToDecimal(transpoAllowance.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Allowance amount must be a number!");
                    return;
                }

                if (employeeController.updateEmployee(employee) != null)
                {
                    MiscControllerInterface miscellaneousController = new MiscellaneousController();

                    Miscellaneous foodAllowanceBenefits = miscellaneousController.fetchMiscellaneousBenefitByNameAndEmployee(employee, "FoodAllowance");
                    foodAllowanceBenefits.amount = foodAllowanceAmount;

                    Miscellaneous transpoAllowanceBenefits = miscellaneousController.fetchMiscellaneousBenefitByNameAndEmployee(employee, "TransportationAllowance");
                    transpoAllowanceBenefits.amount = transpoAllowanceAmount;

                    foodAllowanceBenefits = miscellaneousController.updateMiscellaneousBenefitAmountById(foodAllowanceBenefits);
                    foodAllowanceBenefits = miscellaneousController.updateMiscellaneousBenefitAmountById(transpoAllowanceBenefits);

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

        private void positionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox positionComboBox = sender as ComboBox;
            PositionControllerInterface positionController = new PositionController();
            if (positionComboBox.SelectedIndex != -1)
            {
                Console.WriteLine(positionComboBox.SelectedItem.ToString());
                Position position = positionController.fetchPositionByName(positionComboBox.SelectedItem.ToString());
                salary.Text = position.salary.ToString();
            }
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showAdminDashBoard(adminDashboard, this);
        }
    }
}
