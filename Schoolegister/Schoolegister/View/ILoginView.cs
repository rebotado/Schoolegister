using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;

namespace Schoolegister.View
{
    public delegate void Login();
    public interface ILoginView
    {
        event Login LoginIn;

        string User { get; }
        string Password { get; }
        bool LoginResult { get; set; }
        User UserLogged { get; set; }

        void Login(object sender, EventArgs e);
        User GetUser();
    }
}
