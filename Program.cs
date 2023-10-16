using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.absolute_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6832;
            int num2 = (-392);

            int abs1 = Math.Abs(num1);
            int abs2 = Math.Abs(num2);

            Console.WriteLine("the absolute number of " + num1 + "is: " + abs1);
            Console.WriteLine("the absolute number of " + num2 + "is: " + abs2);
            Console.ReadLine();

        }
    }
}
