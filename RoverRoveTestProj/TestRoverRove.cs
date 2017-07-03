using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverTestProject;

namespace RoverRoveTestProj
{
    [TestClass]
    public class TestRoverRove
    {
        [TestMethod]
        public void TestRoveA()
        {
            var roverRove = new RoverRove("1 2 N", "LMLMLMLMM");
            Assert.AreEqual("1 3 N", roverRove.Calculate());
        }

        [TestMethod]
        public void TestRoveB()
        {
           var roverRove = new RoverRove("3 3 E", "MMRMMRMRRM");
            Assert.AreEqual("5 1 E", roverRove.Calculate());
        }
    }
}
