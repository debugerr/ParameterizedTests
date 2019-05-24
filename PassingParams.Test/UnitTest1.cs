using NUnit.Framework;
using System;
using System.Collections;
using System.Text;

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
        public void NoCat()
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

        [Test]
        [Category("All")]
        public void CanGetMyVariable()
        {
            var expected = "This is a test";
            var actual = Environment.GetEnvironmentVariable("Build.BuildNumber");

            StringBuilder sb = new StringBuilder();
            foreach (DictionaryEntry kv in Environment.GetEnvironmentVariables())
            {
                sb.AppendLine($"{kv.Key}={kv.Value}::");
            }

            Assert.AreEqual(expected, sb);
        }
    }
}