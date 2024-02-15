using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeScheduler
{
    /// <summary>
    ///  Class Employee creates, and handles Employee objects.
    /// </summary>
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private EmployeeContact contact;
        private EmployeeSchedule employeeSchedule;

        #region Constructors
        /// <summary>
        /// This constructor intializes the new <see cref="Employee"/> object.
        /// </summary>
        public Employee()
        {
            contact = new EmployeeContact();
            employeeSchedule = new EmployeeSchedule();
        }

        /// <inheritdoc cref="Employee.Employee"/> 
        public Employee(Employee copyEmployee)
        {
            firstName = copyEmployee.FirstName;
            lastName = copyEmployee.LastName;
            contact = copyEmployee.Contact;
            employeeSchedule = copyEmployee.EmployeeSchedule;
        }
        #endregion


        #region Properties
        /// <summary>
        /// Gets or sets the FirstName for an <see cref="Employee"></see>.
        /// </summary>
        /// <returns>The first name of an employee.</returns>
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value != null) {
                    firstName = value; }
            }
        }
        /// <summary>
        /// Gets or sets the LastName for an <see cref="Employee"></see>.
        /// </summary>
        /// <returns>The last name of an employee.</returns>
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value != null)
                {
                    lastName = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the Contact information for an <see cref="Employee"></see>.
        /// </summary>
        /// <returns>The contact information of an employee.</returns>
        public EmployeeContact Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        /// <summary>
        /// Gets or sets the Schedule information for an <see cref="Employee"></see>.
        /// </summary>
        /// <returns>The schedule information of an employee.</returns>
        public EmployeeSchedule EmployeeSchedule
        {
            get { return employeeSchedule; }
            set { employeeSchedule = value; }
        }
        #endregion


        #region Methods
        /// <summary>
        /// Formats the Month, FirstName, LastName, and Phone number of an <see cref="Employee"></see> to a string.
        /// </summary>
        /// <returns><see cref="Employee"></see> properties as a string.</returns>

        public override string ToString()
        {
            string strOut = string.Format("{0,-20} {1,-8} {2,-10} {3, 46}", 
                EmployeeSchedule.Month, FirstName, LastName, contact.Phone);
            return strOut;
        }

        /// <summary>
        /// Formats task list of of an <see cref="Employee"></see> to a string.
        /// </summary>
        /// <returns><see cref="Employee"></see> properties as a string.</returns>
        public string ScheduleToString()
        {
            string schedule = string.Empty;

            if(employeeSchedule.Tasks.Count > 0)
            {
                schedule =
                    "Monday: " + employeeSchedule.Tasks[0] + "\r\n" +
                    "Tuesday: " + employeeSchedule.Tasks[1] + "\r\n" +
                    "Wednesday: " + employeeSchedule.Tasks[2] + "\r\n" +
                    "Thursday: " + employeeSchedule.Tasks[3] + "\r\n" +
                    "Friday: " + employeeSchedule.Tasks[4] + "\r\n" +
                    "Saturday: " + employeeSchedule.Tasks[5] + "\r\n" +
                    "Sunday: " + employeeSchedule.Tasks[6] + "\r\n";
            }
            return schedule;
        }
        #endregion
    }


}
