using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1602b
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i + "*");
                }
                else
                {
                    Console.WriteLine(i + "**");
                }
            }
            Console.ReadKey();
        }
    }
}
