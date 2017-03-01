using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula0103a
{
    class Computador
    {
        //Atributos
        public String marca;
        public String cor;
        public String modelo;
        public long numeroSerie;
        private double preco;

        //Métodos
        public String imprimir()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Computador Marca: ");
            sb.AppendLine(marca);
            sb.AppendLine("Modelo: ");
            sb.AppendLine(modelo);
            sb.AppendLine("Número de Série: ");
            sb.AppendLine(numeroSerie.ToString());
            sb.AppendLine("Preço Atual: ");
            sb.AppendLine(preco.ToString());
            return sb.ToString();
        }
        public void calcularValor()
        {
            if (marca.Equals("HP"))
            {
                preco *= 1.30;
                return;
            }
            if (marca.Equals("IBM"))
            {
                preco *= 1.40;
                return;
            }
        }
        public int alterarValor(double valor)
        {
            if (valor <= 0)
            {
                return 2;
            }
            preco = valor;
            return 1;
        }

    }
}
