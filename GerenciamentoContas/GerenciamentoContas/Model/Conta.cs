using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoContas.Model
{
    public class Conta
    {
        public int NumConta { get; set; }
        public String NomeCliente { get; set; }
        public double Saldo { get; set; }

        //Métodos
        public void depositar(double valor)
        {
            try
            {
                //Regra - Valor não pode ser negativo
                if(valor<0)
                {
                    //Dispara uma exceção
                    throw new ArgumentException("Valor não pode ser negativo");
                }
                Saldo += valor;
            }
            catch (ArgumentException erro)
            {
                throw erro;
            }
            
        }

        public void sacar(double valor)
        {
            Saldo -= valor;
        }

    }
}
