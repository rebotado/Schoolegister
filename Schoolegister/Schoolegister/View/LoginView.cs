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
using System.Diagnostics;

namespace Schoolegister.View
{
    public partial class LoginView : MetroForm, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public string User { get { return userTextBox.Text; } }
        public string Password { get { return passwordTextBox.Text; } }
        public bool LoginResult { get; set; }
        public User UserLogged { get; set; }

        public event Login LoginIn;


        public void Login(object sender, EventArgs e)
        {
            LoginIn();
            if (LoginResult)
            {
                var frm = new MainView(UserLogged);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contrase;a incorrectas");
            }
        }
        public User GetUser()
        {
            return new User
            {
                Username = this.User,
                Password = this.Password
            };
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void LoginView_Shown(object sender, EventArgs e)
        {
            Login(sender, e);
        }
    }
}
