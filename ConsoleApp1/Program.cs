using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Max(int x, int y)
        {
            return (x > y) ? x : y;
        }
        static void Main(string[] args)
        {
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());
            Console.Write("z=");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine($"max={Max(Max(x, y), z)}");
            Console.ReadKey();
        }
    }
}
