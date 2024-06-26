using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseEnrolmentSystem.Business_Logic_Layer;
using System.Windows.Forms; 

namespace Fees.Test
{
    [TestClass]
    public class FeesTest
    {
        [TestMethod]
        public void Calculate_FullTimeOver45Points_ReturnsDiscountedCost()
        {
            // Arrange
            string course = "BSc Law"; 
            CheckBox checkBox = new CheckBox();
            checkBox.Checked = true;

            // Act
            double result = Fees.Calculate(course, checkBox);

            // Assert
            // Mocking the expected full-time cost calculation based on your DatabaseDal
            double expectedCost = DatabaseDal.GetFulltimeCost(course) * 0.9;
            Assert.AreEqual(expectedCost, result, 0.001, "Full-time cost with 10% discount should be calculated correctly.");
        }

        [TestMethod]
        public void Calculate_PartTime_ReturnsPartTimeCost()
        {
            // Arrange
            string course = "BSc Computer Science"; 
            CheckBox checkBox = new CheckBox();
            checkBox.Checked = false;

            // Act
            double result = Fees.Calculate(course, checkBox);

            // Assert
            double expectedCost = DatabaseDal.GetParttimeCost(course);
            Assert.AreEqual(expectedCost, result, 0.001, "Part-time cost should be calculated correctly.");
        }

    }
}
