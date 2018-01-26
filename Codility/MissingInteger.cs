using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MissingInteger
    {
        public int Solution(int[] A)
        {

            int[] B = A.Distinct().ToArray();
            Array.Sort(B);

            if ((B[B.Length - 1] <= 0) || (B[0] > 1))
                return 1;

            bool foundOne = false; 

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == 1)
                    foundOne = true;

                if (B[i] > 0 && ((i +1 ) < B.Length))
                {
                    if (B[i + 1] - B[i] > 1)
                        return B[i] + 1;
                }
            }

            if (!foundOne)
                return 1;

            return B[B.Length -1] + 1;

        }

    }
}
