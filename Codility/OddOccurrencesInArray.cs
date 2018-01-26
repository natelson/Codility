using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class OddOccurrencesInArray
    {
        public int Solution(int[] A)
        {
            int comparation = 0;
            foreach (var i in A)
                comparation ^= i;

            return comparation;
        }
    }
}
