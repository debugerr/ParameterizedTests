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
        }

        [Test]
        [Category("cat2")]
        public void Test2()
        {
            Assert.Pass();
        }


        [Test]
        [Category("cat1")]
        [Category("cat2")]
        [Category("cat3")]
        public void Test3()
        {
            Assert.Pass();
        }
    }
}