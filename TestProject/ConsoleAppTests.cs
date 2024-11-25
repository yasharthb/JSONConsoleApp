using JSONConsoleApp;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;

namespace TestProject
{
    [TestClass]
    public class ConsoleAppTests
    {
        [TestMethod]
        public void DefaultConstructorTest()
        {
            Address address = new Address();
            Assert.IsNotNull(address);
            Assert.IsNull(address.Street);
            Assert.IsNull(address.City);
            Assert.IsNull(address.State);
            Assert.IsNull(address.ZipCode);
        }

        [TestMethod]
        public void ParameterizedConstructorTest()
        {
            Address address = new Address("456 Elm St", "Metropolis", "NY", "67890");
            Assert.AreEqual("456 Elm St", address.Street);
            Assert.AreEqual("Metropolis", address.City);
            Assert.AreEqual("NY", address.State);
            Assert.AreEqual("67890", address.ZipCode);
        }

        [TestMethod]
        public void EqualsMethodTest_EqualObjects()
        {
            Address address1 = new Address("789 Oak St", "Gotham", "CA", "54321");
            Address address2 = new Address("789 Oak St", "Gotham", "CA", "54321");

            Assert.IsTrue(address1.Equals(address2));
        }

        [TestMethod]
        public void EqualsMethodTest_NotEqualObjects()
        {
            Address address1 = new Address("789 Oak St", "Gotham", "CA", "54321");
            Address address2 = new Address("789 Oak St", "Metropolis", "CA", "54321");

            Assert.IsFalse(address1.Equals(address2));
        }

        [TestMethod]
        public void EqualsMethodTest_NullObject()
        {
            Address address = new Address("123 Main St", "Springfield", "IL", "12345");
            Assert.IsFalse(address.Equals(null));
        }
    }
}