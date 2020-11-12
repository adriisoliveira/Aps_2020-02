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
using SourceAFIS.Simple;
using SourceAFIS.Extraction.Filters;


namespace ProjetoProcessamentoImagens
{
    public partial class VerificacaoBiometria : Form
    {
        Person pessoaBase;
        List<Person> pessoasBd;
        CadastrarUsuarios usuarios = new CadastrarUsuarios();
        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;
        OpenFileDialog openFile = new OpenFileDialog();
        AfisEngine afis = new AfisEngine();

        public VerificacaoBiometria(int id)
        {
            InitializeComponent();
            pessoasBd = new List<Person>();
            pessoaBase = new Person();
            pessoaBase.Id = id;
        }

        private void VerificacaoBiometria_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Global.UsuarioLogado;
        }

        private void btnInserirBiometria_Click(object sender, EventArgs e)
        {
            try
            {

                openFile.ShowDialog(this);
                openFile.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";

                pbxBiometria.Image = Image.FromFile(openFile.FileName);

                string strFn = openFile.FileName;

                Fingerprint fp = new Fingerprint();
                fp.AsBitmap = new Bitmap(Bitmap.FromFile(strFn));
                pessoaBase.Fingerprints.Add(fp);
                
                
                if (string.IsNullOrEmpty(strFn))
                    return;

                OrientedSmoother.Equals(fp, fp);
                SegmentationMask.Equals(fp, fp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {

            List<Person> candidatos = new List<Person>();

            string diretorio;

            try
            {
                SqlCommand cmd = new SqlCommand();
                Conexao con = new Conexao();


                cmd.Connection = con.Conectar();
                cmd.CommandText = "SELECT * FROM Usuario";
                SqlDataReader rd = cmd.ExecuteReader();
                ImageConverter converter = new ImageConverter();

                if (rd.HasRows)
                    while (rd.Read())
                    {
                        if (Convert.ToInt32(rd["ID_Usuario"]) != 1){
                            Bitmap bmp;
                            var img = (byte[])rd["Biometria"];
                            using (var ms = new MemoryStream(img))
                                bmp = new Bitmap(ms);
                            pessoasBd.Add(new Person
                            {
                                Id = Convert.ToInt32(rd["ID_Usuario"]),
                                Fingerprints = new List<Fingerprint> { new Fingerprint { AsBitmap = bmp } }
                            });
                        }
                    }
                afis.Extract(pessoaBase);
                foreach (var p in pessoasBd)
                    afis.Extract(p);

                var matches = afis.Identify(pessoaBase, pessoasBd);
                if (matches.Any(x => x.Id == pessoaBase.Id))
                {
                    TelaInicio telaInicio = new TelaInicio();
                    telaInicio.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Acesso não autorizado, tente novamente!");

                con.desconectar();

                
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Hide();
        }
    }
}
