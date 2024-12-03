using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            int y = Input("y=");
            int x = Input("x=");
            Console.WriteLine($"max={Max(x, y)}");
            Console.ReadKey();
        }
    }
}
