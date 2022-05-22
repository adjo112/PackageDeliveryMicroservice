using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using PackageDeliveryMicroservice.Controllers;
using System;

namespace PackageDeliveryTest
{
    [TestFixture]
    public class PackageDeliveryTest
    {
        PackagingDeliveryCharge packagingDeliveryCharge;
       

        [SetUp]
        public void Setup()
        {
            packagingDeliveryCharge = new PackagingDeliveryCharge();
           // result = 0;
        }
        [TearDown]
        public void TearDown()
        {
            packagingDeliveryCharge = null;
        }

        [Test]
        public void Test1()
        {
            int expectedResult = 600;

            ObjectResult result = (ObjectResult)packagingDeliveryCharge.GetPackagingDeliveryCharge("integral", 2);

            Assert.AreEqual(expectedResult, result.Value);
        }

        [Test]
        public void Test2()
        {
            int expectedResult = 450;

            ObjectResult result = (ObjectResult)packagingDeliveryCharge.GetPackagingDeliveryCharge("accessory", 3);

            Assert.AreEqual(expectedResult, result.Value);
        }

        [Test]
        public void Test3()
        {
            int expectedResult = 1500;

            ObjectResult result = (ObjectResult)packagingDeliveryCharge.GetPackagingDeliveryCharge("integral", 5);

            Assert.AreEqual(expectedResult, result.Value);
        }

        [Test]
        public void Test4()
        {
            int expectedResult = 1050;

            ObjectResult result = (ObjectResult)packagingDeliveryCharge.GetPackagingDeliveryCharge("accessory", 7);

            Assert.AreEqual(expectedResult, result.Value);
        }
    }
}