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
    public partial class Form1 : Form
    {
        UniversityEntities db = new UniversityEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFirstLogIN_Click(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked || rdbTeacher.Checked || rdbStudent.Checked)
            {
                pnlLogin.Visible = true;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string identifier = txtIdentifier.Text;
            string pass = txtPassword.Text;
            if (string.IsNullOrEmpty(identifier) ||
                string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Fill both of the fields to log in!");
            }

            if (rdbAdmin.Checked == true)
            {
                AdminForm adm = new AdminForm();
                adm.ShowDialog();
            }
            else if (rdbStudent.Checked == true)
            {
                string hashedpass = Extensions.Extensions.HashPassword(pass);
                Student loggedStudent = db.Students.FirstOrDefault(m => m.Identifier == identifier && m.Password == hashedpass);
                if (loggedStudent!=null)
                {
                     StudentForm sf = new StudentForm(loggedStudent);
                     sf.ShowDialog();
                     Extensions.Extensions.InputClearer(pnlLogin);
                }
                else
                {
                    MessageBox.Show("Identifier or password is wrong");
                }
               
            }
            else if (rdbTeacher.Checked == true)
            {
                string hashedpass = Extensions.Extensions.HashPassword(pass);
                Teacher loggedTeacher = db.Teachers.FirstOrDefault(m => m.Identifier == identifier && m.Password == hashedpass);
                if (loggedTeacher!= null)
                {
                    TeacherForm tf = new TeacherForm(loggedTeacher);
                    tf.ShowDialog();
                    Extensions.Extensions.InputClearer(pnlLogin);
                }
                else
                {
                    MessageBox.Show("Identifier or password is wrong");
                }
            }
        }
    }
}