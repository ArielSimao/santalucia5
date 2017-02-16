using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1602A
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 2017;
            for (int i = 1; i <=100; i++)
            {
                //Imprimi primeiro, depois subtrai.
                Console.WriteLine(ano--);
            }
            Console.ReadKey();
        }
    }
}
