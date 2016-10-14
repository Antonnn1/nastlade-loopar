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
            //Övn 1
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("o#");
                }
                Console.WriteLine();
            }
        }
    }
}
