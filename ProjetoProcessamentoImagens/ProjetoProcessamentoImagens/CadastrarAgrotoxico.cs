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
    public partial class CadastrarAgrotoxico : Form
    {
        public CadastrarAgrotoxico()
        {
            InitializeComponent();
        }
        private void CadastrarAgrotoxico_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
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

        }


    }
}
