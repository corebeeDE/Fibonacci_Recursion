using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwn_FibonacciRecursion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Fibonacci works like this: f_n = f_n-1 + f_n-2 for n >= 3.");
            Console.Write("Give me your Fibonacci index: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Fibonacci number at index {index} is {RecurseFibonacci(0, 1, index-2, 0)}");
            Console.ReadKey();
        }

        private static int RecurseFibonacci(int num1, int num2, int index, int counter)
        {
            return index + 2 == 0 ? 0 : index + 2 == 1 || index + 2 == 2 ? 1 : index == counter ? num1 + num2 : RecurseFibonacci(num2, num1 + num2, index, ++counter);
        }
    }
}