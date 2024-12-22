using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckFermat();
        }

        public static void CheckFermat()
        {

            for (int n = 1; n < 4; n++)
            {
                for (int a = 1; a < 10; a++)
                {
                    for (int b = 1; b < 10; b++)
                    {
                        for (int c = 1; c < 10; c++)
                        {
                            if (CheckFermat(a, b, c, n))
                            {
                                Console.WriteLine($"{a}^{n} + {b}^{n} = {c}^{n} - Решение найдено");
                            }
                        }
                    }
                }
            }
        }

        public static bool CheckFermat(int a, int b, int c, int n)
        {
            if (a == 0 && b == 0 && c == 0)
            { return false; }
            return Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n);
        }
    }
}
