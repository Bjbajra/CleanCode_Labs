using NUnit.Framework;

namespace Lab1B_Mocking.Tests
{
    [TestFixture]
    public class StringHelpersTests
    {
        [Test]
        public void Reverse_GivenString_ReturnsReverseThatString()
        {
            //Arrange
            string wordToCheck = "Kathmandu";
            string expectedResult = "udnamhtaK";

            //Act
            StringHelpers stringHelpers = new StringHelpers();
            string calculatedResult = stringHelpers.Reverse(wordToCheck);

            //Assert
            Assert.That(expectedResult, Is.EqualTo(calculatedResult));
        }

    }
}
