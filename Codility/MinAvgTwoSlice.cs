using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MinAvgTwoSlice
    {
        public int Solution(int[] A)
        {
            int minIndex = 0;
            double minAvg = 100001.0;

            for (int i = 0; i < A.Length - 1; i++)
            {

                if (((A[i] + A[i + 1]) / 2.0) < minAvg)
                {
                    minIndex = i;
                    minAvg = (A[i] + A[i + 1]) / 2.0;

                }
                if (i < A.Length - 2)
                {
                    if (((A[i] + A[i + 1] + A[i + 2]) / 3.0) < minAvg)
                    {
                        minIndex = i;
                        minAvg = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                    }
                }
            }

            return minIndex;
        }
    }
}
