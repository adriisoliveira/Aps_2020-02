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
    public partial class CadastrarPropriedade : Form
    {
        Conexao conexao = new Conexao();
        //Classe para poder escrever em sql 
        SqlCommand cmd = new SqlCommand();
        public CadastrarPropriedade()
        {
            InitializeComponent();
        }

        private void CadastrarPropriedade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ministerio_MeioAmbienteDataSet2.Cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.ministerio_MeioAmbienteDataSet2.Cidade);
            // TODO: esta linha de código carrega dados na tabela 'ministerio_MeioAmbienteDataSet1.Estado'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoTableAdapter.Fill(this.ministerio_MeioAmbienteDataSet1.Estado);
            txtNome.Focus();
            txtUsuario.Text = Global.UsuarioLogado;
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
        }

        private void lbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lbxCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                Conexao conexao = new Conexao();
                //MessageBox.Show(cbxCarregar.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();
                string nomeCidade = lbxCidade.Text;
                cmd.CommandText = ("SELECT Nome_Cidade FROM Cidade WHERE Nome_Cidade=@nomeCidade");
                cmd.Parameters.AddWithValue("@nomeCidade", nomeCidade);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nomeCidade = reader["Nome_Cidade"].ToString();
                    lbxCidade.Text = nomeCidade;
                }
                else
                {
                    MessageBox.Show("CIDADE INEXISTENTE!");
                }
                reader.Close();



                cmd.CommandText = ("INSERT INTO Propriedade (CNPJ_Propriedade,Nome,Endereco,ID_Cidade,Tamanho,Producao,ID_Proprietario) VALUES ('" +txtCnpj.Text + "', '" + txtNome.Text + "', '" + txtEndereco.Text + "', +'" + lbxCidade.Text + "', '" + txtTamanho.Text + "', '" + txtTipoProducao.Text + "','"+txtProprietario.Text+"'");
                cmd.ExecuteNonQuery();
                conexao.desconectar();

            }
            catch (Exception exe)
            {
                MessageBox.Show("ERRO AO CADASTRAR DADOS!\n" + exe.Message);
            }
        }
    }
}
