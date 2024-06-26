﻿using Assignment.Business_Layer;
using CourseEnrolmentSystem.Business_Layer;
using CourseEnrolmentSystem.Business_Logic_Layer;
using CourseEnrolmentSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseEnrolmentSystem
{
    public partial class CourseEnrolmentSystemTwo : Form
    {
        string courseSelected;
        double fees;
        public CourseEnrolmentSystemTwo(string course)
        {
            InitializeComponent();
            courseSelected = course;
            CourseTextBox.Text = course;
            fees = Fees.Calculate(course, IsFulltimeCheckBox);
            FeesTextBox.Text = fees.ToString();

        }

        private void CourseEnrolmentSystemTwo_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CourseEnrolmentSystem courseEnrolmentSystem = new CourseEnrolmentSystem();
            courseEnrolmentSystem.Show();
            this.Hide();
            MainFunction.ClearSubjects();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string email = EmailTextBox.Text;
            string contactNumber = ContactNumberTextBox.Text;
            string address = AddressTextBox.Text;
            string course = CourseTextBox.Text;
            fees = Fees.Calculate(courseSelected, IsFulltimeCheckBox);

            if (ValidationProcessing.isUserInputValid(firstName, lastName, email, contactNumber, address, course))
            {
                DatabaseDal.InsertStudent(firstName, lastName, email, contactNumber, address, course, fees);
                CourseEnrolmentSystem courseEnrolmentSystem = new CourseEnrolmentSystem();
                courseEnrolmentSystem.Show();
                this.Hide();
            }

        }

        private void FeesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FeesLabel_Click(object sender, EventArgs e)
        {
            
        }
        private void IsFulltimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fees = Fees.Calculate(courseSelected, IsFulltimeCheckBox);
            FeesTextBox.Text = fees.ToString();
        }
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            EmailTextBox.Clear();
            ContactNumberTextBox.Clear();
            AddressTextBox.Clear();
            MainFunction.ClearSubjects();
        }
    }
}
