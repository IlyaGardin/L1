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
            Console.WriteLine("Введите колличество треугольников: ");
            int l;
            if (int.TryParse(Console.ReadLine(), out l) && l>0 && l < int.MaxValue)
            {

                for (int n = 1; n <= l; n++)
                {
                    int k = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 0; j < (n - i) + (l - n); j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < k; j++)
                        {
                            Console.Write("*");
                        }
                        k += 2;
                        Console.WriteLine();
                    }

                }
            }
            else
            {
                Console.WriteLine("Некорректно введено колличество треугольников.");
            }
        }
    }
}
