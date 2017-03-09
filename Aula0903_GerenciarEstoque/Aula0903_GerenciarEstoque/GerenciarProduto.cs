using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0903_GerenciarEstoque
{
    public class GerenciarProduto
    {
        public bool entrada(Produto p, int qtd)
        {
            if (qtd > 0)
            {
                p.quantidade += qtd;
                return true;
            }
            return false;
        }
        public bool saida(Produto p, int qtd)
        {
            if (qtd <= p.quantidade)
            {
                p.quantidade -= qtd;
                return true;
            }
            return false;
        }
        public int imprimirQuantidadeDisponivel(Produto p)
        {
            return p.quantidade;
        }
    }
}
