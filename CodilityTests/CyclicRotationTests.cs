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
    public class CyclicRotationTests
    {
        [TestMethod()]
        public void CyclicRotationSolutionTest()
        {
            CyclicRotation testRotation = new CyclicRotation();
            int[] arrayTest = new int[] { 3, 8, 9, 7, 6 };
            int[] result = new int[] { 9, 7, 6, 3, 8 };
            Assert.IsTrue(result.SequenceEqual(testRotation.Solution(arrayTest, 3)));
        }

        [TestMethod()]
        public void CyclicRotationSolutionTestWith1Rotation()
        {
            CyclicRotation testRotation = new CyclicRotation();
            int[] arrayTest = new int[] { 0, 0, 0 };
            int[] result = new int[] { 0, 0, 0 };
            Assert.IsTrue(result.SequenceEqual(testRotation.Solution(arrayTest, 1)));
        }

        [TestMethod()]
        public void CyclicRotationSolutionTestWith4Rotation()
        {
            CyclicRotation testRotation = new CyclicRotation();
            int[] arrayTest = new int[] { 1, 2, 3, 4 };
            int[] result = new int[] { 1, 2, 3, 4 };
            Assert.IsTrue(result.SequenceEqual(testRotation.Solution(arrayTest, 4)));
        }

        [TestMethod()]
        public void CyclicRotationSolutionTestWithNegativeValues()
        {
            CyclicRotation testRotation = new CyclicRotation();
            int[] arrayTest = new int[] { 1, -2, 3, -4 };
            int[] result = new int[] { 1, -2, 3, -4 };
            Assert.IsTrue(result.SequenceEqual(testRotation.Solution(arrayTest, 4)));
        }
    }
}