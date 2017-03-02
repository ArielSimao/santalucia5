using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0203_Associacao
{
    public class Cliente
    {
        public int idCliente;
        public String nome;
        public String email;

        public void imprimir()
        {
            Console.WriteLine("ID: " + idCliente);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Email: " + email);
        }
        public void imprimir(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine();
            }
            imprimir();
        }
    }
}
