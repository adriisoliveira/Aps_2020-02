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
    public partial class BuscarProprietario : Form
    {
        public BuscarProprietario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                //MessageBox.Show(cbxCarregar.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand();
                string cpf = txtCpf.Text;
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = ("select CPF_Proprietario from Proprietario WHERE CPF_Proprietario=@cpf");
                //O campo SelectedValue se refere ao que eu selecionar na ComboBox
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cpf = reader["CPF_Proprietario"].ToString();
                    txtCpf.Text = cpf;
                    MessageBox.Show("CPF ENCONTRADO, CLIQUE EM SELECIONAR!");
                }
                else
                {
                    MessageBox.Show("CPF INEXISTENTE!");
                }
                reader.Close();
                cmd.ExecuteNonQuery();
                conexao.desconectar();

            }
            catch (Exception exe)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS!\n" + exe.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CadastrarPropriedade cadastrarPropriedade = new CadastrarPropriedade();
            cadastrarPropriedade.Show();
            this.Hide();
        }

        private void btnCadastrarNovo_Click(object sender, EventArgs e)
        {
            CadastroProprietario cadastroProprietario = new CadastroProprietario();
            cadastroProprietario.Show();
            this.Hide();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarPropriedade cadastrarPropriedade = new CadastrarPropriedade(txtCpf.Text);
            cadastrarPropriedade.Show();
            
        }

        private void BuscarProprietario_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Global.UsuarioLogado;
        }
    }
}
