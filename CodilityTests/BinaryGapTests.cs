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
    public class BinaryGapTests
    {
        [TestMethod()]
        public void SolutionTestWithGap0()
        {
            BinaryGap binaryTest = new BinaryGap();
            Assert.AreEqual(0, binaryTest.Solution(15));
        }

        [TestMethod()]
        public void SolutionTestWithGap1()
        {
            BinaryGap binaryTest = new BinaryGap();
            Assert.AreEqual(1, binaryTest.Solution(20));
        }

        [TestMethod()]
        public void SolutionTestWithGap2()
        {
            BinaryGap binaryTest = new BinaryGap();
            Assert.AreEqual(2, binaryTest.Solution(9));
          
        }

        [TestMethod()]
        public void SolutionTestWithGap4()
        {
            BinaryGap binaryTest = new BinaryGap();
            Assert.AreEqual(4, binaryTest.Solution(529));
        }
    }
}