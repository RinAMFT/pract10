using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static int Max(int x, int y)
        {
            return (x > y) ? x : y;
        }
        static void Main(string[] args)
        {
            int x = Input("x=");
            int y = Input("y=");
            int c = Input("c=");
            int d = Input("d=");
            Console.WriteLine($"s={Max(x, y)+Max(c, d)}");
            Console.ReadKey();
        }
    }
}
