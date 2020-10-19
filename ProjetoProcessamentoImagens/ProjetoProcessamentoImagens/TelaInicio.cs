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
    public partial class TelaInicio : Form
    {
        public TelaInicio()
        {
            InitializeComponent();
        }

        private void TelaInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarPropriedade_Click(object sender, EventArgs e)
        {
            BuscarPropriedade buscarPropriedade = new BuscarPropriedade();
            buscarPropriedade.Show();
            this.Hide();
        }

        private void btnBuscarAgrotoxico_Click(object sender, EventArgs e)
        {
            BuscarAgrotoxicos buscarAgrotoxicos = new BuscarAgrotoxicos();
            buscarAgrotoxicos.Show();
            this.Hide();

        }

        private void btnBuscaAvancada_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarPropriedade_Click(object sender, EventArgs e)
        {
            CadastrarPropriedade cadastrarPropriedade = new CadastrarPropriedade();
            cadastrarPropriedade.Show();
            this.Hide();

        }

        private void btnCadastrarAgrotoxico_Click(object sender, EventArgs e)
        {
            CadastrarAgrotoxico cadastrarAgrotoxico = new CadastrarAgrotoxico();
            cadastrarAgrotoxico.Show();
            this.Hide();
        }

        private void btnCadastarUsuarios_Click(object sender, EventArgs e)
        {
            CadastrarUsuarios cadastrarUsuarios = new CadastrarUsuarios();
            cadastrarUsuarios.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Hide();
        }
    }
}
