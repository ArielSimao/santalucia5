using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSobrescrita
{
    public class Operador : Funcionario
    {
        public int QuantidadeHoras { get; set; }

        public override string toPrint()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine(base.toPrint());
            texto.AppendLine("Quantidade de Horas: " + QuantidadeHoras);
            return texto.ToString();
        }
    }
}
