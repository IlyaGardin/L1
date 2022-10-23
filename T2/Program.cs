using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество строк: ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n) && n>0 && n < int.MaxValue)
            {
                int k = 1;
                for (int i = 1; i <= n; i++)
                {

                    for (int j = 0; j < k; j++)
                    {
                        Console.Write("*");
                    }
                    k += 2;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Некорректно введено колличество строк.");
            }
        }
    }
}