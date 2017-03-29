using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Cliente
    {
        public int id;
        public String nome;
        public String cidade;

        public Cliente() {
            this.cidade = "Mogi Mirim";
        }
        public Cliente(String cidade) {
            this.cidade = cidade;
        }
    }
}
