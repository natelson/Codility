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
    public class FrogJmpTests
    {
        [TestMethod()]
        public void FrogJmpSolutionTest()
        {
            FrogJmp frogJmpTest = new FrogJmp();
            Assert.AreEqual(3, frogJmpTest.Solution(10, 85, 30));
        }
    }
}