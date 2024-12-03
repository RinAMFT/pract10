using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static double Function(int x)
        {
            return (Math.Sqrt(x) + x) / 2;

        }
        static void Main(string[] args)
        {
            Console.WriteLine($"y={Function(5) + Function(12) + Function(19)}");
            Console.ReadKey();
        }
    }
}
