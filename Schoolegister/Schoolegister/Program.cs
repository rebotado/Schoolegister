using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schoolegister.View;
using Schoolegister.Repository;
using Schoolegister.Presenter;

namespace Schoolegister
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             var view = new LoginView();
             var repository = new UserRepository(new SchoolContext());
             var presenter = new LoginPresenter(view, repository);
             Application.Run(view);


        }
    }
}
