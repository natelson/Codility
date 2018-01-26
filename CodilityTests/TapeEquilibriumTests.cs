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
    public class TapeEquilibriumTests
    {
        [TestMethod()]
        public void TapeEquilibriumSolutionTest()
        {
            TapeEquilibrium testTape = new TapeEquilibrium();
            int[] arrayTest = new int[] { 3, 1, 2, 4, 3 };
            Assert.AreEqual(1, testTape.Solution(arrayTest));
        }
    }
}