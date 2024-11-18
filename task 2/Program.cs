using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());
            int result = Sum(a, b);  
            Console.WriteLine($"Сумма = {result}"); 
            Console.ReadKey();
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
    
}
