using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            bool x=false;
            a /= a;

            int[] vetor = new int[5];
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i;
            }
            foreach (int item in vetor)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(a);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
