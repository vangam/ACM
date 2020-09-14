//using System;
//using ACM.BL;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace ACM.BLTest
//{
//    [TestClass]
//    public class CustomerTest
//    {
//        [TestMethod]
//        public void FullNameTest()
//        {
//            Customer customer = new Customer
//            {
//                FirstName = "suppi",
//                LastName = "mahi"
//            };
//            string expected = "mahi, suppi";

//            string actual = customer.FullName;

//            Assert.AreEqual(expected, actual);
//        }

//        [TestMethod]
//        public void StaticTest()
//        {
//            var c1 = new Customer();
//            c1.FirstName = "Suppi";
//            Customer.InstantCount += 1;

//            var c2 = new Customer();
//            c1.FirstName = "Mani";
//            Customer.InstantCount += 1;

//            var c3 = new Customer();
//            c1.FirstName = "Mahi";
//            Customer.InstantCount += 1;

//            Assert.AreEqual(3, Customer.InstantCount);

//        }
//    }
//}
