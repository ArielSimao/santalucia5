using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula0103a
{
    public class Program
    {
        static void Main(string[] args)
        {
            Computador x = new Computador();
            x.modelo = "Lenovo";
            x.marca = "IBM";
            x.cor = "Prata";
            x.numeroSerie = 123;
            Console.WriteLine("Digite o valor do computador " + x.modelo);
            int resposta = x.alterarValor(double.Parse(Console.ReadLine()));
            if (resposta == 1)
            {
                Console.WriteLine("Preço definido com sucesso...");
            }
            else
            {
                Console.WriteLine("Preço não definido...");
            }
            x.calcularValor();
            Console.WriteLine(x.imprimir());
            Console.ReadLine();

        }
    }
}
