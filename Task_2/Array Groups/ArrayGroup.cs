using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Groups
{
    class ArrayGroup
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var grouping = from number in numbers
                                     group number by number % 2;
            foreach (var group in grouping)
            {
                Console.WriteLine(group.Key == 0 ? "Четные числа:" : "Неченые числа:");
                Console.WriteLine("{0}", string.Join(" ", group));
                Console.WriteLine(" ");
            }
            Console.Read();
        }
    }
}
