using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCorrecao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.idConta = 1;
            c.cliente.idCliente = 1;
            c.cliente.nomeCliente = "Chico";
            c.agencia.idAgencia = 123;
            c.agencia.nomeAgencia = "Mogi Mirim";
            c.agencia.cidadeAgencia = "Mogi Mirim";
            c.agencia.estadoAgencia = "São Paulo";
            c.agencia.telefoneAgencia = "99-9999-9999";
            //Abreviação
            if (c.depositar(500))
            {
                Console.WriteLine("Deposito efetuado com sucesso");
            }
            else
            {
                Console.WriteLine("Deposito deve ser positivo");
            }
            if (c.sacar(1000))
            {
                Console.WriteLine("Saque efetuado com sucesso");
            }
            else
            {
                Console.WriteLine("Limite não disponível");
            }
            Console.WriteLine("Saldo atual R$ " + c.saldo);
            Console.ReadKey();

        }
    }
}
