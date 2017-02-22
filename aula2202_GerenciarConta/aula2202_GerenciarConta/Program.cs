using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2202_GerenciarConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta objConta;
            objConta = new Conta();
            //Representar a conta do Daniel
            objConta.numero = 123;
            //objConta.limite = 1500.0;
            //Depositar 500
            bool depositou = objConta.depositar(-500.0);
            if (depositou)
            {
                Console.WriteLine("Deposito efetuado");
            }
            else
            {
                Console.WriteLine("Valor indevido");
            }
            bool sacou = objConta.sacar(800.0);
            objConta.gerarExtrato();
            Console.ReadKey();

        }
    }
}
