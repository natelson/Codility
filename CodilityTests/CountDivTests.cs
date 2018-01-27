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
    public class CountDivTests
    {
        [TestMethod()]
        public void CountDivSolutionTest()
        {
            CountDiv countDivTest = new CountDiv();
            Assert.AreEqual(1, countDivTest.Solution(6,11,7));
        }

        [TestMethod()]
        public void CountDivSolutionTestWithValueEquals()
        {
            CountDiv countDivTest = new CountDiv();
            Assert.AreEqual(0, countDivTest.Solution(10, 10, 7));
        }

        [TestMethod()]
        public void CountDivSolutionTestWithValueZero()
        {
            CountDiv countDivTest = new CountDiv();
            Assert.AreEqual(1, countDivTest.Solution(0, 0, 11));
        }
    }
}