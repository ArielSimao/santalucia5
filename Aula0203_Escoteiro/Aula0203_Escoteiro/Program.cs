using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0203_Escoteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Escoteiro e1, e2;
            e1 = new Escoteiro();
            Console.WriteLine("Digite o nome do escoteiro: ");
            e1.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            e1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sexo: ");
            e1.sexo = Console.ReadLine();
            Console.WriteLine("Digite o medicamento que usa: ");
            e1.medicacao = Console.ReadLine();
            Console.WriteLine("Informe observações: ");
            e1.observacao = Console.ReadLine();
            Console.WriteLine(e1.imprimir());
            e1.separarGrupo();
            Console.WriteLine(e1.imprimir());
           
            Console.ReadKey();

        }
    }
}
