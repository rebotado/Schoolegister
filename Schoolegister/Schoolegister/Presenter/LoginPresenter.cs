using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Repository;
using Schoolegister.View;
using Schoolegister.Model;
using System.Diagnostics;

namespace Schoolegister.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly UserRepository repository;

        public LoginPresenter(ILoginView view, UserRepository repository)
        {
            this.view = view;
            this.repository = repository;
            view.LoginIn += Login;
        }
        public void Login()
        {
            var users = repository.GetAll().ToList();
            var user = view.GetUser();
            foreach (var usr in users)
            {
                if (usr.Password == user.Password && usr.Username == user.Username)
                {
                    view.LoginResult = true;
                    view.UserLogged = user;
                    return;
                }
            }
            view.LoginResult = false;
        }

    }
}
