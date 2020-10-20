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
    public partial class CadastroProprietario : Form
    {
        public CadastroProprietario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BuscarProprietario buscarProprietario = new BuscarProprietario();
            buscarProprietario.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtRg.Clear();
            txtCpf.Clear();
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
                cmd.CommandText = "INSERT INTO Proprietario (Nome_Proprietario,Email_Proprietario,Telefone_Proprierario,CPF_Proprietario,RG_Proprietario) values ('" +txtNome.Text+ "','" +txtEmail.Text+ "',+'" +txtTelefone.Text + "','"+ txtCpf.Text + "','" + txtRg.Text + "')";
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
