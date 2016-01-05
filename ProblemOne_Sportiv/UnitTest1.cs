using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemOne_Sportiv
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumberOfRepetitions()
        {
            int x = 4;
            int numberOfRepetitions = x * x;
            Assert.AreEqual(16, numberOfRepetitions);
        }
    }
}
