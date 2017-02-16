using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1602d
{
    class Program
    {
        static void Main(string[] args)
        {
            int termo = 3;
            int p = 1;
            Console.WriteLine("1. Termo: " + p);
            int s = 1;
            Console.WriteLine("2. Termo: " + s);
            int prox;
            while (termo <= 30) {
                prox = p + s;
                Console.WriteLine(termo + ". Termo: " + prox);
                p = s;
                s = prox;
                termo++;
            }
            Console.ReadKey();
        }
    }
}
