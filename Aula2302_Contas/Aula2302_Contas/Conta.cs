using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2302_Contas
{
    public class Conta
    {
        public String nomeCorrentista;
        public int contaCorrente;
        private double saldo;

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
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public double exibirSaldo()
        {
            return saldo;
        }

    }
}
