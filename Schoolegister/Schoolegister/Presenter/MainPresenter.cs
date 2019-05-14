using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.View;
using Schoolegister.Model;
using Schoolegister.Repository;

namespace Schoolegister.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView view;
        private readonly CourseRepository courseRepository;
        private readonly EmployeeRepository employeeRepository;
        private readonly ProfessorRepository professorRepository;
        private readonly ScheduleRepository scheduleRepository;
        private readonly StudentRepository studentRepository;

        public MainPresenter(IMainView view)
        {
            this.view = view;
            courseRepository = new CourseRepository();
            employeeRepository = new EmployeeRepository();
        }

    }
}
