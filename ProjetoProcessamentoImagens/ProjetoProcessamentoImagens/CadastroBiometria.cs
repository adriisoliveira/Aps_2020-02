using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProcessamentoImagens
{
    public partial class CadastroBiometria : Form
    {
        CadastrarUsuarios usuarios = new CadastrarUsuarios();
        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;
        OpenFileDialog openFile = new OpenFileDialog();
        public CadastroBiometria()
        {
            InitializeComponent();
        }

        private void CadastroBiometria_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Global.UsuarioLogado;
        }

        public void Imagem()
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

        private void btnBuscarBiometria_Click(object sender, EventArgs e)
        {
            Imagem();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            usuarios.Show();
            this.Hide();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {






            MessageBox.Show("Digital cadastrada");
            usuarios.Show();
            this.Hide();
        }
    }
}
