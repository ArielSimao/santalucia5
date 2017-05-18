using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSobrescrita
{
    public class Gerente : Funcionario
    {
        public String Autonomia { get; set; }

        //Método imprimir de um Gerente
        public override string toPrint()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine(base.toPrint());
            texto.AppendLine("Autonomia: " + Autonomia);
            return texto.ToString();
        }
    }
}
