using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0903_GerenciarEstoque
{
    public class Produto
    {
        public int codigo;
        public String descricao;
        public int quantidade;
        public double preco;

        public void imprimir()
        {
            Console.WriteLine("Produto: " + descricao);
            Console.WriteLine("Possui " + quantidade +
                " em estoque");
            Console.WriteLine("");
        }
    }
}
