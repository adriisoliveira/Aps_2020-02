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
                string id = "";
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = ("select ID_Proprietario,CPF_Proprietario from Propriedade WHERE CPF_Proprietario=@cpf");
                //O campo SelectedValue se refere ao que eu selecionar na ComboBox
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cpf = reader["CPF_Proprietario"].ToString();
                    id = reader["ID_Proprietario"].ToString();
                    txtCpf.Text = id;
                }
                else
                {
                    MessageBox.Show("CNPF INEXISTENTE!");
                }

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
            string proprietario = txtCpf.Text;
        }
    }
}
