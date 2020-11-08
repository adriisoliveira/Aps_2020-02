using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BuscarPropriedade propridade = new BuscarPropriedade();
            propridade.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCNPJ.Clear();
            txtAgrotoxico.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                //MessageBox.Show(cbxCarregar.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand();
                string nome = txtAgrotoxico.Text;
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = ("INSERT INTO Agrotoxico_Propriedade VALUES('" + txtCNPJ.Text + "','" + txtAgrotoxico.Text + "','" + dtpInicio.Value.Date + "','" + dtpFim.Value.Date + "')") ;
                cmd.ExecuteNonQuery();
                conexao.desconectar();
            }
            catch (Exception exe)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS!\n" + exe.Message);
            }

            CadastrarRelaçãoAgrotoxicoPropriedade relacao = new CadastrarRelaçãoAgrotoxicoPropriedade();
            relacao.Show();
            this.Hide();
        }
    }
}
