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
    public class FrogRiverOneTests
    {
        [TestMethod()]
        public void FrogRiverOneSolutionTest()
        {
            FrogRiverOne testPermCheck = new FrogRiverOne();
            int[] arrayTest = new int[] { 1,3,1,4,2,3,5,4 };
            Assert.AreEqual(6, testPermCheck.Solution(5, arrayTest));
        }
    }
}