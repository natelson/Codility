using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Tests
{
    [TestClass()]
    public class PassingCarsTests
    {
        [TestMethod()]
        public void PassingCarsSolutionTest()
        {
            PassingCars testPassingCars = new PassingCars();
            int[] arrayTest = new int[] { 0,1,0,1,1 };
            Assert.AreEqual(5, testPassingCars.Solution(arrayTest));
        }
    }
}