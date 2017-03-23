using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCorrecao
{
    public class Conta
    {
        public int idConta;
        public double saldo;
        public Cliente cliente;
        public Agencia agencia;

        public Conta()
        {
            cliente = new Cliente();
            agencia = new Agencia();
        }

        public bool sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public bool depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                return true;
            }
            return false;
        }
    }
}
