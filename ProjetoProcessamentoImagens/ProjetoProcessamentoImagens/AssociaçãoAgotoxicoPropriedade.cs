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

        private void btnCadastrarNova_Click(object sender, EventArgs e)
        {
            CadastrarRelaçãoAgrotoxicoPropriedade cadastro = new CadastrarRelaçãoAgrotoxicoPropriedade();
            cadastro.Show();
            this.Hide();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                //MessageBox.Show(cbxCarregar.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand();
                string cnpj = txtCnpj.Text;
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = ("select * from Propriedade WHERE CNPJ_Propriedade =@cnpj");
                //O campo SelectedValue se refere ao que eu selecionar na ComboBox
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cnpj = reader["CNPJ_Propriedade"].ToString();
                    txtCnpj.Text = cnpj;
                }
                else
                {
                    MessageBox.Show("CNPJ INEXISTENTE!");
                }
                reader.Close();

            }
            catch (Exception exe)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS!\n" + exe.Message);
            }
        }
    }
}
