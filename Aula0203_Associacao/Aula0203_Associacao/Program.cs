using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0203_Associacao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito cc = new CartaoCredito();
            cc.numCartao = 1234545;
            cc.validade = DateTime.Now.AddYears(4);
            cc.cliente.nome = "Chico";
            cc.cliente.email = "emaildochico@email.com";
            cc.cliente.idCliente = 1;
            cc.cliente.imprimir();
            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
