using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class PermCheck
    {
        public int Solution(int[] A)
        {
            var set = new HashSet<int>();
            var max = int.MinValue;

            foreach (var item in A)
            {
                if (set.Contains(item)) return 0;

                set.Add(item);

                if (item > max) max = item;
            }
            return set.Count == max ? 1 : 0;
        }
    }
}
