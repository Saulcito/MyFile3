using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, output;
            Console.WriteLine("Enter a three-digit number");
            input = Convert.ToInt32(Console.ReadLine());
            output = (input % 10 * 100 + (input % 100 / 10 * 10) + (input / 100));
            Console.WriteLine($"{input} --> {output}");
            Console.ReadKey();
        }
    }
}
