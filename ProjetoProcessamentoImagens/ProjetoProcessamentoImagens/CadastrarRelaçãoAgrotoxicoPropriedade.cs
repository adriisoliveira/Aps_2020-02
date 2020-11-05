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

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                //MessageBox.Show(cbxCarregar.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand();
                string cnpj = txtCNPJ.Text;
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = ("select * from Propriedade WHERE CNPJ_Propriedade =@cnpj");
                //O campo SelectedValue se refere ao que eu selecionar na ComboBox
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cnpj = reader["CNPJ_Propriedade"].ToString();
                    txtCNPJ.Text = cnpj;
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

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                //MessageBox.Show(cbxCarregar.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand();
                string nome = txtAgrotoxico.Text;
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = ("select * from Agrotoxico WHERE Nome_Agrotoxico =@nome");
                //O campo SelectedValue se refere ao que eu selecionar na ComboBox
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", nome);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nome = reader["Nome_Agrotoxico"].ToString();
                    txtAgrotoxico.Text = nome;
                }
                else
                {
                    MessageBox.Show("AGROTOXICO INEXISTENTE!");
                }
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                reader.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS!\n" + exe.Message);
            }
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
            rtbInfo.ClearUndo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarRelaçãoAgrotoxicoPropriedade relacao = new CadastrarRelaçãoAgrotoxicoPropriedade();
            relacao.Show();
            this.Hide();
        }
    }
}
