using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoEstacionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString =
                    ConfigurationManager.ConnectionStrings["EstacionamentoConn"].ConnectionString;
                //1. Abrindo a Conexao
                conn.Open();

                //2. Preparar a consulta para trazer os itens
                SqlDataAdapter da = new SqlDataAdapter("Select * From Veiculo", conn);

                //3. definir um Objeto para os dados (DataSet)
                DataSet ds = new DataSet("Veiculo");

                //4. criar um DataTable
                DataTable dt = new DataTable();

                //5. Preencer a tabela pelo adaptador
                da.Fill(dt);

                //6. atribuir o datatable ao grid
                dataGridView1.DataSource = dt;

                //7. Fechar a conexao
                conn.Dispose();
                conn.Close();

            }
        }
    }
}
