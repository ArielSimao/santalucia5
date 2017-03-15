using Aula1503Forms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1503Forms.Persistence
{
    public class AlunoBus
    {
        public List<Aluno> lista;

        public AlunoBus()
        {
            lista = new List<Aluno>();
        }

        public void adicionar(Aluno aluno)
        {
            lista.Add(aluno);
        }
        public List<Aluno> exibirLista()
        {
            return lista;
        }
    }
}
