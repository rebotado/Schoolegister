using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Schoolegister.Model;

namespace Schoolegister.View
{
    public partial class LoginView : MetroForm, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public string User { get { return "s"; } }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler LogIn;

        public void LoadUsers(IEnumerable<User> users)
        {
            throw new NotImplementedException();
        }

        public void LoginResult()
        {
            throw new NotImplementedException();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
