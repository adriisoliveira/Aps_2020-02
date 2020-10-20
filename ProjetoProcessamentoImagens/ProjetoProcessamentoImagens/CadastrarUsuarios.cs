using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace ProjetoProcessamentoImagens
{
    public partial class CadastrarUsuarios : Form
    {
        public CadastrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnCadastrarBiometria_Click(object sender, EventArgs e)
        {
            AquisicaoBiometria aquisicaoBiometria = new AquisicaoBiometria();
            aquisicaoBiometria.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaInicio telaInicio = new TelaInicio();
            telaInicio.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtSenha.Clear();
            txtNomeUsuario.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            //Classe para poder escrever em sql 
            SqlCommand cmd = new SqlCommand();
           
            //Conectar com o banco
            try
            {
                cmd.Connection = conexao.Conectar();
                //Comandos SQL para inserir os dados no banco
                //Para escrever os comandos precisa da classe SqlCommand
                cmd.CommandText = "INSERT INTO Usuario (Biometria,Nome,Telefone,Tipo_Acesso,UsuarioLogin,Senha) values ('" + 00000 + "', '" + txtNome.Text + "','" + txtTelefone.Text + "',+'" + lbxTipoAcesso.Text + "','" + txtNomeUsuario.Text + "','" + txtSenha.Text + "')";
                cmd.ExecuteNonQuery();
                conexao.desconectar();

                MessageBox.Show("Cadastro feito com sucesso!!!");
            }
            catch (SqlException ex)
            {

                //caso de algum erro ja na conexão o programa ja pula para o cath
                //para tentar resolver
                MessageBox.Show("ERRO AO SE CONECTAR COM O BANCO!", ex.Message);
            }
        }
    }
}
