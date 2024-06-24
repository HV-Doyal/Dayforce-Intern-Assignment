using Assignment.Business_Layer;
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
        public CourseEnrolmentSystemTwo()
        {
            InitializeComponent();
        }

        private void CourseEnrolmentSystemTwo_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CourseEnrolmentSystem courseEnrolmentSystem = new CourseEnrolmentSystem();
            courseEnrolmentSystem.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string email = EmailTextBox.Text;
            string contactNumber = ContactNumberTextBox.Text;
            string address = AddressTextBox.Text;
            string course = CourseTextBox.Text;
            double fees = FeesCalculation(course);
            MessageBox.Show($"{fees}");

            if (ValidationProcessing.isUserInputValid(firstName, lastName, email, contactNumber, address, course))
            {
                DatabaseDal.InsertStudent(firstName, lastName, email, contactNumber, address, course, fees);
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

        private double FeesCalculation(string course)
        {
            double finalFees = DatabaseDal.GetFulltimeCost(course);
            if (IsFulltimeCheckBox.Checked && (UiFunction.TotalPoints() > 45))
            {
                finalFees = (90 / 100) * finalFees;
                MessageBox.Show($"{finalFees}");
            }
            else if (IsFulltimeCheckBox.Checked && (UiFunction.TotalPoints() <= 45))
            {
                return finalFees;
            }

            if (!IsFulltimeCheckBox.Checked)
            {
                finalFees = DatabaseDal.GetParttimeCost(course);
            }
            return finalFees;
        }
    }
}
