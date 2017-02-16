using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1602c
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=100; i++)
            {
                if (i % 4 != 0)
                {
                    Console.WriteLine(i);
                }
                else {
                    Console.WriteLine("M4");
                }
            }
            Console.ReadKey();
        }
    }
}
