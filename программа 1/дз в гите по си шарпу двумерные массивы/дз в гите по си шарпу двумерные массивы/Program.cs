using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_в_гите_по_си_шарпу_двумерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] mass = new int[n, m];
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mass[i, j] =random.Next(2);
                }
            }
            for (int i = 0; 
                i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,-10}", mass[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i = i + 2)
            {
                for (int j = 0; j < m; j = j + 2)
                {
                    if (mass[i, j] == mass[i, j + 1])
                    {
                        if (mass[i, j + 1] == mass[i + 1, j] )
                        {
                            if (mass[i + 1, j] == mass[i + 1, j + 1])
                            {
                                temp = -1000000;
                            }
                            else
                            {
                                temp++;
                                //Console.WriteLine("YES");
                                //break;
                            }
                        }
                        else
                        {
                            temp++;
                        //    //Console.WriteLine("YES");
                        //    //break;
                        }
                    }
                    else
                    {
                        temp++;
                    //    //Console.WriteLine("YES");
                    //    //break;
                    }
                    
                }
            }
            if (temp > 0)
            {
                Console.WriteLine("YES");
            }
            else if (temp < 0)
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
