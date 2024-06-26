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

namespace FeesUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void CalculatePartTimePartTimeFees()
        {
            //Arrange
            string course = "BSc Law";
            double expectedFees = 30000;
            CheckBox checkBox = new CheckBox();
            checkBox.Checked = false;

            //Act
            double actualFees = Fees.Calculate(course, checkBox);

            //Assert
            Assert.AreEqual(expectedFees, actualFees);
        }
    }
}