using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1502e
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer leitura de 10 valores
            float media=0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite o " + i + ". valor.");
                int x = Int16.Parse(Console.ReadLine());
                media += x;
            }
            media /= 10;
            Console.WriteLine("A media eh ---> " + media);
            Console.ReadKey();
        }
    }
}
