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
    public class OddOccurrencesInArrayTests
    {
        [TestMethod()]
        public void SolutionTestWith7()
        {
            OddOccurrencesInArray testOdd = new OddOccurrencesInArray();
            int[] arrayTest = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            Assert.AreEqual(7, testOdd.Solution(arrayTest));
        }

        [TestMethod()]
        public void SolutionTestWith13()
        {
            OddOccurrencesInArray testOdd = new OddOccurrencesInArray();
            int[] arrayTest = new int[] { 9, 3, 9, 3, 9, 7, 9, 7, 5, 4, 3, 4, 3 };
            Assert.AreEqual(5, testOdd.Solution(arrayTest));
        }
    }
}