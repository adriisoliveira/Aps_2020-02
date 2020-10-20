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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT UsuarioLogin, Senha FROM Usuario WHERE UsuarioLogin=@usuario and Senha=@senha";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

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
                    usuario = reader["UsuarioLogin"].ToString();
                    senha = reader["Senha"].ToString();
                    TelaInicio telaInicio = new TelaInicio();
                    telaInicio.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Login ou senha incorretos!");
                }
                reader.Close();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
            }
            catch (SqlException ex)
            {

                //caso de algum erro ja na conexão o programa ja pula para o cath
                //para tentar resolver
                MessageBox.Show("ERRO AO SE CONECTAR COM O BANCO!",ex.Message);
            }




            
        }
    }
}
