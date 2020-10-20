using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProcessamentoImagens
{
    public partial class BuscarPropriedade : Form
    {
        public BuscarPropriedade()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            string cnpj = txtCnpj.Text;
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT CNPJ_Propriedade FROM Propriedade WHERE CNPJ_Propriedade=@cnpj";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@cnpj", cnpj);

            //Conectar com o banco
            try
            {
                //o que o programa vai executar dentro do banco de dados
                //cmd.Connection vai receber o endereço do banco de dados
                cmd.Connection = conexao.Conectar();

                //Ler os dados no banco e comparar
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cnpj = reader["CNPJ_Propriedade"].ToString();
                    dgvResultados = 
                }

                else
                {
                    MessageBox.Show("CNPJ INEXISTENTE!!");
                }
                reader.Close();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
            }
            catch (SqlException ex)
            {

                //caso de algum erro ja na conexão o programa ja pula para o cath
                //para tentar resolver
                MessageBox.Show("ERRO AO SE CONECTAR COM O BANCO!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaInicio telaInicio = new TelaInicio();
            telaInicio.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCnpj.Clear();
            txtResultados.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaInicio telaInicio = new TelaInicio();
            telaInicio.Show();
            this.Hide();
        }
    }
}
