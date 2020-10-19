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
    public partial class BuscarProprietario : Form
    {
        public BuscarProprietario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CadastrarPropriedade cadastrarPropriedade = new CadastrarPropriedade();
            cadastrarPropriedade.Show();
            this.Hide();
        }

        private void btnCadastrarNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

        }
    }
}
