using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nastlade_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Övn 1
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("o#");
                }
                Console.WriteLine();
            }
            */

            /*
            //Övn 2
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if ((y % 2) == 0)
                        Console.Write("#o");
                    else
                        Console.Write("o#");
                }
                if ((y % 2) == 0)
                    Console.WriteLine("#");
                else
                    Console.WriteLine("o");
            }
            */

            //Övn 3
            for (int i = 0; i < 10; i++)
            {
                for (int x = 10; x > i; x--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
