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
    public class MinAvgTwoSliceTests
    {
        [TestMethod()]
        public void MinAvgTwoSliceSolutionTest()
        {
            MinAvgTwoSlice testMinAvgTwoSlice = new MinAvgTwoSlice();
            int[] arrayTest = new int[] { 4,2,2,5,1,5,8 };
            Assert.AreEqual(1, testMinAvgTwoSlice.Solution(arrayTest));
        }

        [TestMethod()]
        public void MinAvgTwoSliceSolutionTestWithNegativeValues()
        {
            MinAvgTwoSlice testMinAvgTwoSlice = new MinAvgTwoSlice();
            int[] arrayTest = new int[] { -3, -5, -8, -4, -10 };
            Assert.AreEqual(2, testMinAvgTwoSlice.Solution(arrayTest));
        }
    }
}