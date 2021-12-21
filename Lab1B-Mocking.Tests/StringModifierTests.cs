using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1B_Mocking.Tests
{ 
    [TestFixture]
    public class StringModifierTests
    {
        private Mock<IStringDataProvider> _provider;

        [SetUp]
        public void SetUp()
        {
            _provider = new Mock<IStringDataProvider>();
        }

        [Test]
        public void StringModifier_GivenReverseManipulator_ReturnsReversedText()
        {
            //Arrange
            _provider.Setup(x => x.Read()).Returns("Bijay");
            IStringManipulator manipulator = new ReverseManipulator();
            StringModifier modifier = new StringModifier(_provider.Object, manipulator);

            //Act
            var result = modifier.Run();

            //Assert
            Assert.That(result, Is.EqualTo("yajiB"));
        }

        [Test]
        public void StringModifier_GivenToUpperCaseManipulator_ReturnsUPPERCASETEXT()
        {
            //Arrange
            _provider.Setup(x => x.Read()).Returns("Bijay");
            IStringManipulator manipulator = new ToUpperCaseManipulator();
            StringModifier modifier = new StringModifier(_provider.Object, manipulator);

            //Act
            var result = modifier.Run();

            //Assert
            Assert.That(result, Is.EqualTo("BIJAY"));
        }
    }
}
