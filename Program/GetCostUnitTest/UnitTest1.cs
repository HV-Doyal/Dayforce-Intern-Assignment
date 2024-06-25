namespace CourseEnrolmentSystem.Tests
{
    [TestFixture]
    public class DatabaseDalTests
    {
        private const string TestConnectionString = @"data source=HVD-PC;initial catalog=master;trusted_connection=true";

        [Test]
        public void GetCourseCost_ValidCourse_ReturnsCorrectCost()
        {
            // Arrange
            string course = "Computer Science"; // Replace with an existing course in your database
            int expectedCost = 1000; // Replace with the expected cost for the given course

            // Act
            int actualCost = DatabaseDal.GetCourseCost(course, "FulltimeCost");

            // Assert
            Assert.AreEqual(expectedCost, actualCost, $"Expected cost for course '{course}' does not match actual cost.");
        }
    }
}