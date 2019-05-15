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

        Course Course_GetCourse();

        #endregion CourseTab
        #region EmployeeTab

        event EventHandler Employee_Modified;
        event EventHandler Employee_Deleted;
        event EventHandler Employee_Selected;

        int Employee_Id { get; }
        string Employee_Salary { get; set; }
        int Employee_Bank { get; set; }
        string Employee_BankAccount { get; set; }
        int Employee_Job { get; set; }
        string Employee_FirstName { get; set; }
        string Employee_LastName { get; set; }
        string Employee_BloodType { get; set; }
        string Employee_PhoneNumber { get; set; }
        string Employee_Curp { get; set; }
        string Employee_BirthDate { get; set; }
        string Employee_Address { get; set; }
        string Employee_Email { get; set; }

        Employee Employee_GetEmployee();
        void Employee_LoadEmployees(IEnumerable<Employee> employees);

        #endregion EmployeeTab
        #region StudentTab

        event EventHandler Student_Modified;
        event EventHandler Student_Deleted;

        string Student_FirstName { get; set; }
        string Student_LastName { get; set; }
        string Student_Email { get; set; }
        string Student_Address { get; set; }
        string Student_Curp { get; set; }
        string Student_BirthDate { get; set; }
        string Student_BloodType { get; set; }
        string Student_PhoneNumber { get; set; }
        int Student_Id { get; set; }

        void Student_LoadStudents(IEnumerable<Student> students);
        Student Student_GetStudent();


        #endregion StudentTab
        #region ProfessorTab

        event EventHandler Professor_Modified;
        event EventHandler Professor_Deleted;

        int Professor_Id { get; set; }
        string Professor_Salary { get; set; }
        int Professor_Bank { get; set; }
        string Professor_BankAccount { get; set; }
        int Professor_Job { get; set; }
        string Professor_FirstName { get; set; }
        string Professor_LastName { get; set; }
        string Professor_BloodType { get; set; }
        string Professor_PhoneNumber { get; set; }
        string Professor_Curp { get; set; }
        string Professor_BirthDate { get; set; }
        string Professor_Address { get; set; }
        string Professor_Email { get; set; }

        void Professor_LoadProfessors(IEnumerable<Professor> professors);
        Professor Professor_GetProfessor()
;
        #endregion ProfessorTab






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
