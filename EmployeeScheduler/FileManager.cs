using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeScheduler
{
    /// <summary>
    ///  Class FileManager handles file management.
    /// </summary>
    internal class FileManager
    {
        private const string fileVersionToken = "Employee_File";
        private const double fileVersionNr = 1.0;

        #region Methods
        /// <summary>
        /// Saves <see cref="Employee"/> list to a file.
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="fileName"></param>
        /// <returns>A bool statement.</returns>
        public bool SaveTaskListToFile(List<Employee> employees, string fileName)
        {
            bool result = true;

            StreamWriter writer = null;
            try
            {
                //Open file, and append file version and token to beginning of file
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(employees.Count);

                for (int i = 0; i < employees.Count; i++)
                {
                    Employee employee = employees[i];
                    //Write task values to file
                    writer.WriteLine(employee.FirstName);
                    writer.WriteLine(employee.LastName);
                    writer.WriteLine(employee.Contact.Address);
                    writer.WriteLine(employee.Contact.Phone);
                    writer.WriteLine(employee.EmployeeSchedule.Month);
                    List<string> tasks = employee.EmployeeSchedule.Tasks;
                    writer.WriteLine(tasks[0]);
                    writer.WriteLine(tasks[1]);
                    writer.WriteLine(tasks[2]);
                    writer.WriteLine(tasks[3]);
                    writer.WriteLine(tasks[4]);
                    writer.WriteLine(tasks[5]);
                    writer.WriteLine(tasks[6]);

                }
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }

            return result;
        }

        /// <summary>
        /// Opens a file containing <see cref="Employee"/> values.
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="fileName"></param>
        /// <returns>A bool statement.</returns>
        public bool ReadTaskListFromFile(List<Employee> employees, string fileName)
        {
            bool result = true;
            StreamReader reader = null;

            try
            {
                if (employees != null)
                {
                    employees.Clear();
                }
                else
                {
                    employees = new List<Employee>();
                }

                reader = new StreamReader(fileName);
                string versionTest = reader.ReadLine();
                double version = double.Parse(reader.ReadLine());

                //If file version, and token are correct, read contents of file
                if ((versionTest == fileVersionToken) && (version == fileVersionNr))
                {
                    int count = int.Parse(reader.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        Employee employee = new Employee();
                        employee.FirstName = reader.ReadLine();
                        employee.LastName = reader.ReadLine();
                        employee.Contact.Address = reader.ReadLine();
                        employee.Contact.Phone = reader.ReadLine();
                        employee.EmployeeSchedule.Month = (Months)Enum.Parse(typeof(Months), reader.ReadLine());
                        List<string> tasks = new List<string>();
                        tasks.Add(reader.ReadLine());
                        tasks.Add(reader.ReadLine());
                        tasks.Add(reader.ReadLine());
                        tasks.Add(reader.ReadLine());
                        tasks.Add(reader.ReadLine());
                        tasks.Add(reader.ReadLine());
                        tasks.Add(reader.ReadLine());
                        employee.EmployeeSchedule.Tasks = tasks;
                        employees.Add(employee);
                    }
                }

                else
                {
                    result = false;
                }
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return result;
        }
        #endregion

    }
}
