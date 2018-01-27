using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class PassingCars
    {
        public int Solution(int[] A)
        {
            int passingCars = 0;
            int carEast = 0;
            foreach (int car in A)
            {
                if (car == 0)
                {
                    carEast = carEast + 1;
                }
                if (carEast > 0)
                {
                    if (car == 1)
                    {
                        passingCars = passingCars + carEast;
                        if (passingCars > 1000000000)
                        {
                            return -1;
                        }
                    }
                }
            }
            return passingCars;

        }
    }
}
