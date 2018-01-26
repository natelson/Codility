using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class BinaryGap
    {
        public int Solution(int N)
        {
            int gap = 0;
            int gapMax = 0;
            bool firstOne = false;
            while(N > 0)
            {
                if (N % 2 == 0)
                {
                    if(firstOne)
                        gap = gap + 1;
                }
                else
                {
                    if(!firstOne)
                    {
                        firstOne = true;
                    }
                    else
                    {
                        gapMax = Math.Max(gap, gapMax);
                    }
                    gap = 0;
                }
                N /= 2;
            }
            return gapMax;
        }
    }
}
