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
    public class PermMissingElemTests
    {
        [TestMethod()]
        public void PermMissingElemSolutionTest()
        {
            PermMissingElem permMissingElem = new PermMissingElem();
            int[] arrayTest = new int[] { 2,3,1,5 };
            Assert.AreEqual(4, permMissingElem.Solution(arrayTest));
        }
    }
}