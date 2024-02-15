namespace EmployeeScheduler
{
    /// <summary>
    ///  Class MainForm handles GUI interaction.
    /// </summary>
    public partial class MainForm : Form
    {
        private EmployeeManager employeeManager;
        public MainForm()
        {
            InitializeComponent();
        }

        //updates the listbox items and empties the textbox for the
        //employee tasks
        public void UpdateGUI()
        {
            employeeSchedule_TextBox.Text = string.Empty;
            employees_ListBox.DataSource = employeeManager.GetEmployees();


        }

        //displays GUI elements
        private void ShowGUI()
        {
            newList_Button.Visible = false;
            openList_Button.Visible = false;
            newEmployee_Button.Visible = true;
            edit_Button.Visible = true;
            delete_Button.Visible = true;

            employees_Label.Visible = true;
            employeeSchedule_Label.Visible = true;
            month_Label.Visible = true;
            fullName_Label.Visible = true;
            phoneNumber_Label.Visible = true;

            employees_ListBox.Visible = true;
            employeeSchedule_TextBox.Visible = true;
        }


        //displays window to create new employee information
        private void newEmployee_Button_Click(object sender, EventArgs e)
        {
            EditEmployee editEmployee = new EditEmployee();
            editEmployee.Text = "New Employee";
            editEmployee.ShowDialog();
            if(editEmployee.Employee != null)
            {
                employeeManager.AddEmployee(editEmployee.Employee);

            }
            editEmployee.Dispose();
            UpdateGUI();
        }

        //creates a new employee list
        private void newList_Click(object sender, EventArgs e)
        {
            ShowGUI();
            employeeManager = new EmployeeManager();

        }

        //clear all input and create a new employee list
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGUI();
            employeeManager = new EmployeeManager();
            UpdateGUI();

        }

        //import employee schedule from a file
        private void openList_Button_Click(object sender, EventArgs e)
        {
            employeeManager = new EmployeeManager();
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Application.StartupPath;
            fileDialog.Title = "Open a Text File";
            fileDialog.Filter = "Text File|*.txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                employeeManager = new EmployeeManager();
                string errorMessage = "Could not open the file.";
                string filePath = fileDialog.FileName;
                bool result = employeeManager.ReadDataFromFile(filePath);
                if (!result)
                {
                    MessageBox.Show(errorMessage);
                    UpdateGUI();
                    ShowGUI();
                }
                else
                {
                    UpdateGUI();
                    ShowGUI();
                }
            }
        }

        //import employee schedule from a file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGUI();
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Application.StartupPath;
            fileDialog.Title = "Open a Text File";
            fileDialog.Filter = "Text File|*.txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                employeeManager = new EmployeeManager();
                string errorMessage = "Could not open the file.";
                string filePath = fileDialog.FileName;
                bool result = employeeManager.ReadDataFromFile(filePath);
                if (!result)
                {
                    MessageBox.Show(errorMessage);
                    UpdateGUI();
                }
                else
                {
                    UpdateGUI();
                }
            }
        }

        //display employee information when user selects an employee
        private void employees_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = employees_ListBox.SelectedIndex;
            Employee employee = employeeManager.GetEmployeeAt(index);
            employeeSchedule_TextBox.Text =
                "First Name: " + employee.FirstName + "\r\n" +
                "Last Name: " + employee.LastName + "\r\n" +
                "Address: " + employee.Contact.Address + "\r\n" +
                "Phone Number: " + employee.Contact.Phone + "\r\n" +
                "Month For Schedule: " + employee.EmployeeSchedule.Month + "\r\n\r\n" +
                "Schedule: \r\n" + employee.ScheduleToString();
        }

        //removes employee from list
        private void delete_Button_Click(object sender, EventArgs e)
        {
            if (employeeManager.GetEmployees().Length != 0)
            {
                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the selected employee?",
                "Delete selected employee?",
                MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        int index = employees_ListBox.SelectedIndex;

                        employeeManager.DeleteEmployeeAt(index);


                        UpdateGUI();
                    }
            }
        }

        //edits employee information
        private void edit_Button_Click(object sender, EventArgs e)
        {
            if (employeeManager.GetEmployees().Length != 0)
            {
                DialogResult result = MessageBox.Show(
                "Are you sure you want to change the selected employee?",
                "Change selected employee?",
                MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {

                        int index = employees_ListBox.SelectedIndex;
                        Employee employee = employeeManager.GetEmployeeAt(index);
                        EditEmployee editEmployee = new EditEmployee();

                        editEmployee.Employee = employee;
                        editEmployee.EditGUI();

                        editEmployee.Text = "Edit Employee";
                        editEmployee.ShowDialog();
                        employeeManager.ChangeEmployeeAt(editEmployee.Employee, index);

                        editEmployee.Dispose();
                        UpdateGUI();
                    }
            }
        }


        //exports employee information to a file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errorMessage = "Could not save the file.";
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Select a directory and name for the file";
            fileDialog.Filter = "Text File|*.txt";
            fileDialog.ShowDialog();
            string fileName = fileDialog.FileName;

            if (fileName != string.Empty)
            {
                bool result = employeeManager.WriteDataToFile(fileName);

                if (!result)
                {
                    MessageBox.Show(errorMessage);
                }
                else
                {
                    MessageBox.Show("Data saved to file:\n" + fileName, "File Saved!");
                }
            }

        }

        //displays software information form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        //exits software
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit Application", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}