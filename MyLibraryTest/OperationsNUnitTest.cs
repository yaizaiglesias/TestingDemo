using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]   
    public class OperationsNUnitTest
    {
        [Test]
        public void Add_InputNumbers_ReturnNumber()
        {
            // 1. Arrange
            Operations operations = new Operations();
            // Operations operations = new();
            // var operations = new Operations();
            int number1 = 13;
            int number2 = 11;
            int expectedResult = 24;

            // 2. Act
            int result = operations.Add(number1, number2);

            // 3. Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(10, ExpectedResult = true)]
        [TestCase(12, ExpectedResult = false)]
        [TestCase(14, ExpectedResult = true)]
        public void IsEven_InputNumber_ReturnsTrue(int number)
        {
            // 1. Arrange
            Operations operations = new Operations();
            // int number= 23;

            // 2. Act
            var result = operations.isEven(number);

            // 3. Assert
            Assert.That(result, Is.True);

            
        }

        [Test]
        [TestCase(2.2,1.2)]
        [TestCase(2.23,1.24)]
        public void AddDecimal_InputDoubleNumbers_ReturnsDoubleNumber(double number1, double number2)
        {
            // 1. Arrange
            Operations operations = new Operations();

            // 2. Act
            double result= operations.AddDecimal(number1, number2);

            // 3. Assert
            Assert.That(result, Is.EqualTo(3.4).Within(0.1));
        }
    }
}
