using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("cat1")]
        public void Test1()
        {
            Assert.Pass();
            Console.WriteLine("Test1");
            TestContext.WriteLine("Test1");
        }

        [Test]
        [Category("cat2")]
        public void Test2()
        {
            Assert.Pass();
            Console.WriteLine("Test2");
        }
    }
}