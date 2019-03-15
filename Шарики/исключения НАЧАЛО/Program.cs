using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace исключения_НАЧАЛО
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception();
                Console.WriteLine();
            }
            catch
            {

                Console.WriteLine("УЧИ МАТЧАСТЬ");
            }
            Console.ReadLine();
        }
    }
}
