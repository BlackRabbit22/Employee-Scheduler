using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeScheduler
{
    /// <summary>
    ///  Class EmployeeContact creates, and handles EmployeeContact objects.
    /// </summary>
    internal class EmployeeContact
    {
        private string phone;
        private string address;


        #region Constructors
        /// <summary>
        /// This constructor intializes the new <see cref="EmployeeContact"/> object.
        /// </summary>
        public EmployeeContact(string phone, string address)
        {
            this.phone = phone;
            this.address = address;
        }

        /// <inheritdoc cref="Employee.Employee"/> 
        public EmployeeContact() : this(string.Empty, string.Empty)
        {

        }

        /// <inheritdoc cref="Employee.Employee"/> 
        public EmployeeContact(EmployeeContact copyEmployeeContact) 
        { 
            this.Phone = copyEmployeeContact.Phone;
            this.Address = copyEmployeeContact.Address;
        }
        #endregion


        #region Properties
        /// <summary>
        /// Gets or sets the Phone for an <see cref="Employee"></see>.
        /// </summary>
        /// <returns>The phone number of an employee task.</returns>
        public string Phone
        {
            get { return phone; }
            set
            {
                if (value != null)
                {
                    phone = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the Address for an <see cref="Employee"></see>.
        /// </summary>
        /// <returns>The address of an employee task.</returns>
        public string Address
        {
            get { return address; }
            set 
            {
                if (value != null)
                {
                    address = value;
                }
            }
        }
        #endregion
    }
}
