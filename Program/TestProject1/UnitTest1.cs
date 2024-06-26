using NUnit.Framework;
using CourseEnrolmentSystem.Business_Logic_Layer;
using System.Windows.Forms;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Calculate_PartTime_ReturnsPartTimeFees()
        {
            // Arrange
            string course = "BSc Computer Science";
            double expectedFees = 30000;
            CheckBox checkBox = new CheckBox();
            checkBox.Checked = false;

            // Act
            double result = Fees.Calculate(course, checkBox);

            Assert.AreEqual(expectedFees, result);
        }
    }
}

