using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MaxCounters
    {
        public int[] Solution(int N, int[] A)
        {
            int[] result = new int[N];
            int maximum = 0;
            int resetLimit = 0;

            for (int K = 0; K < A.Length; K++)
            {
                if (A[K] < 1 || A[K] > N + 1)
                    throw new InvalidOperationException();

                if (A[K] >= 1 && A[K] <= N)
                {
                    if (result[A[K] - 1] < resetLimit)
                    {
                        result[A[K] - 1] = resetLimit + 1;
                    }
                    else
                    {
                        result[A[K] - 1]++;
                    }

                    if (result[A[K] - 1] > maximum)
                    {
                        maximum = result[A[K] - 1];
                    }
                }
                else
                {
                    resetLimit = maximum;
                }
            }

            for (int i = 0; i < result.Length; i++)
                result[i] = Math.Max(resetLimit, result[i]);

            return result;
        }
    }
}
