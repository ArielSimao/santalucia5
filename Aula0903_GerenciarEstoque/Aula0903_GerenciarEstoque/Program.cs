using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0903_GerenciarEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto()
            {
                codigo = 1,
                descricao = "Fanta Uva",
                quantidade = 100,
                preco = 4.98
            };
            Produto p2 = new Produto()
            {
                codigo = 2,
                descricao = "Fanta Laranja",
                quantidade = 150,
                preco = 4.99
            };
            GerenciarProduto gerenciar = new GerenciarProduto();
            bool r = gerenciar.entrada(p1, 500);
            if (r)
                Console.WriteLine("Entrada efetuada com sucesso");
            else
                Console.WriteLine("Valor inválido");
            p1.imprimir();
            Console.ReadKey();
        }
    }
}
