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
using Schoolegister.Presenter;
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
                this.Hide();
                LoginUser();
            }
            else
            {
                MessageBox.Show("Usuario o contrase;a incorrectas");
            }
        }
        public void LoginUser()
        {
            switch (UserLogged.PermissionLevel)
            {
                case (int)PermissionLevel.Admin:
                    var view = new AdminView(UserLogged);
                    LoadMainForm(view);
                    break;
                case (int)PermissionLevel.Professor:
                    break;
                case (int)PermissionLevel.Student:
                    break;
            }
        }
        public void LoadMainForm(AdminView view)
        {
            var presenter = new AdminPresenter(view);
            view.Show();
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
