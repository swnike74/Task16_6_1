using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1661.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Addition_MustReturnsCorrectValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Addition(10, 220), Is.EqualTo(230));
        }

        [Test]
        public void Substraction_MustReturnCorrectValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Subtraction(200, 10) == 190);
        }

        [Test]
        public void Multiplication_MustReturnCorrectValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Miltiplication(20, 10) == 200);
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Division(200, 10) == 20);
        }


    }
}
