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
        public event EventHandler Employee_Modified;
        public event EventHandler Employee_Deleted;
        public event EventHandler Employee_Selected;

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

        public string Employee_Salary
        {
            get { return employee_Salary.Text; }
            set { employee_Salary.Text = value; }
        }
        public int Employee_Bank
        {
            get { return Convert.ToInt32(employee_Bank.Text); }
            set { employee_Bank.Text = Convert.ToString(value); }
        }
        public string Employee_BankAccount
        {
            get { return employee_BankAccount.Text; }
            set { employee_BankAccount.Text = value; }
        }
        public int Employee_Job
        {
            get { return Convert.ToInt32(employee_Job.Text); }
            set { employee_Job.Text = Convert.ToString(value); }
        }
        public string Employee_FirstName
        {
            get { return employee_FirstName.Text; }
            set { employee_FirstName.Text = value; }
        }
        public string Employee_LastName
        {
            get { return employee_LastName.Text; }
            set { employee_LastName.Text = value; }
        }
        public string Employee_BloodType
        {
            get { return employee_BloodType.Text; }
            set { employee_BloodType.Text = value; }
        }
        public string Employee_PhoneNumber
        {
            get { return employee_PhoneNumber.Text; }
            set { employee_PhoneNumber.Text = value; }
        }
        public string Employee_Curp
        {
            get { return employee_Curp.Text; }
            set { employee_Curp.Text = value; }
        }
        public string Employee_BirthDate
        {
            get { return employee_BirthDate.Text; }
            set { employee_BirthDate.Text = value; }
        }

        public string Employee_Address
        {
            get { return employee_Address.Text; }
            set { employee_Address.Text = value; }
        }
        public string Employee_Email
        {
            get { return employee_Email.Text; }
            set { employee_Email.Text = value; }
        }
        
        public int Employee_Id { get { return (int)employee_EmployeeGrid.SelectedRows[0].Cells[0].Value; } }

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

        private void Employee_ModifyClick(object sender, EventArgs e)
        {
            Employee_Modified(sender, e);
        }

        private void Employee_SelectedChanged(object sender, EventArgs e)
        {
            Employee_Salary = employee_EmployeeGrid.SelectedRows[0].Cells[1].Value as string;
            Employee_Bank = Convert.ToInt32(employee_EmployeeGrid.SelectedRows[0].Cells[2].Value);
            Employee_BankAccount = employee_EmployeeGrid.SelectedRows[0].Cells[3].Value as string;
            Employee_Job = Convert.ToInt32(employee_EmployeeGrid.SelectedRows[0].Cells[4].Value);
            Employee_FirstName = employee_EmployeeGrid.SelectedRows[0].Cells[5].Value as string;
            Employee_LastName = employee_EmployeeGrid.SelectedRows[0].Cells[6].Value as string;
            Employee_BloodType = employee_EmployeeGrid.SelectedRows[0].Cells[7].Value as string;
            Employee_PhoneNumber = employee_EmployeeGrid.SelectedRows[0].Cells[8].Value as string;
            Employee_Curp = employee_EmployeeGrid.SelectedRows[0].Cells[9].Value as string;
            Employee_BirthDate = employee_EmployeeGrid.SelectedRows[0].Cells[10].Value as string;
            Employee_Address = employee_EmployeeGrid.SelectedRows[0].Cells[11].Value as string;
            Employee_Email = employee_EmployeeGrid.SelectedRows[0].Cells[12].Value as string;
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

            courseGrid.Columns["Schedule"].Visible = false;
            courseGrid.Columns["ScheduleID"].Visible = false;
            courseGrid.Columns["ProfessorID"].Visible = false;
            courseGrid.Columns["Students"].Visible = false;
        }

        public void Course_LoadStudents(IEnumerable<Student> students)
        {
            studentGrid.DataSource = students.ToList();

            studentGrid.Columns["BloodType"].Visible = false;
            studentGrid.Columns["PhoneNumber"].Visible = false;
            studentGrid.Columns["Curp"].Visible = false;
            studentGrid.Columns["BirthDate"].Visible = false;
            studentGrid.Columns["Address"].Visible = false;
            studentGrid.Columns["Email"].Visible = false;
        }

        public int Course_GetStudentID()
        {
            return Course_StudentID;
        }

        public int Course_GetCourseID()
        {
            return Course_CourseID;
        }

        public Course Course_GetCourse()
        {
            return new Course
            {
                Code = Course_CourseCode,
                Name = Course_CourseName
            };
        }

        public Employee Employee_GetEmployee()
        {
            return new Employee
            {
                Id = Employee_Id,
                FirstName = Employee_FirstName,
                LastName = Employee_LastName,
                Curp = Employee_Curp,
                BirthDate = Employee_BirthDate,
                Address = Employee_Address,
                Email = Employee_Email,
                Bank = Employee_Bank,
                BankAccount = Employee_BankAccount,
                BloodType = Employee_BloodType,
                PhoneNumber = Employee_PhoneNumber,
                Job = Employee_Job,
                Salary = Employee_Salary
            };
        }
        public void Employee_LoadEmployees(IEnumerable<Employee> employees)
        {
            employee_EmployeeGrid.DataSource = employees.ToList();
        }
    }
}
