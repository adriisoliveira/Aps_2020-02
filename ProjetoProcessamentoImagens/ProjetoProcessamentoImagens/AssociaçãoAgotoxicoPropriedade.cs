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
    public partial class AssociaçãoAgotoxicoPropriedade : Form
    {
        public AssociaçãoAgotoxicoPropriedade()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            BuscarPropriedade propriedade = new BuscarPropriedade();
            propriedade.Show();
            this.Hide();
        }
    }
}
