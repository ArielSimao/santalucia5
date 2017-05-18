using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSobrescrita
{
    public abstract class Funcionario
    {
        public int RegFunc { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public double Salario { get; set; }

        //Método imprimir
        //Devolverá um String com os dados
        //do objeto
        public virtual String toPrint()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine("Registro: " + RegFunc);
            texto.AppendLine("Nome: " + Nome);
            texto.AppendLine("Email: " + Email);
            texto.AppendLine("Salario Base: " + Salario);
            return texto.ToString();
        }
    }
}
