using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolegister.Model
{
    public interface IEmployee : IPerson
    {
        decimal Salary { get; set; }
        string Bank { get; set; }
        string BankAccount { get; set; }
        string Job { get; set; }
    }
}
