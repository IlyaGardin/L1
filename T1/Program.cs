using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pervoe_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту:");
            double a;
            double b;
            if (double.TryParse(Console.ReadLine(), out a) && a > 0 && a < int.MaxValue)
            {
                Console.WriteLine("Введите ширину:");                
                if (double.TryParse(Console.ReadLine(), out b) && b > 0 && b < int.MaxValue)
                {                    
                    Console.WriteLine("Площадь равна:" + a*b);                    
                }
                else
                {
                    Console.WriteLine("Неверно введена ширина");
                }
            }
            else
            {
                Console.WriteLine("Неверно введена высота");
            }


        }
    }
}
