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
    public partial class CadastrarRelaçãoAgrotoxicoPropriedade : Form
    {
        public CadastrarRelaçãoAgrotoxicoPropriedade()
        {
            InitializeComponent();
        }

        private void CadastrarRelaçãoAgrotoxicoPropriedade_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Global.UsuarioLogado;
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaInicio telaInicio = new TelaInicio();
            telaInicio.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
