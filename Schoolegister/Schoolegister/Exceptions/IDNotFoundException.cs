using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolegister.Exceptions
{
    class IDNotFoundException : Exception
    {
        public IDNotFoundException(string message) : base(message) { }
    }

    public class StudentExistsOnList : Exception
    {
        public StudentExistsOnList(string message) : base(message) { }
    }
}
