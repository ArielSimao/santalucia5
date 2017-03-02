using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0203_Escoteiro
{
    public class Escoteiro
    {
        public String nome;
        public int idade;
        public String sexo;
        public String medicacao;
        public String observacao;
        private String grupo;

        public String imprimir()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dados do Escoteiro ");
            sb.AppendLine("Nome: " + nome);
            sb.AppendLine("Idade: " + idade);
            sb.AppendLine("Sexo: " + sexo);
            sb.AppendLine("Medicamentos: " + medicacao);
            sb.AppendLine("Observações: " + observacao);
            sb.AppendLine("Esse escoteiro participa do Grupo: ");
            sb.AppendLine(grupo);
            return sb.ToString();
        }
        public void separarGrupo()
        {
            if(idade < 6)
            {
                grupo = "Sem participação";
                return;
            }
            if(idade<=10)
            {
                grupo = "Grupo A";
                return;
            }
            if (idade <= 20)
            {
                grupo = "Grupo B";
                return;
            }
            grupo = "Grupo Adulto";
        }
    }
}
