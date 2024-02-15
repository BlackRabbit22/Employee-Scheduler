using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeScheduler
{
    /// <summary>
    ///  Class EmployeeManager creates, and handles EmployeeManager objects.
    /// </summary>
    internal class EmployeeManager
    {
        private List <Employee> employees;

        #region Constructors
        /// <summary>
        /// This constructor intializes the new <see cref="EmployeeManager"/> object.
        /// </summary>
        public EmployeeManager()
        {
            employees = new List <Employee>();
        }
        #endregion


        #region Methods
        /// <summary>
        /// Checks if <paramref name="index"/> is proper.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>A boolean value.</returns>
        private bool CheckIndex(int index)
        {
            bool result = true;

            if (index < 0 || employees.Count <= index)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Returns an <see cref="Employee"></see> object from a list based on its <paramref name="index"/>.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>A <see cref="Employee"/> object.</returns>
        public Employee GetEmployeeAt(int index)
        {
            if (CheckIndex(index))
            {
                Employee originalEmployeeObj = employees[index];
                Employee copyEmployeeObj = new Employee(originalEmployeeObj);

                return copyEmployeeObj;
            }

            return null;
        }

        /// <summary>
        /// Initializes a new <see cref="Employee"></see> object and adds it to a list.
        /// </summary>
        /// <returns>A boolean value.</returns>
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        /// <summary>
        /// Replaces <see cref="Employee"/> object in a list with another <see cref="Employee"/> object.
        /// </summary>
        /// <returns>A boolean value.</returns>
        public bool ChangeEmployeeAt(Employee employee, int index)
        {
            bool result = false;

            if (CheckIndex(index) && employee != null)
            {
                employees[index] = employee;
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Removes an <see cref="Employee"></see> from a list.
        /// </summary>
        /// <returns>A boolean value.</returns>
        public bool DeleteEmployeeAt(int index)
        {
            bool result = false;

            if (CheckIndex(index))
            {
                employees.RemoveAt(index);
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Converts an <see cref="Employee"/> list to an array containing <see cref="Employee"></see> values converted to a string.
        /// </summary>
        /// <returns>An array with string items.</returns>
        public string[] GetEmployees()
        {
            int i = 0;
            string[] employeeArr = new string[employees.Count];

            foreach (Employee employee in employees)
            {
                employeeArr[i++] = employee.ToString();
            }

            return employeeArr;
        }

        /// <summary>
        /// Reads employee data from a file.
        /// </summary>
        /// <returns>A boolean value.</returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();

            return fileManager.ReadTaskListFromFile(employees, fileName);
        }

        /// <summary>
        /// Writes employee data to a file.
        /// </summary>
        /// <returns>A boolean value.</returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();

            return fileManager.SaveTaskListToFile(employees, fileName);
        }
        #endregion
    }
}
