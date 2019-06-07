namespace UniversityApp
{
    partial class TeacherForm
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
            this.pnlTeacherProfile = new System.Windows.Forms.Panel();
            this.PnlEditProfile = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.TxtEditFatherName = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.DtpEditBirthDate = new System.Windows.Forms.DateTimePicker();
            this.TxtEditLastName = new System.Windows.Forms.TextBox();
            this.TxtEditFirstName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditTeacherInfo = new System.Windows.Forms.Button();
            this.lblTeacherProfile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.pnlTeacherFunctions = new System.Windows.Forms.Panel();
            this.pnlGradeGiving = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpScoreDate = new System.Windows.Forms.DateTimePicker();
            this.btnGiveGrade = new System.Windows.Forms.Button();
            this.nmScore = new System.Windows.Forms.NumericUpDown();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.pnlTeacherProfile.SuspendLayout();
            this.PnlEditProfile.SuspendLayout();
            this.pnlTeacherFunctions.SuspendLayout();
            this.pnlGradeGiving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTeacherProfile
            // 
            this.pnlTeacherProfile.AutoSize = true;
            this.pnlTeacherProfile.BackColor = System.Drawing.Color.DimGray;
            this.pnlTeacherProfile.Controls.Add(this.PnlEditProfile);
            this.pnlTeacherProfile.Controls.Add(this.btnExit);
            this.pnlTeacherProfile.Controls.Add(this.btnEditTeacherInfo);
            this.pnlTeacherProfile.Controls.Add(this.lblTeacherProfile);
            this.pnlTeacherProfile.Controls.Add(this.label2);
            this.pnlTeacherProfile.Controls.Add(this.label1);
            this.pnlTeacherProfile.Controls.Add(this.cmbGroups);
            this.pnlTeacherProfile.Controls.Add(this.cmbSubjects);
            this.pnlTeacherProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTeacherProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlTeacherProfile.Name = "pnlTeacherProfile";
            this.pnlTeacherProfile.Size = new System.Drawing.Size(650, 501);
            this.pnlTeacherProfile.TabIndex = 0;
            // 
            // PnlEditProfile
            // 
            this.PnlEditProfile.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.PnlEditProfile.Controls.Add(this.label5);
            this.PnlEditProfile.Controls.Add(this.txtPassword);
            this.PnlEditProfile.Controls.Add(this.TxtEditFatherName);
            this.PnlEditProfile.Controls.Add(this.btnSaveChanges);
            this.PnlEditProfile.Controls.Add(this.DtpEditBirthDate);
            this.PnlEditProfile.Controls.Add(this.TxtEditLastName);
            this.PnlEditProfile.Controls.Add(this.TxtEditFirstName);
            this.PnlEditProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlEditProfile.Location = new System.Drawing.Point(187, 55);
            this.PnlEditProfile.Name = "PnlEditProfile";
            this.PnlEditProfile.Size = new System.Drawing.Size(450, 87);
            this.PnlEditProfile.TabIndex = 7;
            this.PnlEditProfile.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "New Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(133, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(176, 23);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // TxtEditFatherName
            // 
            this.TxtEditFatherName.Location = new System.Drawing.Point(4, 33);
            this.TxtEditFatherName.Name = "TxtEditFatherName";
            this.TxtEditFatherName.Size = new System.Drawing.Size(153, 23);
            this.TxtEditFatherName.TabIndex = 8;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.DimGray;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSaveChanges.Location = new System.Drawing.Point(315, 3);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(132, 82);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "SAVE CHANGES";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // DtpEditBirthDate
            // 
            this.DtpEditBirthDate.Location = new System.Drawing.Point(158, 33);
            this.DtpEditBirthDate.Name = "DtpEditBirthDate";
            this.DtpEditBirthDate.Size = new System.Drawing.Size(150, 23);
            this.DtpEditBirthDate.TabIndex = 2;
            // 
            // TxtEditLastName
            // 
            this.TxtEditLastName.Location = new System.Drawing.Point(158, 3);
            this.TxtEditLastName.Name = "TxtEditLastName";
            this.TxtEditLastName.Size = new System.Drawing.Size(150, 23);
            this.TxtEditLastName.TabIndex = 1;
            // 
            // TxtEditFirstName
            // 
            this.TxtEditFirstName.Location = new System.Drawing.Point(4, 3);
            this.TxtEditFirstName.Name = "TxtEditFirstName";
            this.TxtEditFirstName.Size = new System.Drawing.Size(153, 23);
            this.TxtEditFirstName.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(16, 88);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 54);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnEditTeacherInfo
            // 
            this.btnEditTeacherInfo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEditTeacherInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTeacherInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTeacherInfo.Location = new System.Drawing.Point(16, 31);
            this.btnEditTeacherInfo.Name = "btnEditTeacherInfo";
            this.btnEditTeacherInfo.Size = new System.Drawing.Size(138, 50);
            this.btnEditTeacherInfo.TabIndex = 5;
            this.btnEditTeacherInfo.Text = "Edit Your Infos";
            this.btnEditTeacherInfo.UseVisualStyleBackColor = false;
            this.btnEditTeacherInfo.Click += new System.EventHandler(this.BtnEditTeacher_Click);
            // 
            // lblTeacherProfile
            // 
            this.lblTeacherProfile.AutoSize = true;
            this.lblTeacherProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherProfile.Location = new System.Drawing.Point(12, 9);
            this.lblTeacherProfile.Name = "lblTeacherProfile";
            this.lblTeacherProfile.Size = new System.Drawing.Size(187, 19);
            this.lblTeacherProfile.TabIndex = 4;
            this.lblTeacherProfile.Text = "LabelForTeacherName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "GroupsYouTeach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(499, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subjects You Teach";
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(378, 28);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(105, 21);
            this.cmbGroups.TabIndex = 1;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.CmbGroups_SelectedIndexChanged);
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(502, 28);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(135, 21);
            this.cmbSubjects.TabIndex = 0;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.CmbSubjects_SelectedIndexChanged);
            // 
            // pnlTeacherFunctions
            // 
            this.pnlTeacherFunctions.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnlTeacherFunctions.Controls.Add(this.pnlGradeGiving);
            this.pnlTeacherFunctions.Controls.Add(this.dgwStudents);
            this.pnlTeacherFunctions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTeacherFunctions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTeacherFunctions.Location = new System.Drawing.Point(0, 174);
            this.pnlTeacherFunctions.Name = "pnlTeacherFunctions";
            this.pnlTeacherFunctions.Size = new System.Drawing.Size(650, 327);
            this.pnlTeacherFunctions.TabIndex = 1;
            // 
            // pnlGradeGiving
            // 
            this.pnlGradeGiving.Controls.Add(this.label4);
            this.pnlGradeGiving.Controls.Add(this.label3);
            this.pnlGradeGiving.Controls.Add(this.DtpScoreDate);
            this.pnlGradeGiving.Controls.Add(this.btnGiveGrade);
            this.pnlGradeGiving.Controls.Add(this.nmScore);
            this.pnlGradeGiving.Controls.Add(this.lblStudentName);
            this.pnlGradeGiving.Location = new System.Drawing.Point(3, 165);
            this.pnlGradeGiving.Name = "pnlGradeGiving";
            this.pnlGradeGiving.Size = new System.Drawing.Size(276, 150);
            this.pnlGradeGiving.TabIndex = 1;
            this.pnlGradeGiving.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(71, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grade";
            // 
            // DtpScoreDate
            // 
            this.DtpScoreDate.Location = new System.Drawing.Point(75, 55);
            this.DtpScoreDate.Name = "DtpScoreDate";
            this.DtpScoreDate.Size = new System.Drawing.Size(192, 27);
            this.DtpScoreDate.TabIndex = 8;
            // 
            // btnGiveGrade
            // 
            this.btnGiveGrade.BackColor = System.Drawing.Color.DimGray;
            this.btnGiveGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveGrade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveGrade.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.btnGiveGrade.Location = new System.Drawing.Point(7, 85);
            this.btnGiveGrade.Name = "btnGiveGrade";
            this.btnGiveGrade.Size = new System.Drawing.Size(260, 43);
            this.btnGiveGrade.TabIndex = 7;
            this.btnGiveGrade.Text = "Grade";
            this.btnGiveGrade.UseVisualStyleBackColor = false;
            this.btnGiveGrade.Click += new System.EventHandler(this.BtnGiveGrade_Click);
            // 
            // nmScore
            // 
            this.nmScore.Location = new System.Drawing.Point(7, 55);
            this.nmScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmScore.Name = "nmScore";
            this.nmScore.Size = new System.Drawing.Size(52, 27);
            this.nmScore.TabIndex = 3;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.ForeColor = System.Drawing.Color.DimGray;
            this.lblStudentName.Location = new System.Drawing.Point(3, 10);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(58, 19);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "label3";
            // 
            // dgwStudents
            // 
            this.dgwStudents.AllowUserToResizeColumns = false;
            this.dgwStudents.AllowUserToResizeRows = false;
            this.dgwStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.Location = new System.Drawing.Point(0, 3);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.Size = new System.Drawing.Size(647, 156);
            this.dgwStudents.TabIndex = 0;
            this.dgwStudents.Visible = false;
            this.dgwStudents.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgwStudents_RowHeaderMouseDoubleClick);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 501);
            this.Controls.Add(this.pnlTeacherFunctions);
            this.Controls.Add(this.pnlTeacherProfile);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.pnlTeacherProfile.ResumeLayout(false);
            this.pnlTeacherProfile.PerformLayout();
            this.PnlEditProfile.ResumeLayout(false);
            this.PnlEditProfile.PerformLayout();
            this.pnlTeacherFunctions.ResumeLayout(false);
            this.pnlGradeGiving.ResumeLayout(false);
            this.pnlGradeGiving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTeacherProfile;
        private System.Windows.Forms.Label lblTeacherProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Panel pnlTeacherFunctions;
        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.Button btnEditTeacherInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlGradeGiving;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnGiveGrade;
        private System.Windows.Forms.NumericUpDown nmScore;
        private System.Windows.Forms.DateTimePicker DtpScoreDate;
        private System.Windows.Forms.Panel PnlEditProfile;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.DateTimePicker DtpEditBirthDate;
        private System.Windows.Forms.TextBox TxtEditLastName;
        private System.Windows.Forms.TextBox TxtEditFirstName;
        private System.Windows.Forms.TextBox TxtEditFatherName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
    }
}