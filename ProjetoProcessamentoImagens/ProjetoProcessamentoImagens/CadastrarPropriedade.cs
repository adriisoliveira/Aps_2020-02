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
    public partial class CadastrarPropriedade : Form
    {
        public CadastrarPropriedade()
        {
            InitializeComponent();
        }

        private void CadastrarPropriedade_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnBuscarProprietario_Click(object sender, EventArgs e)
        {
            BuscarProprietario buscarProprietario = new BuscarProprietario();
            buscarProprietario.Show();
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
            txtCnpj.Clear();
            txtEndereco.Clear();
            txtId.Clear();
            txtNome.Clear();
            txtProprietario.Clear();
            txtTamanho.Clear();
            txtTipoProducao.Clear();
            lbxCidade.ClearSelected();
            lbxEstado.ClearSelected();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
