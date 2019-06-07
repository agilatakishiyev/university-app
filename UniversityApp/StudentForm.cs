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
    public partial class StudentForm : Form
    {
        UniversityEntities stuDB = new UniversityEntities();
        Student CurrentStudent { get; set; }
        List<Question> CurrentSubjectQuestions = new List<Question>();
        List<Question> CorrectAnswer = new List<Question>();
        List<Grade> GradesForSubject = new List<Grade>();
        int firstq = 1;
        int currentExamButtonTag =0 ;
        public StudentForm(Student student)
        {
            InitializeComponent();
            CurrentStudent = student;
        }
        private void BtnExitAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnOpenExams_Click(object sender, EventArgs e)
        {
            pnlExamButtons.Visible = true;
            pnlEditProfile.Visible = false;
            if (pnlExamButtons.Controls.Count==0)
            {
                foreach (var subject in stuDB.TeacherOfSubjectToGroups.Where(m => m.GroupID == CurrentStudent.GroupID))
                {
                    Font btnfnt = new Font("Century Gothic", 12f, FontStyle.Bold);
                    Button newExamButton = new Button
                    {
                        Tag = subject.SubjectID,
                        Text = subject.Subject.Name,
                        Font = btnfnt,
                        FlatStyle = FlatStyle.Flat,
                        ForeColor = Color.Firebrick,
                        BackColor = Color.Bisque,
                        Size = new Size(169, 38)
                    };
                    this.pnlExamButtons.Controls.Add(newExamButton);

                    newExamButton.Click += (sender2, e2) =>
                    {
                        pnlExam.Visible = true;
                        pnlExamButtons.Visible = true;
                        currentExamButtonTag =  (int)newExamButton.Tag;
                        foreach (Question item in stuDB.Questions.Where(m => m.SubjectID == (int)newExamButton.Tag))
                        {
                            CurrentSubjectQuestions.Add(item);

                        }
                        lblQuestionContent.Text = $"{firstq}.sual)" + " " + stuDB.Questions.Find(firstq).Content.ToString();
                        rdbAnswerA.Text = stuDB.Questions.Find(firstq).AnswerA.ToString();
                        rdbAnswerB.Text = stuDB.Questions.Find(firstq).AnswerB.ToString();
                        rdbAnswerC.Text = stuDB.Questions.Find(firstq).AnswerC.ToString();
                        rdbAnswerD.Text = stuDB.Questions.Find(firstq).AnswerD.ToString();
                        rdbAnswerE.Text = stuDB.Questions.Find(firstq).AnswerE.ToString();
                    };
                    BtnNextQuestion.Click += new EventHandler(_questionNext);
                }
            }
        }
        private void BtnFinishExam_Click(object sender, EventArgs e)
        {
            int ExamScore = CorrectAnswer.Count * 10;
            int SemesterScore= 0;
            int ScoreCount = 0;
            foreach (var item in stuDB.Grades.Where(s=>s.StudentID==CurrentStudent.ID&& s.SubjectID==currentExamButtonTag))
            {
                SemesterScore += item.Point.Value;
                ScoreCount++;
            }
            int entryPoint = SemesterScore/4*5;

            Evaluation Eva = new Evaluation
            {
                StudentID = CurrentStudent.ID,
                EntryPoint = SemesterScore / 4 * 5,
                SubjectID = currentExamButtonTag,
                ExamPoint =ExamScore,
                TotalPoint = entryPoint +ExamScore

            };
            if (Eva.TotalPoint>=51)
            {
                MessageBox.Show($"You passed The Exam with {Eva.TotalPoint} score");
            }
            else
            {
                MessageBox.Show($"You could not pass the exam. Your Score is {Eva.TotalPoint}");
            }
        }
        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            pnlEditProfile.Visible = true;
            pnlExamButtons.Visible = false;
        }
        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            string newpass = txtPassword.Text;
            Student newStudent = (from Student in stuDB.Students
                                  where Student.ID == CurrentStudent.ID
                                  select Student).FirstOrDefault();
            newStudent.Firstname = txtFirstName.Text;
            newStudent.Lastname = txtLastName.Text;
            newStudent.FatherName = txtFatherName.Text;
            newStudent.Birthdate = DtpBirthDate.Value;
            if (!string.IsNullOrEmpty(newpass))
            {
                newStudent.Password = Extensions.Extensions.HashPassword(newpass);
                stuDB.SaveChanges();
                MessageBox.Show("Changes saved successfully");
                pnlEditProfile.Visible = false;
            }
            else
            {
                stuDB.SaveChanges();
                MessageBox.Show("Changes saved successfully");
                pnlEditProfile.Visible = false;
            }
        }

        private void _questionNext(object sender,EventArgs e)
        {
                int checkradio = 0;

                foreach (RadioButton radiobutt in pnlAnswers.Controls)
                {

                if (radiobutt.Checked == true)
                {

                    if (radiobutt.Text == stuDB.Questions.Find(firstq).CorrectAnswer.ToString())
                    {
                        CorrectAnswer.Add(stuDB.Questions.Find(firstq));
                    }
                    checkradio++;
                    firstq++;
                    radiobutt.Checked = false;
                }
                else { }


                }
                if (checkradio == 0)
                {
                    MessageBox.Show("cavab ver it oglu");
                }
                else
                if (checkradio == 1)
                {
                    if (firstq == CurrentSubjectQuestions.Count + 1)
                    {
                        firstq--;
                        BtnFinishExam.Visible = true;

                    }
                    for (int i = 1; i <= CurrentSubjectQuestions.Count; i++)
                    {
                        lblQuestionContent.Text = $"{firstq}.sual" + " " + stuDB.Questions.Find(firstq).Content.ToString();
                        rdbAnswerA.Text = stuDB.Questions.Find(firstq).AnswerA.ToString();
                        rdbAnswerB.Text = stuDB.Questions.Find(firstq).AnswerB.ToString();
                        rdbAnswerC.Text = stuDB.Questions.Find(firstq).AnswerC.ToString();
                        rdbAnswerD.Text = stuDB.Questions.Find(firstq).AnswerD.ToString();
                        rdbAnswerE.Text = stuDB.Questions.Find(firstq).AnswerE.ToString();
                    }
                }

        }

        
    }
}
