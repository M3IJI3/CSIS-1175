using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCourseEnrollSystem
{
    public partial class Form1 : Form
    {
        string stuFilePath = "student.txt";
        string crsFilePath = "course.txt";
        string rcdFilePath = "record.txt";

        StreamReader fileReader;
        StreamWriter fileWriter;

        CollegeStudent student;
        Course course;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inValue;
            string[] studentInfo;
            string name = txtName.Text.ToString().Replace(" ","").ToLower();
            string stuID = txtStuID.Text.ToString().Replace(" ","");

            if(File.Exists(stuFilePath))
            {
                try
                {
                    fileReader = new StreamReader(stuFilePath);

                    while((inValue = fileReader.ReadLine()) != null)
                    {
                        
                        studentInfo = inValue.Split(',');

                        if(stuID == studentInfo[0] && name == studentInfo[1].ToLower())
                        {
                            lblSearchResult.Text = "Yes";

                            // instantiate this student
                            string[] courseTaken = { studentInfo[2], studentInfo[3], studentInfo[4] };
                            student = new CollegeStudent(studentInfo[0], studentInfo[1], courseTaken);

                            break;
                        }
                        else
                        {
                            lblSearchResult.Text = "No";
                        }                       
                    }

                    fileReader.Close();

                    if (lblSearchResult.Text == "No")
                    {
                        txtName.Clear();
                        txtStuID.Clear();
                    }

                }
                catch(IOException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("File does not existed!");
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inValue;

            if(File.Exists(crsFilePath))
            {
                try
                {
                    fileReader = new StreamReader(crsFilePath);

                    while((inValue = fileReader.ReadLine()) != null)
                    {
                        string[] courseInfo = inValue.Split(',');
                        if(cmbCourse.SelectedItem.ToString() == courseInfo[0])
                        {
                            lblSeatsAmount.Text = courseInfo[1];
                        }
                    }
                    fileReader.Close();
                }
                catch(IOException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string inValue;

            if(File.Exists(crsFilePath))
            {
                fileReader = new StreamReader(crsFilePath);
                try
                {
                    while((inValue = fileReader.ReadLine()) != null)
                    {
                        string[] courseToRegisterInfo = inValue.Split(',');
                        if (cmbCourse.Text.ToString() == courseToRegisterInfo[0])
                        {
                            int length = courseToRegisterInfo.Length;

                            switch(length)
                            {
                                case 2:
                                    course = new Course(courseToRegisterInfo[0], int.Parse(courseToRegisterInfo[1]));
                                    //fileReader.Close();
                                    break;
                                case 3:
                                    course = new Course(courseToRegisterInfo[0], int.Parse(courseToRegisterInfo[1]), courseToRegisterInfo[2]);
                                    break;
                                case 4:
                                    course = new Course(courseToRegisterInfo[0], int.Parse(courseToRegisterInfo[1]), courseToRegisterInfo[2], courseToRegisterInfo[3]);
                                    break;
                                default:
                                    break;
                            }                          
                        }                                         
                    }

                    fileReader.Close();

                    student.courseStatus = student.CourseRegistration(course, student);

                    if (student.courseStatus)
                    {
                        student.tuition = 2000;
                        //course.availableSeats = course.UpdateSeat(course);

                        if (File.Exists(rcdFilePath))
                        {
                            fileWriter = new StreamWriter(rcdFilePath, true);
                            try
                            {
                                if (int.Parse(lblSeatsAmount.Text.ToString()) > 0)
                                {
                                    // change it in the interface first
                                    lblSeatsAmount.Text = (int.Parse(lblSeatsAmount.Text.ToString()) - 1).ToString();
                                    fileWriter.WriteLine(student.stuID + "," + student.name + "," + course.name + "," + student.tuition);
                                    fileWriter.Close();

                                    // change it in the backend
                                    
                                    MessageBox.Show("Data has been written!");

                                }
                                else
                                {
                                    MessageBox.Show("No more vacancies!");
                                }    
                                
                            }
                            catch (IOException exc)
                            {
                                MessageBox.Show(exc.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("File does not exist!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("You dont meet the requirements for this course");
                    }
                }
                catch(IOException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
                     
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtStuID.Clear();
            lblSearchResult.Text = "";
            lblSeatsAmount.Text = "";
            cmbCourse.Text = "";
        }
    }
}
