using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.Model;

namespace Schoolegister.View
{
    public interface IAdminView
    {
        #region RegisterTab
        event EventHandler RegisterEmployee;
        event EventHandler RegisterProfessor;
        event EventHandler RegisteStudent;

        int UserType { get; set; }
        Employee Register_GetEmployee();
        Professor Register_GetProfessor();
        Student Register_GetStudent();
        #endregion RegisterTab
        #region CourseTab
        event EventHandler Course_StudentAdded;
        event EventHandler Course_CourseAdded;
        event EventHandler Course_CourseChanged;

        int Course_CourseID { get; }
        int Course_StudentID { get; }
        void Course_LoadCourses(IEnumerable<Course> courses);
        void Course_LoadStudents(IEnumerable<Student> students);

        int Course_GetStudentID();
        int Course_GetCourseID();

        string Course_CourseName { get; }
        string Course_CourseCode { get; }

        Course GetCourse();

        #endregion CourseTab



        void LoadProfessors(IEnumerable<Professor> professors);


        #region IPerson
        string Username { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string BloodType { get; set; }
        string PhoneNumber { get; set; }
        string Curp { get; set; }
        DateTime BirthDate { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        #endregion IPerson
        #region IEmployee
        decimal Salary { get; set; }
        string Bank { get; set; }
        string BankAccount { get; set; }
        string Job { get; set; }
        #endregion IEmployee

    }
}
