using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        public static double Function(int x, int a)
        {
            return (Math.Sqrt(x) + x) / (Math.Sqrt(a) + a);

        }
        static void Main(string[] args)
        {
            Console.WriteLine($"y={Function(5, 7) + Function(12, 8) + Function(19, 2)}");
            Console.ReadKey();
        }
    }
}
