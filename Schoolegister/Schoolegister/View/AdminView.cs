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
using MetroFramework.Controls;
using System.Diagnostics;
using Schoolegister.Model;

namespace Schoolegister.View
{
    public partial class AdminView : MetroForm, IAdminView
    {
        private readonly User userLogged;
        private readonly Dictionary<int, MetroTabPage> registerTabPages;

        public event EventHandler RegisterEmployee;
        public event EventHandler RegisterProfessor;
        public event EventHandler RegisteStudent;
        public event EventHandler Course_StudentAdded;
        public event EventHandler Course_CourseAdded;
        public event EventHandler Course_CourseChanged;

        public AdminView(User userLogged)
        {
            this.userLogged = userLogged;
            InitializeComponent();
            registerTabPages = new Dictionary<int, MetroTabPage>();
            registerTabPages.Add(0, registerPage1);
            registerTabPages.Add(1, registerPage2);
            registerTabPages.Add(2, registerPage3);
        }

        public int UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BloodType { get; set; }
        public string PhoneNumber { get; set; }
        public string Curp { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string Bank { get; set; }
        public string BankAccount { get; set; }
        public string Job { get; set; }
        public int Course_CourseID { get { return (int)courseGrid.SelectedRows[0].Cells[0].Value; } }
        public int Course_StudentID { get { return Convert.ToInt32(studentCNBox.Text); } }

        public string Course_CourseName { get { return courseNameBox.Text; } }

        public string Course_CourseCode { get { return courseCodeBox.Text; } }

        private void AdminView_Load(object sender, EventArgs e)
        {
            registerTabControl.HideTab(registerTabPages[1]);
            registerTabControl.HideTab(registerTabPages[2]);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var currentTab = registerTabControl.SelectedTab as MetroTabPage;
            var index = registerTabPages.FirstOrDefault(x => x.Value == currentTab).Key;
            registerTabControl.ShowTab(registerTabPages[index + 1]);
            registerTabControl.HideTab(registerTabPages[index]);
        }

        private void RegisterProfessor_Click(object sender, EventArgs e)
        {
            RegisterProfessor(sender, e);
        }
        private void RegisterCourse_Click(object sender, EventArgs e)
        {
            Course_CourseAdded(sender, e);
        }
        private void StudentAddedToCourse_Click(object sender, EventArgs e)
        {
            Course_StudentAdded(sender, e);
        }
        private void SelectedCourse_Changed(object sender, EventArgs e)
        {
            Course_CourseChanged(sender, e);
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public Employee Register_GetEmployee()
        {
            return new Employee()
            {
                Salary = salaryBox.Text,
                Bank = Convert.ToInt32(bankBox.Text),
                BankAccount = bankaccountBox.Text,
                Job = Convert.ToInt32(jobBox.Text),
                FirstName = nameBox.Text,
                LastName = lastNameBox.Text,
                BloodType = bloodBox.Text,
                PhoneNumber = phoneBox.Text,
                Curp = curpBox.Text,
                BirthDate = birthdateBox.Text,
                Address = addressBox.Text,
                Email = mailBox.Text,
            };
        }
        public Professor Register_GetProfessor()
        {
            return new Professor()
            {
                Salary = salaryBox.Text,
                Bank = Convert.ToInt32(bankBox.Text),
                BankAccount = bankaccountBox.Text,
                Job = Convert.ToInt32(jobBox.Text),
                FirstName = nameBox.Text,
                LastName = lastNameBox.Text,
                BloodType = bloodBox.Text,
                PhoneNumber = phoneBox.Text,
                Curp = curpBox.Text,
                BirthDate = birthdateBox.Text,
                Address = addressBox.Text,
                Email = mailBox.Text,
                User = Register_GetUser()
            };
        }
        public Student Register_GetStudent()
        {
            return default(Student);
        }
        public User Register_GetUser()
        {
            return new User
            {
                Username = usernameBox.Text,
                Password = passwordBox.Text
            };
        }


        public void LoadProfessors(IEnumerable<Professor> professors)
        {
            metroGrid1.DataSource = professors.ToList();
        }

        public void Course_LoadCourses(IEnumerable<Course> courses)
        {
            courseGrid.DataSource = courses.ToList();
        }

        public void Course_LoadStudents(IEnumerable<Student> students)
        {
            studentGrid.DataSource = students.ToList();
        }

        public int Course_GetStudentID()
        {
            return Course_StudentID;
        }

        public int Course_GetCourseID()
        {
            return Course_CourseID;
        }

        public Course GetCourse()
        {
            return new Course
            {
                Code = Course_CourseCode,
                Name = Course_CourseName
            };
        }
    }
}
