using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040Assignment2
{
    public class TriangleSolver
    {

        public static string Analyze(int sideA, int sideB ,int sideC)
        {

            if ((sideA + sideB) >= (sideC) && (sideA + sideC) >= (sideB) && (sideB + sideC) >= sideA)
            {

                if (sideA == sideB && sideB == sideC)
                {
                    return ("This is a Equilateral Triangle.");
                }
                else if (sideA == sideB || sideA == sideC || sideB == sideC)
                {
                    return ("This is a Isocels Triangle.");
                }
                else
                {
                    return ("This is a Scalene Triangle.");
                }
            }
            else
            {
                return ("Triangle is Not Posibble.");
            }

        }
    }
}
