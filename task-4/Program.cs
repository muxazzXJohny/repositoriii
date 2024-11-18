using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма = {Sum(a, b)}");
            Console.WriteLine($"Разность = {difference(a, b)}");
            Console.WriteLine($"Произведение = {product(a, b)}");
            Console.WriteLine($"Частное = {division(a, b)}");
            Console.ReadLine();
            
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int difference(int a, int b)
        {
            return a - b;
        }
        public static int product(int a, int b)
        {
            return a * b;
        }
        public static int division(int a, int b)
        {
            return a / b;
        }


       
    }
}
