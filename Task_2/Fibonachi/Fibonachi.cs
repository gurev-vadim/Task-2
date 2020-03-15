using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Fibonachi
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonachi:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonach(n));
            Console.Read();
        }
        static int Fibonach(int n)
        {
            if (n < 2) return n;
            return Fibonach(n - 1) + Fibonach(n - 2);
        }

    }
}
