using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThirteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NbDig(5750, 0));
            Console.ReadKey();
        }
        public static int NbDig(int n, int d)
        {
            // n (n >= 0) n is positive integer
            // d (0 <= d <= 9) count d in k^2
            // k (0 <= k <= n) k is less than or equal to n

            int rem; // убрал ненужное значение. Было int rem = 0;
            int counter = 0;
            int k;

            for (int i = 0; i <= n; i++)
            {
                k = i * i;
                if (k == 0)
                {
                    rem = k % 10;
                    k = k / 10;

                    if (rem == d)
                    {
                        counter++;
                    }
                }
                while ( k != 0) // чтобы проверить одно число полностью // без while проверялась только последняя цифра
                {
                    rem = k % 10;
                    k = k / 10;

                    if (rem == d)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}