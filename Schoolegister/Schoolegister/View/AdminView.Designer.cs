namespace Schoolegister.View
{
    partial class AdminView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.registerPage = new System.Windows.Forms.TabPage();
            this.coursesPage = new System.Windows.Forms.TabPage();
            this.employeePage = new System.Windows.Forms.TabPage();
            this.studentsPage = new System.Windows.Forms.TabPage();
            this.professorsPage = new System.Windows.Forms.TabPage();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.registerPage);
            this.metroTabControl1.Controls.Add(this.coursesPage);
            this.metroTabControl1.Controls.Add(this.employeePage);
            this.metroTabControl1.Controls.Add(this.studentsPage);
            this.metroTabControl1.Controls.Add(this.professorsPage);
            this.metroTabControl1.Location = new System.Drawing.Point(34, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(743, 363);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // registerPage
            // 
            this.registerPage.Location = new System.Drawing.Point(4, 38);
            this.registerPage.Name = "registerPage";
            this.registerPage.Size = new System.Drawing.Size(735, 321);
            this.registerPage.TabIndex = 0;
            this.registerPage.Text = "Registrar";
            // 
            // coursesPage
            // 
            this.coursesPage.Location = new System.Drawing.Point(4, 38);
            this.coursesPage.Name = "coursesPage";
            this.coursesPage.Size = new System.Drawing.Size(735, 321);
            this.coursesPage.TabIndex = 1;
            this.coursesPage.Text = "Cursos";
            // 
            // employeePage
            // 
            this.employeePage.Location = new System.Drawing.Point(4, 38);
            this.employeePage.Name = "employeePage";
            this.employeePage.Size = new System.Drawing.Size(735, 321);
            this.employeePage.TabIndex = 2;
            this.employeePage.Text = "Empleados";
            // 
            // studentsPage
            // 
            this.studentsPage.Location = new System.Drawing.Point(4, 38);
            this.studentsPage.Name = "studentsPage";
            this.studentsPage.Size = new System.Drawing.Size(735, 321);
            this.studentsPage.TabIndex = 3;
            this.studentsPage.Text = "Estudiantes";
            // 
            // professorsPage
            // 
            this.professorsPage.Location = new System.Drawing.Point(4, 38);
            this.professorsPage.Name = "professorsPage";
            this.professorsPage.Size = new System.Drawing.Size(735, 321);
            this.professorsPage.TabIndex = 4;
            this.professorsPage.Text = "Profesores";
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage registerPage;
        private System.Windows.Forms.TabPage coursesPage;
        private System.Windows.Forms.TabPage employeePage;
        private System.Windows.Forms.TabPage studentsPage;
        private System.Windows.Forms.TabPage professorsPage;
    }
}