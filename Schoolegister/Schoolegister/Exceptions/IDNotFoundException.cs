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

    public class ObjectExistsOnDB : Exception
    {
        public ObjectExistsOnDB(string message) : base(message) { }
    }
}
