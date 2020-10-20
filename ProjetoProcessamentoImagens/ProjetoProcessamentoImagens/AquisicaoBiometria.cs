using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProcessamentoImagens
{
    public partial class AquisicaoBiometria : Form
    {
        public AquisicaoBiometria()
        {
            InitializeComponent();
            pbImagem.Image = Image.FromFile("‪C:\\Users\\Drih\\Pictures");
            //colocar local de arquivo da img
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.OpenFile();
            pbImagem.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CadastrarUsuarios cadastrarUsuarios = new CadastrarUsuarios();
            cadastrarUsuarios.Show();
            this.Hide();
        }
    }
}
