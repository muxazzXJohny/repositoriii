using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a= int.Parse(Console.ReadLine());
            double b= Func (a);
            Console.WriteLine($"b={b}"); 
            Console.ReadLine();


        }
        public static double Func(double a)
        {
            return 12 * Math.Pow(a, 2) + 7 * a - 6;
        }
    }
}
