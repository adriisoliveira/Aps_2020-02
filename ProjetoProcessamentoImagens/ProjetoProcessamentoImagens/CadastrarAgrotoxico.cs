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
    public partial class CadastrarAgrotoxico : Form
    {
        public CadastrarAgrotoxico()
        {
            InitializeComponent();
        }
        private void CadastrarAgrotoxico_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            txtUsuario.Text = Global.UsuarioLogado;
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
            txtDescricao.Clear();
            txtComposicao.Clear();
            txtPermissao.Clear();
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
                cmd.CommandText = "INSERT INTO Agrotoxico (Nome_Agrotoxico,Descricao,Classificacao,Composicao,Permissao) values ('" +txtNome.Text+ "', '" + txtDescricao.Text + "','" + lbxClassificacao.Text + "',+'" + txtComposicao.Text + "','" + txtPermissao.Text + "')";
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
