namespace UniversityApp
{
    partial class Form1
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
            this.pnlFirstLoginForm = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFirstLogIN = new System.Windows.Forms.Button();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbTeacher = new System.Windows.Forms.RadioButton();
            this.rdbStudent = new System.Windows.Forms.RadioButton();
            this.pnlFirstLoginForm.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFirstLoginForm
            // 
            this.pnlFirstLoginForm.BackColor = System.Drawing.Color.Firebrick;
            this.pnlFirstLoginForm.Controls.Add(this.btnLogin);
            this.pnlFirstLoginForm.Controls.Add(this.pnlLogin);
            this.pnlFirstLoginForm.Controls.Add(this.btnFirstLogIN);
            this.pnlFirstLoginForm.Controls.Add(this.rdbAdmin);
            this.pnlFirstLoginForm.Controls.Add(this.rdbTeacher);
            this.pnlFirstLoginForm.Controls.Add(this.rdbStudent);
            this.pnlFirstLoginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFirstLoginForm.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFirstLoginForm.Location = new System.Drawing.Point(0, 0);
            this.pnlFirstLoginForm.Name = "pnlFirstLoginForm";
            this.pnlFirstLoginForm.Size = new System.Drawing.Size(270, 453);
            this.pnlFirstLoginForm.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.Gold;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Firebrick;
            this.btnLogin.Location = new System.Drawing.Point(21, 339);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(225, 76);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.Password);
            this.pnlLogin.Controls.Add(this.txtIdentifier);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Location = new System.Drawing.Point(13, 186);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(236, 137);
            this.pnlLogin.TabIndex = 4;
            this.pnlLogin.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(8, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(225, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(4, 66);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Location = new System.Drawing.Point(8, 27);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(225, 27);
            this.txtIdentifier.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifier";
            // 
            // btnFirstLogIN
            // 
            this.btnFirstLogIN.AutoSize = true;
            this.btnFirstLogIN.BackColor = System.Drawing.Color.Gold;
            this.btnFirstLogIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstLogIN.ForeColor = System.Drawing.Color.Firebrick;
            this.btnFirstLogIN.Location = new System.Drawing.Point(156, 13);
            this.btnFirstLogIN.Name = "btnFirstLogIN";
            this.btnFirstLogIN.Size = new System.Drawing.Size(93, 150);
            this.btnFirstLogIN.TabIndex = 3;
            this.btnFirstLogIN.Text = "Choose";
            this.btnFirstLogIN.UseVisualStyleBackColor = false;
            this.btnFirstLogIN.Click += new System.EventHandler(this.btnFirstLogIN_Click);
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(13, 139);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(137, 24);
            this.rdbAdmin.TabIndex = 2;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "As The admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbTeacher
            // 
            this.rdbTeacher.AutoSize = true;
            this.rdbTeacher.Location = new System.Drawing.Point(12, 76);
            this.rdbTeacher.Name = "rdbTeacher";
            this.rdbTeacher.Size = new System.Drawing.Size(133, 24);
            this.rdbTeacher.TabIndex = 1;
            this.rdbTeacher.TabStop = true;
            this.rdbTeacher.Text = "As a teacher";
            this.rdbTeacher.UseVisualStyleBackColor = true;
            // 
            // rdbStudent
            // 
            this.rdbStudent.AutoSize = true;
            this.rdbStudent.Location = new System.Drawing.Point(13, 13);
            this.rdbStudent.Name = "rdbStudent";
            this.rdbStudent.Size = new System.Drawing.Size(134, 24);
            this.rdbStudent.TabIndex = 0;
            this.rdbStudent.TabStop = true;
            this.rdbStudent.Text = "As a Student";
            this.rdbStudent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 453);
            this.Controls.Add(this.pnlFirstLoginForm);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "Form1";
            this.Text = "Login Form";
            this.pnlFirstLoginForm.ResumeLayout(false);
            this.pnlFirstLoginForm.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFirstLoginForm;
        private System.Windows.Forms.Button btnFirstLogIN;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.RadioButton rdbTeacher;
        private System.Windows.Forms.RadioButton rdbStudent;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
    }
}

