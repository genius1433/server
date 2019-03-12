using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шарики
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            int result = 0;
            int c = 1;
            bool isend = false;
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            while (isend == false)
            {
                isend = true;
                for (int i = 0; i < mass.Length - 1; i++)
                {
                    if (mass[i] == mass[i + 1])
                    {
                        c++;
                    }
                    else
                    {
                        if (c >= 3)
                        {
                            result += c;
                            int[] tempmass = new int[mass.Length - c];
                            Array.Copy(mass, tempmass, i - c + 1);
                            Array.Copy(mass, i + 1, tempmass, i - c + 1, mass.Length - 1 - i);
                            mass = (int[])tempmass.Clone();
                            isend = false;
                            c = 1;
                            break;
                        }
                        c = 1;
                    }
                }
                if (c >= 3)
                {
                    result += c;
                    break;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
