using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0903
{
    class Program
    {
        public static void passagemRef(Aluno x)
        {
            x.ra = 22;
            x.nome = "Maria Joaquina";
        }
        static void Main(string[] args)
        {
            Aluno a1;
            Aluno a2 = new Aluno()
            {
                ra = 2,
                nome = "jose"
            };
            //Montar o objeto a1
            a1 = new Aluno()
            {
                ra = 1,
                nome = "Oscar Silva"
            };
            a2 = a1;
            passagemRef(a1);
            Console.WriteLine("dados do aluno a1..");
            a1.imprimir();
            Console.WriteLine("dados do aluno a2..");
            a2.imprimir();
            Console.ReadKey();
        }
    }
}
