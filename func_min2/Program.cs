using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_min2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
        }

        private static string GetMinX(int a, int b, int c)
        {
            if (a > 0)
            {
                return ((double)-b / (2 * a)).ToString();
            }
            else
            {
                if (b == 0)
                {
                    return null;
                }
                else
                {
                    return "Impossible";
                }
            }
        }
    }
}
