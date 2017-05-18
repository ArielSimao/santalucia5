using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Livro
    {
        public int LivroId { get; set; }
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public int EditoraId { get; set; }

        [ForeignKey("EditoraId")]
        public virtual Editora Editora { get; set; }
    }
}
