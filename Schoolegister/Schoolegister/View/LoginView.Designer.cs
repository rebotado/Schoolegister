namespace Schoolegister.View
{
    partial class LoginView
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
            this.userTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            // 
            // 
            // 
            this.userTextBox.CustomButton.Image = null;
            this.userTextBox.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.userTextBox.CustomButton.Name = "";
            this.userTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userTextBox.CustomButton.TabIndex = 1;
            this.userTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userTextBox.CustomButton.UseSelectable = true;
            this.userTextBox.CustomButton.Visible = false;
            this.userTextBox.Lines = new string[] {
        "rebotado"};
            this.userTextBox.Location = new System.Drawing.Point(303, 130);
            this.userTextBox.MaxLength = 32767;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.PasswordChar = '\0';
            this.userTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userTextBox.SelectedText = "";
            this.userTextBox.SelectionLength = 0;
            this.userTextBox.SelectionStart = 0;
            this.userTextBox.ShortcutsEnabled = true;
            this.userTextBox.Size = new System.Drawing.Size(147, 23);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.Text = "rebotado";
            this.userTextBox.UseSelectable = true;
            this.userTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.Lines = new string[] {
        "starwars12"};
            this.passwordTextBox.Location = new System.Drawing.Point(303, 184);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(147, 23);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "starwars12";
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(337, 237);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.Login);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.Shown += new System.EventHandler(this.LoginView_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox userTextBox;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroButton loginButton;
    }
}