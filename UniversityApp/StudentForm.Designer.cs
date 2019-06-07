namespace UniversityApp
{
    partial class StudentForm
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
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.pnlExam = new System.Windows.Forms.Panel();
            this.BtnNextQuestion = new System.Windows.Forms.Button();
            this.pnlAnswers = new System.Windows.Forms.Panel();
            this.rdbAnswerB = new System.Windows.Forms.RadioButton();
            this.rdbAnswerE = new System.Windows.Forms.RadioButton();
            this.rdbAnswerC = new System.Windows.Forms.RadioButton();
            this.rdbAnswerA = new System.Windows.Forms.RadioButton();
            this.rdbAnswerD = new System.Windows.Forms.RadioButton();
            this.BtnFinishExam = new System.Windows.Forms.Button();
            this.lblQuestionContent = new System.Windows.Forms.Label();
            this.pnlStudentProfile = new System.Windows.Forms.Panel();
            this.pnlEditProfile = new System.Windows.Forms.Panel();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.BtnOpenExams = new System.Windows.Forms.Button();
            this.pnlExamButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnExitAccount = new System.Windows.Forms.Button();
            this.BtnEditProfile = new System.Windows.Forms.Button();
            this.pnlStudent.SuspendLayout();
            this.pnlExam.SuspendLayout();
            this.pnlAnswers.SuspendLayout();
            this.pnlStudentProfile.SuspendLayout();
            this.pnlEditProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStudent
            // 
            this.pnlStudent.AutoSize = true;
            this.pnlStudent.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlStudent.Controls.Add(this.pnlExam);
            this.pnlStudent.Controls.Add(this.pnlStudentProfile);
            this.pnlStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStudent.Location = new System.Drawing.Point(0, 0);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(653, 444);
            this.pnlStudent.TabIndex = 0;
            // 
            // pnlExam
            // 
            this.pnlExam.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlExam.Controls.Add(this.BtnNextQuestion);
            this.pnlExam.Controls.Add(this.pnlAnswers);
            this.pnlExam.Controls.Add(this.BtnFinishExam);
            this.pnlExam.Controls.Add(this.lblQuestionContent);
            this.pnlExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExam.Location = new System.Drawing.Point(0, 171);
            this.pnlExam.Name = "pnlExam";
            this.pnlExam.Size = new System.Drawing.Size(653, 273);
            this.pnlExam.TabIndex = 1;
            this.pnlExam.Visible = false;
            // 
            // BtnNextQuestion
            // 
            this.BtnNextQuestion.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextQuestion.Location = new System.Drawing.Point(16, 181);
            this.BtnNextQuestion.Name = "BtnNextQuestion";
            this.BtnNextQuestion.Size = new System.Drawing.Size(115, 37);
            this.BtnNextQuestion.TabIndex = 9;
            this.BtnNextQuestion.Text = "Next";
            this.BtnNextQuestion.UseVisualStyleBackColor = false;
            this.BtnNextQuestion.Click += new System.EventHandler(this._questionNext);
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.Controls.Add(this.rdbAnswerB);
            this.pnlAnswers.Controls.Add(this.rdbAnswerE);
            this.pnlAnswers.Controls.Add(this.rdbAnswerC);
            this.pnlAnswers.Controls.Add(this.rdbAnswerA);
            this.pnlAnswers.Controls.Add(this.rdbAnswerD);
            this.pnlAnswers.Location = new System.Drawing.Point(16, 27);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Size = new System.Drawing.Size(552, 149);
            this.pnlAnswers.TabIndex = 8;
            // 
            // rdbAnswerB
            // 
            this.rdbAnswerB.AutoSize = true;
            this.rdbAnswerB.ForeColor = System.Drawing.Color.Tomato;
            this.rdbAnswerB.Location = new System.Drawing.Point(3, 29);
            this.rdbAnswerB.Name = "rdbAnswerB";
            this.rdbAnswerB.Size = new System.Drawing.Size(124, 23);
            this.rdbAnswerB.TabIndex = 2;
            this.rdbAnswerB.TabStop = true;
            this.rdbAnswerB.Text = "radioButton1";
            this.rdbAnswerB.UseVisualStyleBackColor = true;
            // 
            // rdbAnswerE
            // 
            this.rdbAnswerE.AutoSize = true;
            this.rdbAnswerE.ForeColor = System.Drawing.Color.Tomato;
            this.rdbAnswerE.Location = new System.Drawing.Point(3, 116);
            this.rdbAnswerE.Name = "rdbAnswerE";
            this.rdbAnswerE.Size = new System.Drawing.Size(124, 23);
            this.rdbAnswerE.TabIndex = 3;
            this.rdbAnswerE.TabStop = true;
            this.rdbAnswerE.Text = "radioButton1";
            this.rdbAnswerE.UseVisualStyleBackColor = true;
            // 
            // rdbAnswerC
            // 
            this.rdbAnswerC.AutoSize = true;
            this.rdbAnswerC.ForeColor = System.Drawing.Color.Tomato;
            this.rdbAnswerC.Location = new System.Drawing.Point(3, 58);
            this.rdbAnswerC.Name = "rdbAnswerC";
            this.rdbAnswerC.Size = new System.Drawing.Size(124, 23);
            this.rdbAnswerC.TabIndex = 4;
            this.rdbAnswerC.TabStop = true;
            this.rdbAnswerC.Text = "radioButton1";
            this.rdbAnswerC.UseVisualStyleBackColor = true;
            // 
            // rdbAnswerA
            // 
            this.rdbAnswerA.AutoSize = true;
            this.rdbAnswerA.ForeColor = System.Drawing.Color.Tomato;
            this.rdbAnswerA.Location = new System.Drawing.Point(3, 3);
            this.rdbAnswerA.Name = "rdbAnswerA";
            this.rdbAnswerA.Size = new System.Drawing.Size(124, 23);
            this.rdbAnswerA.TabIndex = 1;
            this.rdbAnswerA.TabStop = true;
            this.rdbAnswerA.Text = "radioButton1";
            this.rdbAnswerA.UseVisualStyleBackColor = true;
            // 
            // rdbAnswerD
            // 
            this.rdbAnswerD.AutoSize = true;
            this.rdbAnswerD.ForeColor = System.Drawing.Color.Tomato;
            this.rdbAnswerD.Location = new System.Drawing.Point(3, 87);
            this.rdbAnswerD.Name = "rdbAnswerD";
            this.rdbAnswerD.Size = new System.Drawing.Size(124, 23);
            this.rdbAnswerD.TabIndex = 5;
            this.rdbAnswerD.TabStop = true;
            this.rdbAnswerD.Text = "radioButton1";
            this.rdbAnswerD.UseVisualStyleBackColor = true;
            // 
            // BtnFinishExam
            // 
            this.BtnFinishExam.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnFinishExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinishExam.Location = new System.Drawing.Point(16, 224);
            this.BtnFinishExam.Name = "BtnFinishExam";
            this.BtnFinishExam.Size = new System.Drawing.Size(115, 37);
            this.BtnFinishExam.TabIndex = 7;
            this.BtnFinishExam.Text = "FinishExam";
            this.BtnFinishExam.UseVisualStyleBackColor = false;
            this.BtnFinishExam.Visible = false;
            this.BtnFinishExam.Click += new System.EventHandler(this.BtnFinishExam_Click);
            // 
            // lblQuestionContent
            // 
            this.lblQuestionContent.AutoSize = true;
            this.lblQuestionContent.Location = new System.Drawing.Point(12, 3);
            this.lblQuestionContent.Name = "lblQuestionContent";
            this.lblQuestionContent.Size = new System.Drawing.Size(155, 19);
            this.lblQuestionContent.TabIndex = 0;
            this.lblQuestionContent.Text = "lblQuestionContent";
            // 
            // pnlStudentProfile
            // 
            this.pnlStudentProfile.BackColor = System.Drawing.Color.Tomato;
            this.pnlStudentProfile.Controls.Add(this.pnlEditProfile);
            this.pnlStudentProfile.Controls.Add(this.BtnOpenExams);
            this.pnlStudentProfile.Controls.Add(this.pnlExamButtons);
            this.pnlStudentProfile.Controls.Add(this.BtnExitAccount);
            this.pnlStudentProfile.Controls.Add(this.BtnEditProfile);
            this.pnlStudentProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentProfile.ForeColor = System.Drawing.Color.NavajoWhite;
            this.pnlStudentProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentProfile.Name = "pnlStudentProfile";
            this.pnlStudentProfile.Size = new System.Drawing.Size(653, 171);
            this.pnlStudentProfile.TabIndex = 0;
            // 
            // pnlEditProfile
            // 
            this.pnlEditProfile.Controls.Add(this.BtnSaveChanges);
            this.pnlEditProfile.Controls.Add(this.label1);
            this.pnlEditProfile.Controls.Add(this.DtpBirthDate);
            this.pnlEditProfile.Controls.Add(this.txtPassword);
            this.pnlEditProfile.Controls.Add(this.txtFatherName);
            this.pnlEditProfile.Controls.Add(this.txtLastName);
            this.pnlEditProfile.Controls.Add(this.txtFirstName);
            this.pnlEditProfile.Location = new System.Drawing.Point(306, 3);
            this.pnlEditProfile.Name = "pnlEditProfile";
            this.pnlEditProfile.Size = new System.Drawing.Size(344, 146);
            this.pnlEditProfile.TabIndex = 5;
            this.pnlEditProfile.Visible = false;
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveChanges.Location = new System.Drawing.Point(6, 103);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(329, 37);
            this.BtnSaveChanges.TabIndex = 7;
            this.BtnSaveChanges.Text = "SAVE CHANGES";
            this.BtnSaveChanges.UseVisualStyleBackColor = false;
            this.BtnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Password:";
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.DtpBirthDate.Location = new System.Drawing.Point(178, 36);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(156, 24);
            this.DtpBirthDate.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtFatherName.Location = new System.Drawing.Point(3, 36);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(168, 24);
            this.txtFatherName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Location = new System.Drawing.Point(177, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(157, 24);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Location = new System.Drawing.Point(3, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 24);
            this.txtFirstName.TabIndex = 0;
            // 
            // BtnOpenExams
            // 
            this.BtnOpenExams.BackColor = System.Drawing.Color.Firebrick;
            this.BtnOpenExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenExams.Location = new System.Drawing.Point(4, 40);
            this.BtnOpenExams.Name = "BtnOpenExams";
            this.BtnOpenExams.Size = new System.Drawing.Size(118, 31);
            this.BtnOpenExams.TabIndex = 4;
            this.BtnOpenExams.Text = "Your Exams";
            this.BtnOpenExams.UseVisualStyleBackColor = false;
            this.BtnOpenExams.Click += new System.EventHandler(this.BtnOpenExams_Click);
            // 
            // pnlExamButtons
            // 
            this.pnlExamButtons.Location = new System.Drawing.Point(128, 3);
            this.pnlExamButtons.Name = "pnlExamButtons";
            this.pnlExamButtons.Size = new System.Drawing.Size(178, 146);
            this.pnlExamButtons.TabIndex = 3;
            this.pnlExamButtons.Visible = false;
            // 
            // BtnExitAccount
            // 
            this.BtnExitAccount.BackColor = System.Drawing.Color.Firebrick;
            this.BtnExitAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitAccount.Location = new System.Drawing.Point(4, 75);
            this.BtnExitAccount.Name = "BtnExitAccount";
            this.BtnExitAccount.Size = new System.Drawing.Size(118, 31);
            this.BtnExitAccount.TabIndex = 2;
            this.BtnExitAccount.Text = "Exit";
            this.BtnExitAccount.UseVisualStyleBackColor = false;
            this.BtnExitAccount.Click += new System.EventHandler(this.BtnExitAccount_Click);
            // 
            // BtnEditProfile
            // 
            this.BtnEditProfile.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditProfile.Location = new System.Drawing.Point(3, 3);
            this.BtnEditProfile.Name = "BtnEditProfile";
            this.BtnEditProfile.Size = new System.Drawing.Size(119, 31);
            this.BtnEditProfile.TabIndex = 0;
            this.BtnEditProfile.Text = "Edit";
            this.BtnEditProfile.UseVisualStyleBackColor = false;
            this.BtnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 444);
            this.Controls.Add(this.pnlStudent);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.pnlStudent.ResumeLayout(false);
            this.pnlExam.ResumeLayout(false);
            this.pnlExam.PerformLayout();
            this.pnlAnswers.ResumeLayout(false);
            this.pnlAnswers.PerformLayout();
            this.pnlStudentProfile.ResumeLayout(false);
            this.pnlEditProfile.ResumeLayout(false);
            this.pnlEditProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.Panel pnlExam;
        private System.Windows.Forms.Button BtnFinishExam;
        private System.Windows.Forms.RadioButton rdbAnswerD;
        private System.Windows.Forms.RadioButton rdbAnswerC;
        private System.Windows.Forms.RadioButton rdbAnswerE;
        private System.Windows.Forms.RadioButton rdbAnswerB;
        private System.Windows.Forms.RadioButton rdbAnswerA;
        private System.Windows.Forms.Label lblQuestionContent;
        private System.Windows.Forms.Panel pnlStudentProfile;
        private System.Windows.Forms.Panel pnlEditProfile;
        private System.Windows.Forms.Button BtnOpenExams;
        private System.Windows.Forms.FlowLayoutPanel pnlExamButtons;
        private System.Windows.Forms.Button BtnExitAccount;
        private System.Windows.Forms.Button BtnEditProfile;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSaveChanges;
        private System.Windows.Forms.Panel pnlAnswers;
        private System.Windows.Forms.Button BtnNextQuestion;
    }
}