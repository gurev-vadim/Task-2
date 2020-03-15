using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Factorials
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(n));
            Console.Read();
        }
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
