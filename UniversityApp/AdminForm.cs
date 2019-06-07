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
    public partial class AdminForm : Form
    {
        UniversityEntities adminDB = new UniversityEntities();
        public AdminForm()
        {
            InitializeComponent();
        }
        //FillingCombosAtTheLoadEvent
        private void AdminForm_Load(object sender, EventArgs e)
        {
            UpdateComboGroups();
            UpdateComboTeachers();
            UpdateComboSubjects();
        }
        //AddingProccessMethods
        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            string teacherFirstName = txtFirstName.Text;
            string teacherLastName = txtLastName.Text;
            string teacherPassword = txtPassword.Text;
            string teacherConPass = txtConpass.Text;
            string teacherFatherName = txtFatherName.Text;
            DateTime birthdate = dtPTeacherBirthdate.Value;

            if (string.IsNullOrEmpty(teacherFirstName) ||
                string.IsNullOrEmpty(teacherLastName)||
                string.IsNullOrEmpty(teacherPassword)||
                string.IsNullOrEmpty(teacherFatherName)||
                teacherPassword!=teacherConPass)
            {
                MessageBox.Show("Fill all of the fields");
            }
            else
            {
                string identifier = _generateIdentifierForTeachers().IdentifierGeneratorForTeachers();

                Teacher newTeacher = new Teacher
                {
                    Firstname = teacherFirstName,
                    Lastname = teacherLastName,
                    Password = Extensions.Extensions.HashPassword(teacherPassword),
                    Identifier =identifier,
                    FatherName = teacherFatherName,
                    Birthdate = birthdate,
                    Status= true
                };
                adminDB.Teachers.Add(newTeacher);
                adminDB.SaveChanges();
                Extensions.Extensions.InputClearer(pnlAddTeachers);
                MessageBox.Show("Teacher added successfully");
            }
            
        }
        private void AddTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddTeachers.Visible = true;
            pnlAddStudent.Visible = false;
            addCoursePanel.Visible = false;

        }
        private void ADDStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddTeachers.Visible = false;
            pnlAddStudent.Visible = true;
            addCoursePanel.Visible = false;

        }
        private void BtnADDstudent_Click(object sender, EventArgs e)
        {
            var selectedGroupID = cmbGroupsForStudentPanel.SelectedItem as ComboLoader;
            string studentFirstName = txtFirstnameStudent.Text;
            string studentLastName = txtLastnameStudent.Text;
            string studentPassword = txtPasswordStudent.Text;
            string studentConPass = txtStudenConPass.Text;
            string studentFatherName = txtFatherNameStudent.Text;
            DateTime studentBirthDate = dtPStudentBirthDate.Value;
            if (string.IsNullOrEmpty(studentFirstName) ||
                string.IsNullOrEmpty(studentLastName) ||
                string.IsNullOrEmpty(studentPassword) ||
                string.IsNullOrEmpty(studentFatherName) ||
                studentPassword != studentConPass)
            {
                MessageBox.Show("Fill all of the fields");
            }
            else
            {
                string identifier = _generateIdentifierForStudents().IdentifierGenerator();


                Student newStudent = new Student
                {
                    Firstname = studentFirstName,
                    Lastname = studentLastName,
                    Birthdate = studentBirthDate,
                    FatherName = studentFatherName,
                    Password = Extensions.Extensions.HashPassword(studentPassword),
                    Identifier = identifier,
                    GroupID = selectedGroupID.Value,
                    Status = true
                };
                adminDB.Students.Add(newStudent);
                adminDB.SaveChanges();
                Extensions.Extensions.InputClearer(pnlAddStudent);
                MessageBox.Show("Student added successfully");

            }
        }
        private void ADDCOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddStudent.Visible = false;
            pnlAddTeachers.Visible = false;
            addCoursePanel.Visible = true;

        }
        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            var SelectedTeacher = cmbTeachers.SelectedItem as ComboLoader;
            var SelectedSubject = cmbSubjects.SelectedItem as ComboLoader;
            var SelectedGroup = cmbGroupforGroups.SelectedItem as ComboLoader;

            TeacherOfSubjectToGroup newTSG = new TeacherOfSubjectToGroup
            {
                SubjectID = SelectedSubject.Value,
                TeacherID = SelectedTeacher.Value,
                GroupID = SelectedGroup.Value
            };
            adminDB.TeacherOfSubjectToGroups.Add(newTSG);
            adminDB.SaveChanges();


        }
        private void aDDGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddStudent.Visible = false;
            pnlAddTeachers.Visible = false;
            pnlAddGroup.Visible = true;
            addCoursePanel.Visible = false;
        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            string groupName = txtGroup.Text;
            if (string.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("Write the name of The Group");
            }

            if(adminDB.Groups.FirstOrDefault(m=> m.Name ==groupName)==null)
            {
                Group grp = new Group
                {
                    Name = groupName
                };
                MessageBox.Show("Group added successfully");
                adminDB.Groups.Add(grp);
                adminDB.SaveChanges();
                Extensions.Extensions.InputClearer(pnlAddGroup);
            }
            else
            {
                MessageBox.Show($"The group with the {groupName} name already exists");
            }
           
        }
        //ComboUpdateMethods
        public void UpdateComboGroups()
        {
            List<ComboLoader> Groups = new List<ComboLoader>();
            foreach (var item in adminDB.Groups.ToList())
            {
                Groups.Add(new ComboLoader
                {
                    Text = item.Name,
                    Value = item.ID
                });
            }
            cmbGroupforGroups.DataSource = Groups;
            cmbGroupsForStudentPanel.DataSource = Groups;
        }
        public void UpdateComboTeachers()
        {
            List<ComboLoader> Groups = new List<ComboLoader>();
            foreach (var item in adminDB.Teachers.ToList())
            {
                Groups.Add(new ComboLoader
                {
                    Text= item.Firstname+" "+item.Lastname,
                    Value= item.ID
                });
            }
            cmbTeachers.DataSource = Groups;
        }
        public void UpdateComboSubjects()
        {
            List<ComboLoader> Groups = new List<ComboLoader>();
            foreach (var item in adminDB.Subjects.ToList())
            {
                Groups.Add(new ComboLoader
                {
                    Text=item.Name,
                    Value= item.ID
                });
            }
            cmbSubjects.DataSource = Groups;
        }
        //identifierGeneratorMethods
        private string _generateIdentifierForStudents()
        {
            int identifier = adminDB.Students.OrderByDescending(m=>m.ID).FirstOrDefault().ID;
            identifier++;
            return identifier.ToString();
        }
        private string _generateIdentifierForTeachers()
        {
            int identifier = adminDB.Teachers.OrderByDescending(m => m.ID).FirstOrDefault().ID;
            identifier++;
            return identifier.ToString();

        }

       
    }
}
