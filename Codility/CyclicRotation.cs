using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CyclicRotation
    {
        public int[] Solution(int[] A, int K)
        {
            for(int i =0; i < K; i++)
            {
                A = Rotate(A);
            }
            return A;
           
        }

        private int[] Rotate(int[] a)
        {
            int last = a.Length - 1;
            for(int i = 0; i < last; i++ )
            {
                a[i] ^= a[last];
                a[last] ^= a[i];
                a[i] ^= a[last];

            }
            return a;
        }
       
    }
}
