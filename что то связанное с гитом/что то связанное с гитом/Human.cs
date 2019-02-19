using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace что_то_связанное_с_гитом
{
    class Human
    {
        private int age;
        public string Name { get; set; } = "";
        public int Age
        {
            set
            {
                if (value < 0)
                    age = 0;
                else
                    age = value;
            }
            get
            {
                return age;
            }
        }
        public void Say()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(age + " " + Name);
        }
    }
}
