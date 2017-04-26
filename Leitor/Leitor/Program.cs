using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Associar um StreamReader a um arquivo texto
            //C:\textos\entrada
            TextReader leitor = new StreamReader(@"C:\textos\entrada.txt");

            //Associar ao Teclado
            //leitor = System.Console.In;
            String linha = leitor.ReadLine();
            while (linha != null) {
                Console.WriteLine(linha);
                linha = leitor.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
