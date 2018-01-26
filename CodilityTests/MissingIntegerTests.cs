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
    public class MissingIntegerTests
    {
        [TestMethod()]
        public void MissingIntegerSolutionTest()
        {
            MissingInteger testMissingInteger = new MissingInteger();
            int[] arrayTest = new int[] { 1,3,6,4,1,2 };
            Assert.AreEqual(5, testMissingInteger.Solution(arrayTest));
        }

        [TestMethod()]
        public void MissingIntegerSolutionTestAfterArray()
        {
            MissingInteger testMissingInteger = new MissingInteger();
            int[] arrayTest = new int[] { 1, 2, 3 };
            Assert.AreEqual(4, testMissingInteger.Solution(arrayTest));
        }

        [TestMethod()]
        public void MissingIntegerSolutionTestWithNegativeValues()
        {
            MissingInteger testMissingInteger = new MissingInteger();
            int[] arrayTest = new int[] {-1, -3 };
            Assert.AreEqual(1, testMissingInteger.Solution(arrayTest));
        }

        [TestMethod()]
        public void MissingIntegerSolutionTestWithoutOne()
        {
            MissingInteger testMissingInteger = new MissingInteger();
            int[] arrayTest = new int[] { -1000000, 1000000 };
            Assert.AreEqual(1, testMissingInteger.Solution(arrayTest));
        }

       
    }
}