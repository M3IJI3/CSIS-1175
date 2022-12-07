using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCourseRegister
{
    public partial class Form1 : Form
    {
        CollegeStudent cs = new CollegeStudent();


        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            
            string name = txtName.Text.ToString().Replace(" ","").ToLower();
            string fileName = "file/student.txt";

            string inValue;

            if (File.Exists(fileName))
            {
                try
                {
                    StreamReader sr = new StreamReader(fileName);
                    
                    while((inValue = sr.ReadLine()) != null)
                    {
                        string[] student = inValue.Split(' ');

                        if (student[0].Replace(" ","").ToLower() == name && student[1] == txtStudentID.Text)
                        {
                            lblResult.Text = "Yes";

                            cs.Name = student[0];
                            cs.StudentID = student[1];
                            cs.CourseTaken[0] = student[2];
                            cs.CourseTaken[1] = student[3];
                            cs.CourseTaken[2] = student[4];

                            break;
                        }
                        else
                        {
                            lblResult.Text = "No";
                            txtName.Clear();
                            txtStudentID.Clear();                       
                            
                        }
                    }

                    sr.Close();
                }
                catch (IOException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("File unavailable!");
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = "file/course.txt";
            string inValue;

            if(File.Exists(filePath))
            {
                try
                {
                    StreamReader sr = new StreamReader(filePath);

                    while((inValue = sr.ReadLine()) != null)
                    {
                        string[] course = inValue.Split(' ');

                        if(cmbCourse.SelectedItem.ToString() == course[0])
                        {
                            lblSeatsAvailable.Text = course[1];
                        }
                    }

                    sr.Close();
                }
                catch (IOException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("File is not existed!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string courseFilePath = "file/course.txt";
            string recordFilePath = "file/record.txt";

            string inValue;

            Course course;

            if(txtName.Text == "" || txtStudentID.Text == "" || cmbCourse.Text == "")
            {
                MessageBox.Show("Please complete other information!");
            }

            if(File.Exists(courseFilePath))
            {
                try
                {
                    StreamReader sr = new StreamReader(courseFilePath);
                    
                    while((inValue = sr.ReadLine()) != null)
                    {
                        string[] courseInfo = inValue.Split(' ');

                        if(cmbCourse.Text == courseInfo[0])
                        {
                            course = new Course(courseInfo[0], int.Parse(courseInfo[1]), courseInfo[2], courseInfo[3]);
                           // MessageBox.Show(course.name);

                            MessageBox.Show(course.avaliableSeats.ToString());

                            if(cs.CourseRegistration(course))
                            {
                                //MessageBox.Show("Your course " + cmbCourse.Text + " has been successfully registered!");

                                if(File.Exists(recordFilePath))
                                {
                                    try
                                    {
                                        StreamWriter sw = new StreamWriter(recordFilePath, true);
                                        sw.WriteLine(cs.Name + " " + cs.StudentID + " " + cs.CourseReadyToRegister + " " + cs.tuition);
                                        sw.Close();
                                        MessageBox.Show("Your course " + cmbCourse.Text + " has been successfully registered!");
                                    }
                                    catch(IOException exc)
                                    {
                                        MessageBox.Show(exc.Message);
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Register Failure!");
                            }
                        }
                    }

                    sr.Close();
                }
                catch(IOException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("File is no existed!");
            }

            //if(cs.CourseRegistration(course))
            //{
            //    MessageBox.Show("Your course " + cmbCourse.SelectedItem.ToString() + " has been registered successfully!");
            //}
        }
    }
}
