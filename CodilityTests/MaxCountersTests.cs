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
    public class MaxCountersTests
    {
        [TestMethod()]
        public void MaxCountersSolutionTest()
        {
            MaxCounters testMaxCounters = new MaxCounters();
            int[] arrayTest = new int[] { 3, 4, 4, 6, 1, 4, 4 };
            int[] result = new int[] {3, 2, 2, 4, 2 };
            Assert.IsTrue(result.SequenceEqual(testMaxCounters.Solution(5, arrayTest)));
        }
    }
}