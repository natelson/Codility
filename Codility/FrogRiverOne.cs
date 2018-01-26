using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class FrogRiverOne
    {
        public int Solution(int X, int[] A)
        {
            int[] B = A.Distinct().ToArray();
            return (B.Length != X) ? -1 : Array.IndexOf(A, B[B.Length - 1]);
        }
    }
}
