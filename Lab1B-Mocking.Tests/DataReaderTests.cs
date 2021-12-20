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
    public class DataReaderTests
    {
        private DataReader _dataReader = new DataReader();
        private Mock<IStringDataProvider> _mockDataProvider = new Mock<IStringDataProvider>();
        [Test]
        public void ReadString_GivenStringProvider_ReturnsLine()
        {
            //Arrange
            //_mockDataProvider.Setup(x => x.Read()).Returns(_)
        }

        public void ReadString_GivenStringProviderThatIsNull_ReturnsFileWasNull()
        {
            
            //_dataReader.Read
        }
    }
}
