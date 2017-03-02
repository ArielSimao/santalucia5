using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0203_Associacao
{
    public class CartaoCredito
    {
        public long numCartao;
        public DateTime validade;
        public Cliente cliente;

        //Método Construtor
        public CartaoCredito()
        {
            cliente = new Cliente();
        }
    }
}
