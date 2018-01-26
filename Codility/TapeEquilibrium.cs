using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class TapeEquilibrium
    {
        public int Solution(int[] A)
        {
            long sumleft = A[0];
            long sumright = A.Sum() - A[0]; 
            long minDiff = Math.Abs(sumright - sumleft);
            long thisDiff = 0;
            for (int i = 1; i < A.Length - 1; i++)
            {
                sumleft = sumleft + A[i];
                sumright = sumright - A[i];
                thisDiff = Math.Abs(sumright - sumleft);
                if (thisDiff < minDiff)
                {
                    minDiff = thisDiff;
                }
            }
            return (int)minDiff;
        }
    }
}
