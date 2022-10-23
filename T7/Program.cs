using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a, b, c;
            Console.WriteLine("Введите первое число: ");
            if (byte.TryParse(Console.ReadLine(), out a) && a>0)
            {
                Console.WriteLine("Введите второе число: ");
                if (byte.TryParse(Console.ReadLine(), out b) && b>0)
                {
                    Console.WriteLine(c = (byte)(a & b));
                    Console.WriteLine(c = (byte)(a | b));
                    Console.WriteLine(c = (byte)(a ^ b));
                }
                else { Console.WriteLine("Некорректно введено второе число."); }
            }
            else { Console.WriteLine("Некорректно введено первое число."); }
        }
    }
}
