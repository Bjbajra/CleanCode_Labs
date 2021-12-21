using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1B_Mocking.Tests
{ 
    [TestFixture]
    public class ReverseManipulatorTests
    {
        [Test]
        public void ReverseManipulator_GivenText_ReverseText()
        {
            //Arrange
            ReverseManipulator manipulator = new ReverseManipulator();

            //Act
            var result = manipulator.Manipulate("mocking");

            //Assert
            Assert.That(result, Is.EqualTo("gnikcom"));

        }
    }
}
