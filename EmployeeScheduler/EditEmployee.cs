using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeScheduler
{
    /// <summary>
    /// Class EditEmployee handles the GUI form for editing and making employees.
    /// </summary>
    internal partial class EditEmployee : Form
    {
        private Employee employee;
        public EditEmployee()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        //initializes input values on form load
        private void InitializeGUI()
        {
            if(employee == null)
            {
                monday_TextBox.Text = "No tasks";
                tuesday_TextBox.Text = "No tasks";
                wednesday_TextBox.Text = "No tasks";
                thursday_TextBox.Text = "No tasks";
                friday_TextBox.Text = "No tasks";
                saturday_TextBox.Text = "No tasks";
                sunday_TextBox.Text = "No tasks";
                month_ComboBox.DataSource = Enum.GetValues(typeof(Months));
                month_ComboBox.SelectedIndex = (int)Months.January;

            }

        }

        //sets input values if user is editing employee information
        public void EditGUI()
        {
            firstName_TextBox.Text = employee.FirstName;
            lastName_TextBox.Text = employee.LastName;
            address_TextBox.Text = employee.Contact.Address;
            phoneNumber_TextBox.Text = employee.Contact.Phone;
            month_ComboBox.DataSource = Enum.GetValues(typeof(Months));

            month_ComboBox.SelectedIndex = (int)employee.EmployeeSchedule.Month;

            monday_TextBox.Text = employee.EmployeeSchedule.Tasks[0];
            tuesday_TextBox.Text = employee.EmployeeSchedule.Tasks[1];
            wednesday_TextBox.Text = employee.EmployeeSchedule.Tasks[2];
            thursday_TextBox.Text = employee.EmployeeSchedule.Tasks[3];
            friday_TextBox.Text = employee.EmployeeSchedule.Tasks[4];
            saturday_TextBox.Text = employee.EmployeeSchedule.Tasks[5];
            sunday_TextBox.Text = employee.EmployeeSchedule.Tasks[6];
        }


        //checks to see if user input values are proper
        private bool EmployeeInformationCheck()
        {
            bool result = true;
            string firstName = firstName_TextBox.Text.Trim();
            string lastName = lastName_TextBox.Text.Trim();
            string phone = phoneNumber_TextBox.Text.Trim();
            string address = address_TextBox.Text.Trim();

            if (string.IsNullOrEmpty(firstName))
            {
                result = false;
                MessageBox.Show("First name field cannot be empty!", "Input Error");
            }
            else if (string.IsNullOrEmpty(lastName))
            {
                result = false;
                MessageBox.Show("Last name field cannot be empty!", "Input Error");
            }
            else if (string.IsNullOrEmpty(phone))
            {
                result = false;
                MessageBox.Show("Address field cannot be empty!", "Input Error");
            }
            else if (string.IsNullOrEmpty(address))
            {
                result = false;
                MessageBox.Show("Phone number field cannot be empty!", "Input Error");
            }

            return result;

        }

        //checks to see if user input values are proper
        private bool ScheduleInputCheck()
        {
            bool result = true;

            foreach (Control item in taskList_groupBox.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).Text == string.Empty)
                    {
                        result = false;
                        MessageBox.Show("Schedule fields cannot be empty!", "Input Error");
                        break;
                    }
                }
            }

            return result;
        }

        //reads input values for taks from user
        private bool ReadSchedule(ref Employee employee)
        {
            //add monthly schedule
            //add array
            //add week numbers
            bool result = false;
            if (EmployeeInformationCheck()&& ScheduleInputCheck())
            {
                List <string> dailyTasks = new List<string>();
                foreach (Control item in taskList_groupBox.Controls)
                {
                    if (item is TextBox)
                    {
                        string task = ((TextBox)item).Text.Trim();
                        dailyTasks.Add(task);
                    }
                }

                employee.EmployeeSchedule.Tasks=dailyTasks;
                employee.EmployeeSchedule.Month = (Months)month_ComboBox.SelectedItem;
                result = true;
            }
            return result;
        }

        //reads input values for employee information from user
        private bool ReadEmployee(ref Employee employee)
        {
            bool result = false;
            if (ReadSchedule(ref employee))
            {
                employee.FirstName = firstName_TextBox.Text.Trim();
                employee.LastName = lastName_TextBox.Text.Trim();
                employee.Contact.Phone = phoneNumber_TextBox.Text.Trim();
                employee.Contact.Address = address_TextBox.Text.Trim();
                result = true;
            }

            return result;
        }

        //save button event handler
        private void save_Button_Click(object sender, EventArgs e)
        {
            employee = new Employee();
            if (ReadEmployee(ref employee))
            {
                Close();

            }

        }

        //cancel button event handler
        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
