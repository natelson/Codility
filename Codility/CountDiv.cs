using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CountDiv
    {
        public int Solution(int A, int B, int K)
        {
            int totalNumbers = 0;
            int startValue = A;
            while (startValue <= B)
            {
                if (startValue % K == 0)
                {
                    totalNumbers = Math.Abs(((B - startValue) / K) + 1);
                    break;
                }
                else if (startValue / K == 0)
                {
                    startValue = K;
                }
                else
                {
                    startValue = startValue + (startValue % K);
                }
            }
            return totalNumbers;

        }
    }
}
