using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.View;
using Schoolegister.Model;
using System.Diagnostics;
using Schoolegister.Repository;

namespace Schoolegister.Presenter
{
    public class AdminPresenter
    {
        private readonly IAdminView view;
        private readonly CourseRepository courseRepository;
        private readonly EmployeeRepository employeeRepository;
        private readonly ProfessorRepository professorRepository;
        private readonly ScheduleRepository scheduleRepository;
        private readonly StudentRepository studentRepository;
        private readonly GradeRepository gradeRepository;
        private readonly CourseStudentsRepository courseStudentsRepository;
        private readonly UserRepository userRepository;

        public AdminPresenter(IAdminView view)
        {
            this.view = view;
            courseRepository = new CourseRepository();
            employeeRepository = new EmployeeRepository();
            professorRepository = new ProfessorRepository();
            scheduleRepository = new ScheduleRepository();
            studentRepository = new StudentRepository();
            gradeRepository = new GradeRepository();
            courseStudentsRepository = new CourseStudentsRepository();
            userRepository = new UserRepository();
            view.RegisterProfessor += RegisterProfessor;
            view.Course_CourseAdded += Courses_AddCourse;
            view.Course_CourseChanged += Courses_LoadStudents;
            view.Course_StudentAdded += Courses_AddStudentToCourse;
            LoadProfessors();
            Courses_LoadCourses();
        }
        public void RegisterProfessor(object sender, EventArgs e)
        {
            var professor = view.Register_GetProfessor();
            professorRepository.Add(professor);
            professorRepository.Save();
            LoadProfessors();
        }
        public void LoadProfessors()
        {
            var professors = professorRepository.GetAll().ToList();
            view.LoadProfessors(professors);
        }
        public void Courses_LoadCourses()
        {
            var courses = courseRepository.GetAll().ToList();
            view.Course_LoadCourses(courses);
        }
        public void Courses_LoadStudents(object sender, EventArgs e)
        {
            var courseID = view.Course_GetCourseID();
            var students = courseStudentsRepository.GetAll().ToList().Where(id => id.CourseID == courseID).Select(x => x.Student);
            view.Course_LoadStudents(students);
        }

        public void Courses_AddStudentToCourse(object sender, EventArgs e)
        {
            var studentID = view.Course_GetStudentID();
            var courseID = view.Course_GetCourseID();


            var courseStudent = new CourseStudents
            {
                StudentID = studentID,
                CourseID = courseID
            };
            courseStudentsRepository.Add(courseStudent);
            courseStudentsRepository.Save();
            Courses_LoadCourses();
            Courses_LoadStudents(sender, e);
        }

        public void Courses_AddCourse(object sender, EventArgs e)
        {
            var course = view.GetCourse();
            courseRepository.Add(course);
            courseRepository.Save();
            Courses_LoadCourses();
        }
    }
}
