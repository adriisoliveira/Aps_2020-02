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

        }
    }
}
