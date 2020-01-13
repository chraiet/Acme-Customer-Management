using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ValidateOrderDateNull()
        {
            //  Arrange
            var order = new Order
            {
                OrderDate = null
            };
            bool expected = false;

            //  Act
            bool actual = order.Validate();

            //  Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
