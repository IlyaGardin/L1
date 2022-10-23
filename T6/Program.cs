using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите длину стороны a:  ");
            if (double.TryParse(Console.ReadLine(), out a) && a > 0 )
            {
                Console.WriteLine("Введите длину стороны b:  ");
                if (double.TryParse(Console.ReadLine(), out b) && b > 0 )
                {
                    Console.WriteLine("Введите длину стороны c:  ");
                    if (double.TryParse(Console.ReadLine(), out c) && c > 0 && (a + b > c && b + c > a && a + c > b))
                    {
                        double p = (a + b + c) / 2;
                        double summ = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine(summ);
                    }
                    else { Console.WriteLine("Неверно введена сторона с."); }
                }
                else { Console.WriteLine("Неверно введена сторона b."); }
            }
            else { Console.WriteLine("Неверно введена сторона a."); }
        }
    }
}
