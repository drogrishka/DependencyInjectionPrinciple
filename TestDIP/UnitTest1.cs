using DependencyInjectionPrinciple;

namespace TestDIP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1_ReturnsCorrectValue()
        {
            int hoursWorked = 40;
            float hourlyRate = 20.0f;
            float expectedSalary = 800.0f;

            // Act
            ISalaryCalculator calculator = new SalaryCalculatorModified();
            float actualSalary = calculator.CalculateSalary(hoursWorked, hourlyRate);

            // Assert
            Assert.AreEqual(expectedSalary, actualSalary, "Salary calculation is incorrect");

        }
    }
}