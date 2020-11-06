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

namespace TesteImagemBanco
{
    public partial class TesteImagem : Form
    {
        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;
        private SqlConnection conexaoSQLServer;
        SqlCommand sqlcmd = default(SqlCommand);

        OpenFileDialog openFile = new OpenFileDialog();

        private Conexao con;


        public TesteImagem()
        {
            InitializeComponent();
           con = new Conexao();

;
        }

        private void TesteImagem_Load(object sender, EventArgs e)
        {
            btnCarregarImagem.Enabled = true;
            btnObterImagem.Enabled = true;
            btnSalvarImagem.Enabled = true;
        }

        private void btnObterImagem_Click(object sender, EventArgs e)
        {
            if (txtCodigoImagem.Text == string.Empty)
            {
                MessageBox.Show("Informe o código da imagem no Banco de dados", "Código da Imagem",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.Conectar();
                string idImagem = txtCodigoImagem.Text;
                cmd.CommandText = ("select imagem from IMAGEM where ID=@idImagem");
                cmd.Parameters.Add("@idImagem", SqlDbType.Int, 4);
                cmd.Parameters["@idImagem"].Value = txtCodigoImagem.Text;

                
                byte[] vetorImagem = (byte[])cmd.ExecuteScalar();
                string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                fs.Write(vetorImagem, 0, vetorImagem.Length);
                fs.Flush();
                fs.Close();

                
                pbxImagem.Image = Image.FromFile(strNomeArquivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }
        void getImagensSQLServer(SqlConnection conexaoSQLServer)
        {
            try
            {
                //Inicializar o SQL adapter.
                SqlDataAdapter ADAP = new SqlDataAdapter("Select Id,DESCRICAO,IMAGEM from IMAGEM", conexaoSQLServer);

                //Inicializa o  Dataset.
                DataSet DS = new DataSet();

                //Preenche o dataset com a tabela Imagens
                ADAP.Fill(DS, "IMAGEM");

                //preenche o datagridviewe com o dataset.
                dgvBancoImagens.DataSource = DS.Tables["IMAGEM"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            CarregaImagem();
            txtCodigoImagem.Text = "";
            txtDescricaoImagem.Text = "";
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

                pbxImagem.Image = Image.FromFile(strFn);
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

        private void btnSalvarImagem_Click(object sender, EventArgs e)
        {

            
            
            if (string.IsNullOrEmpty(txtDescricaoImagem.Text))
            {
                MessageBox.Show("Informe a descrição da imagem", "Código da Imagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = "INSERT INTO IMAGEM (DESCRICAO,IMAGEM) values(@descricao,@imagem)";
                cmd.Parameters.Add("@descricao", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@imagem", System.Data.SqlDbType.Image);

  
                cmd.Parameters["@descricao"].Value = txtDescricaoImagem.Text;
                cmd.Parameters["@imagem"].Value = vetorImagens;

                int iresultado = cmd.ExecuteNonQuery();

                if (iresultado <= 0)
                    MessageBox.Show("Falha ao incluir imagem no banco de dados.");

                getImagensSQLServer(con.retornaConexao());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.desconectar();  
            }
        }

        private void dgvBancoImagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtem o codigo da imagem e exibe no controle textbox 
            txtCodigoImagem.Text = (dgvBancoImagens.Rows[e.RowIndex].Cells["id"].Value).ToString();
            txtDescricaoImagem.Text = "";
        }
    }
}
