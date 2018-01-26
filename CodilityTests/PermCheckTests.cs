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
    public class PermCheckTests
    {
        [TestMethod()]
        public void PermCheckSolutionTest()
        {
            PermCheck testPermCheck = new PermCheck();
            int[] arrayTest = new int[] { 4,1,3,2 };
            Assert.AreEqual(1, testPermCheck.Solution(arrayTest));
        }

        [TestMethod()]
        public void PermCheckSolutionTestNoPermutation()
        {
            PermCheck testPermCheck = new PermCheck();
            int[] arrayTest = new int[] { 4, 1, 3 };
            Assert.AreEqual(0, testPermCheck.Solution(arrayTest));
        }
    }
}