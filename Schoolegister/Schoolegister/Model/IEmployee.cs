using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolegister.Model
{
    public interface IEmployee : IPerson
    {
        string Salary { get; set; }
        int Bank { get; set; }
        string BankAccount { get; set; }
        int Job { get; set; }
    }
}
