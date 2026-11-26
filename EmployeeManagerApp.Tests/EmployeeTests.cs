using NUnit.Framework;
using EmployeeManagerApp.Models;
using System;

namespace EmployeeManagerApp.Tests
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void CalculateAnnualBonus_ValidSalary_ReturnsTenPercent()
        {
            // 1. Arrange
            var employee = new Employee { Salary = 60000m };
            decimal expectedBonus = 6000m;

            // 2. Act
            decimal actualBonus = employee.CalculateAnnualBonus();

            // 3. Assert
            Assert.AreEqual(expectedBonus, actualBonus);
        }

        [Test]
        public void CalculateAnnualBonus_NegativeSalary_ThrowsArgumentException()
        {
            // 1. Arrange
            var employee = new Employee { Salary = -5000m };

            // 2. Act & 3. Assert
            Assert.Throws<ArgumentException>(() => employee.CalculateAnnualBonus());
        }
    }
}
