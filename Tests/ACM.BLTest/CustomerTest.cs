using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]        
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";
            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //  Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //  Act
            string actual = customer.FullName;

            //  Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //  Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            //  Act
            string actual = customer.FullName;

            //  Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //  Arrange
            var c1 = new Customer
            {
                FirstName = "Bilbo"
            };
            Customer.InstanceCount += 1;

            var c2 = new Customer
            {
                FirstName = "Frodo"
            };
            Customer.InstanceCount += 1;

            var c3 = new Customer
            {
                FirstName = "Rosie"
            };
            Customer.InstanceCount += 1;

            //  Act

            //  Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
