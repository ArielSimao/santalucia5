using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Editora
    {
        //Editora, Descrição, Contato, Telefone
        public int EditoraId { get; set; }
        public String Descricao { get; set; }
        public String Contato { get; set; }
        public String Telefone { get; set; }

        
        public Editora() { }

        
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
