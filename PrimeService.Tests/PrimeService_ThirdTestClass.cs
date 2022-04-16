using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_ThirdTestClass
    {
        [TestCategory("Second category")]
        [TestCategory("First category")]
        [TestCategory("Simple")]
        [Priority(2)]
        [TestMethod]
        public void PassingTest()
        {
            Assert.Equals(4, Decimal.Add(2, 2));
            
        }
        
        [TestMethod]
        public void FailingTest()
        {
            Assert.Equals(5, Decimal.Add(2, 2));
        }
    }
}
