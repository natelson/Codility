using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class FrogJmp
    {
        public int Solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling((double)Math.Abs(X - Y) / (double)D);
        }
    }
}
