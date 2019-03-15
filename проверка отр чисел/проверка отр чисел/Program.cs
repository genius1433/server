using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проверка_отр_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
                if (mass[i] < 0)
                {
                    try
                    {
                        throw new Exception();
                    }
                    catch
                    {

                        Console.WriteLine("ЭЭЭЭЭЭЭЭЭЭ введи плюс число");
                        

                    }
                    mass[i] = int.Parse(Console.ReadLine());
                }
                
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            Console.ReadLine();
        }
    }
}
