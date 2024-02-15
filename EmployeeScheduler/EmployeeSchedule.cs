using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeScheduler
{
    /// <summary>
    ///  Class EmployeeSchedule creates, and handles EmployeeSchedule objects.
    /// </summary>
    internal class EmployeeSchedule
    {
        private List<string> tasks;
        private Months month;


        #region Constructors
        /// <summary>
        /// This constructor intializes the new <see cref="EmployeeSchedule"/> object.
        /// </summary>
        public EmployeeSchedule()
        {
            tasks = new List<string>();
            this.month = month;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the Month for an <see cref="Employee"></see>.
        /// </summary>
        /// <returns>The month of an employee task.</returns>
        public Months Month
        {
            get { return month; }
            set { month = value; }
        }

        /// <summary>
        /// Gets or sets the Task list for an <see cref="Employee"></see>.
        /// </summary>
        /// <returns>The task list of an employee.</returns>
        public List<string> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }
        #endregion
    }
}
