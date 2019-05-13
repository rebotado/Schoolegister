using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolegister.View
{
    public interface IAdminView
    {
        int UserType { get; set; }
        #region IPerson
        string Username { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string BloodType { get; set; }
        string PhoneNumber { get; set; }
        string Curp { get; set; }
        DateTime BirthDate { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        #endregion IPerson
        #region IEmployee
        decimal Salary { get; set; }
        string Bank { get; set; }
        string BankAccount { get; set; }
        string Job { get; set; }
        #endregion IEmployee

    }
}
