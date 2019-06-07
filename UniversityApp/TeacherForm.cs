using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.Model;
using UniversityApp.Extensions;

namespace UniversityApp
{
    public partial class TeacherForm : Form
    {
        UniversityEntities teacherDB = new UniversityEntities();
        Teacher CurrentTeacher { get; set; }
        Group slctdGroup;
        int slctdStudentID;
        int slctdSubjectID;
         
        public TeacherForm(Teacher Teach)
        {
            InitializeComponent();
            CurrentTeacher = Teach;
        }
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            UpdateComboGroups();
            lblTeacherProfile.Text = CurrentTeacher.Firstname + " " + CurrentTeacher.Lastname;
        }
        public void UpdateComboGroups()
        {
            List<ComboLoader> Groups = new List<ComboLoader>();
            foreach (var item in teacherDB.TeacherOfSubjectToGroups.Where(t=>t.TeacherID==CurrentTeacher.ID).Select(t=>t.Group).Distinct().ToList())
            {
                Groups.Add(new ComboLoader
                {
                    Text= item.Name,
                    Value =item.ID
                });
            }
            cmbGroups.DataSource = Groups;
        }
        private void CmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            int slctdGroupID = ((ComboLoader)cmbGroups.SelectedItem).Value;
            slctdGroup = teacherDB.Groups.Find(slctdGroupID);
            UpdateComboSubjects();
        }
        public void UpdateComboSubjects()
        {
            List<ComboLoader> Groups = new List<ComboLoader>();
            foreach (var item in teacherDB.TeacherOfSubjectToGroups.Where(t => t.TeacherID == CurrentTeacher.ID && t.GroupID==slctdGroup.ID ).Select(t => t.Subject).Distinct().ToList())
            {
                Groups.Add(new ComboLoader
                {
                    Text = item.Name,
                    Value = item.ID
                });
            }
            cmbSubjects.DataSource = Groups;
        }
        private void CmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            slctdSubjectID = ((ComboLoader)cmbSubjects.SelectedItem).Value;
            dgwStudents.Visible = true;
            dgwStudents.DataSource = null;
            List<Object> Students = new List<Object>();

            foreach (var student in teacherDB.Students.Where(s => s.GroupID ==slctdGroup.ID))
            {
                Students.Add(new {
                    student.ID,
                    Name = student.Firstname + " " + student.Lastname,
                    Group = student.Group.Name
                });
            }
            dgwStudents.DataSource = Students;
            dgwStudents.Columns[0].Visible = false;
        }

        private void DgwStudents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pnlGradeGiving.Visible = true;
            slctdStudentID = (int)dgwStudents.Rows[e.RowIndex].Cells[0].Value;
            lblStudentName.Text = teacherDB.Students.Find(slctdStudentID).Firstname;
            DtpScoreDate.MaxDate = DateTime.Now;

        }
        private void BtnGiveGrade_Click(object sender, EventArgs e)
        {
            DateTime scoreDate = DtpScoreDate.Value;
            int point = (int)nmScore.Value;
            Grade grd = new Grade
            {
                StudentID = slctdStudentID,
                SubjectID = slctdSubjectID,
                Point = point,
                ScoreDate = scoreDate
            };
            teacherDB.Grades.Add(grd);
            teacherDB.SaveChanges();
        }
        private void BtnEditTeacher_Click(object sender, EventArgs e)
        {
            PnlEditProfile.Visible = true;
            TxtEditFirstName.Text = CurrentTeacher.Firstname;
            TxtEditLastName.Text = CurrentTeacher.Lastname;
            TxtEditFatherName.Text = CurrentTeacher.FatherName;
            DtpEditBirthDate.Value = (DateTime)CurrentTeacher.Birthdate;
        }
        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            string newpass = txtPassword.Text;
            Teacher newTeacher = (from Teacher in teacherDB.Teachers
                                  where Teacher.ID == CurrentTeacher.ID
                                  select Teacher).FirstOrDefault();
            newTeacher.Firstname = TxtEditFirstName.Text;
            newTeacher.Lastname = TxtEditLastName.Text;
            newTeacher.FatherName = TxtEditFatherName.Text;
            newTeacher.Birthdate = DtpEditBirthDate.Value;
            if (!string.IsNullOrEmpty(newpass))
            {
                newTeacher.Password = Extensions.Extensions.HashPassword(newpass);

                teacherDB.SaveChanges();
                MessageBox.Show("Changes saved successfully");
                PnlEditProfile.Visible = false;
            }
            else
            {
                teacherDB.SaveChanges();
                MessageBox.Show("Changes saved successfully");
                PnlEditProfile.Visible = false;
            }
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
