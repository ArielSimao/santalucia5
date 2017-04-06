using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadPecas.Model
{
    public class Peca
    {
        public int CodPeca { get; set; }
        public String Descricao { get; set; }
        public double Valor { get; set; }

        //Método de négocio. Aumento do preco
        public void aumentarValor(double preco)
        {
            this.Valor += preco;
        }
    }
}
