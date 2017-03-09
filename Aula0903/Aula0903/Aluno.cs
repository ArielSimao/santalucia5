using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0903
{
    public class Aluno
    {
        public int ra;
        public String nome;

        public void imprimir()
        {
            Console.WriteLine("Ra: " + ra);
            Console.WriteLine("Nome: " + nome);
        }
    }
}
