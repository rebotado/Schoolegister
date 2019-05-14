﻿using System;
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
    public partial class MainView : MetroForm, IMainView
    {
        private readonly User userLogged;
        private readonly Dictionary<int, MetroTabPage> registerTabPages;
        public MainView(User userLogged)
        {
            this.userLogged = userLogged;
            InitializeComponent();
            registerTabPages = new Dictionary<int, MetroTabPage>();
            registerTabPages.Add(0, registerPage1);
            registerTabPages.Add(1, registerPage2);
            registerTabPages.Add(2, registerPage3);
            mainTabControl.HideTab(registerPage);
            registerTabControl.HideTab(registerPage2);
            registerTabControl.HideTab(registerPage3);
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

        private void MainView_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(userLogged.PermissionLevel);
            if (userLogged.PermissionLevel == (int)PermissionLevel.Admin)
            {
                mainTabControl.ShowTab(registerPage);
            }
            else if (userLogged.PermissionLevel == (int)PermissionLevel.Professor)
            {

            }
            else if (userLogged.PermissionLevel == (int)PermissionLevel.Student)
            {

            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var currentTab = registerTabControl.SelectedTab as MetroTabPage;
            var index = registerTabPages.FirstOrDefault(x => x.Value == currentTab).Key;
            registerTabControl.ShowTab(registerTabPages[index + 1]);
            registerTabControl.HideTab(registerTabPages[index]);
        }


        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
