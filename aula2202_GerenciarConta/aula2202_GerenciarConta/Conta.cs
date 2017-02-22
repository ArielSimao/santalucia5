using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2202_GerenciarConta
{
    public class Conta
    {
        //1 - Definir atributos
        public int numero;
        public double limite;
        public double saldo;

        //1.1 - Definir o método especial
        //construtor da classe.
        public Conta()
        {
            limite = 200.0;
        }

        //2 - Definir os métodos
        public bool depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                return true;
            }
            return false;
        }
        public bool sacar(double valor)
        {
            if (valor <= (saldo + limite))
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public void gerarExtrato()
        {
            Console.WriteLine("Dados da conta: " + numero);
            Console.WriteLine("Saldo Atual: " + saldo);
            Console.WriteLine("Limite Disponível: " + limite);
        }
    }
}
