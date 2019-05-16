﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schoolegister.View;
using Schoolegister.Model;
using System.Diagnostics;
using Schoolegister.Repository;
using Schoolegister.Exceptions;

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
            view.Employee_Modified += Employee_EmployeeModified;
            view.Student_Modified += Student_StudentModified;
            view.Professor_Modified += Professor_ProfessorModified;
            Professor_LoadProfessors();
            Courses_LoadCourses();
            Employee_LoadEmployees();
            Student_LoadStudents();
        }
        public void RegisterProfessor(object sender, EventArgs e)
        {
            var professor = view.Register_GetProfessor();
            professorRepository.Add(professor);
            professorRepository.Save();
            Professor_LoadProfessors();
        }
        public void Professor_LoadProfessors()
        {
            var professors = professorRepository.GetAll().ToList();
            view.Professor_LoadProfessors(professors);
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
            if(studentRepository.GetByID(studentID) == null | courseRepository.GetByID(courseID) == null)
            {
                throw (new IDNotFoundException($"Id not found in database"));
            }
            else if(courseStudentsRepository.GetAll().Where(x => x.StudentID == studentID) != null)
            {
                throw (new StudentExistsOnList("Student already exists on list"));
            }

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
            var course = view.Course_GetCourse();
            courseRepository.Add(course);
            courseRepository.Save();
            Courses_LoadCourses();
        }

        public void Employee_LoadEmployees()
        {
            var employees = employeeRepository.GetAll().ToList();
            view.Employee_LoadEmployees(employees);
        }


        public void Employee_EmployeeModified(object sender, EventArgs e)
        {
            var employee = view.Employee_GetEmployee();
            employeeRepository.Update(employee);
            employeeRepository.Save();
            Employee_LoadEmployees();
        }

        public void Student_LoadStudents()
        {
            var students = studentRepository.GetAll().ToList();
            view.Student_LoadStudents(students);
        }


        public void Student_StudentModified(object sender, EventArgs e)
        {
            var student = view.Student_GetStudent();
            studentRepository.Update(student);
            studentRepository.Save();
            Student_LoadStudents();
        }

        public void Professor_ProfessorModified(object sender, EventArgs e)
        {
            var professor = view.Professor_GetProfessor();
            professorRepository.Update(professor);
            professorRepository.Save();
            Professor_LoadProfessors();
        }
    }
}
