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
using System.IO;

namespace ProjetoProcessamentoImagens
{
    public partial class CadastrarUsuarios : Form
    {
        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;
        OpenFileDialog openFile = new OpenFileDialog();
        public CadastrarUsuarios()
        {
            InitializeComponent();
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
            pbxBiometria.Image = null;
        }



        protected void CarregaImagem()
        {
            try
            {

                openFile.ShowDialog(this);
                openFile.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";
                string strFn = openFile.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                pbxBiometria.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                cmd.CommandText = "INSERT INTO Usuario (Biometria,Nome,Telefone,Tipo_Acesso,UsuarioLogin,Senha) values (@imagem, '" + txtNome.Text + "','" + txtTelefone.Text + "',+'" + cbxAcesso.Text.Substring(0,1) + "','" + txtNomeUsuario.Text + "','" + txtSenha.Text + "')";
                cmd.Parameters.AddWithValue("@imagem", vetorImagens);

                int iresultado = cmd.ExecuteNonQuery();

                if (iresultado <= 0)
                    MessageBox.Show("Falha ao incluir imagem no banco de dados.");


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

        private void CadastrarUsuarios_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Global.UsuarioLogado;
        }

        private void btnCadastrarBiometria_Click(object sender, EventArgs e)
        {
            try
            {

                openFile.ShowDialog(this);
                openFile.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";
                string strFn = openFile.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                pbxBiometria.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
