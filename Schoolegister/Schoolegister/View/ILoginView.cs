using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;

namespace Schoolegister.View
{
    public interface ILoginView
    {
        event EventHandler LogIn;

        string User { get; set; }
        string Password { get; set; }

        void LoginResult();
        void LoadUsers(IEnumerable<User>  users);
    }
}
