using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjSuporteCorrecao
{
    public class Suporte
    {
        public long NumMaquina { get; set; }
        public string NomeEquipamento { get; set; }
        public string DescricaoProblema { get; set; }
        public GrauSatisfacao Grau { get; set; }

        public bool gravarArquivo(string caminho)
        {
            bool isErr = false;
            try
            {
                //Preparando o texto que será gravado.
                StringBuilder texto = new StringBuilder();
                texto.AppendLine("Número da Máquina Com Problema: ").AppendLine(NumMaquina.ToString());
                texto.AppendLine("Nome do Equipamento: ").AppendLine(NomeEquipamento);
                texto.AppendLine("Descrição do Problema: ").AppendLine(DescricaoProblema);
                texto.AppendLine("Grau de Satisfação: ").AppendLine(Grau.ToString());
                texto.AppendLine("Data e Hora da Ocorrência: ");
                texto.Append(DateTime.Now.ToShortDateString()).Append(" - ").AppendLine(DateTime.Now.ToShortTimeString());

                //Criar o arquivo no caminho e adicionar o texto acima
                TextWriter escritor = new StreamWriter(caminho);
                escritor.WriteLine(texto.ToString());
                escritor.Close();

            }
            catch (Exception ex)
            {
                isErr = true;
                throw;
            }
            return isErr;
        }
    }
}
