using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public CadastrarPropriedade(string cpf = "")
        {
            InitializeComponent();
            txtProprietario.Text = cpf;
        }

        private void CadastrarPropriedade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ministerio_MeioAmbienteDataSet11.Estado'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoTableAdapter3.Fill(this.ministerio_MeioAmbienteDataSet11.Estado);
            // TODO: esta linha de código carrega dados na tabela 'ministerio_MeioAmbienteDataSet10.Cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter3.Fill(this.ministerio_MeioAmbienteDataSet10.Cidade);



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
            cbxCidade.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;
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
                string nomeCidade = cbxCidade.Text;
                string ufEstado = cbxEstado.Text;
                cmd.CommandText = ("SELECT Nome_Cidade,UF_Estado FROM Cidade WHERE Nome_Cidade=@nomeCidade and UF_Estado=@ufEstado");
                cmd.Parameters.AddWithValue("@nomeCidade", nomeCidade);
                cmd.Parameters.AddWithValue("@ufEstado", ufEstado);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nomeCidade = reader["Nome_Cidade"].ToString();
                    cbxCidade.Text = nomeCidade;
                    ufEstado = reader["UF_Estado"].ToString();
                    cbxEstado.Text = ufEstado;
                }
                else
                {
                    MessageBox.Show("CIDADE INEXISTENTE!");
                }
                /*reader.Close();
                if (reader.Read())
                {
                    nomeCidade = reader["UF_Estado"].ToString();
                    cbxEstado.Text = ufEstado;
                }
                else
                {
                    MessageBox.Show("ESTADO INEXISTENTE!");
                }*/
                reader.Close();


                cmd.CommandText = ("INSERT INTO Propriedade (CNPJ_Propriedade,Nome,Endereco,Nome_Cidade,Tamanho,Producao,CPF_Proprietario) VALUES ('" +txtCnpj.Text + "', '" + txtNome.Text + "', '" + txtEndereco.Text + "', +'" + cbxCidade.Text + "', '" + txtTamanho.Text + "', '" + txtTipoProducao.Text + "','"+txtProprietario.Text+"')");
                cmd.ExecuteNonQuery();
                conexao.desconectar();

                MessageBox.Show("CADASTRO FEITO COM SUCESSO");
            }
            catch (Exception exe)
            {
                MessageBox.Show("ERRO AO CADASTRAR DADOS!\n" + exe.Message);
            }
        }
    }
}
