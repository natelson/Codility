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
    public class GenomicRangeQueryTests
    {
        [TestMethod()]
        public void GenomicRangeQuerySolutionTest()
        {
            GenomicRangeQuery testGenomicRangeQuery = new GenomicRangeQuery();
            int[] arrayP = new int[] { 2,5,0 };
            int[] arrayQ = new int[] { 4,5,6 };
            string s = "CAGCCTA";
            int[] result = new int[] { 2,4,1 };
            Assert.IsTrue(result.SequenceEqual(testGenomicRangeQuery.Solution(s, arrayP, arrayQ)));
        }
    }
}