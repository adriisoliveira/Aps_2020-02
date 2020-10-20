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
            lbxEstado.ClearSelected();
        }

        private void lbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lbxCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            /*try
            {
                cmd.Connection = conexao.Conectar();
                //Comandos SQL para inserir os dados no banco
                //Para escrever os comandos precisa da classe SqlCommand
                cmd.CommandText = "INSERT INTO Agrotoxico (Nome_Agrotoxico,Descricao,Classificacao,Composicao,Permissao) values ('" + txtNome.Text + "', '" + txtDescricao.Text + "','" + lbxClassificacao.Text + "',+'" + txtComposicao.Text + "','" + txtPermissao.Text + "')";


                cmd.ExecuteNonQuery();
                conexao.desconectar();

                MessageBox.Show("Cadastro feito com sucesso!!!");
            }
            catch (SqlException ex)
            {

                //caso de algum erro ja na conexão o programa ja pula para o cath
                //para tentar resolver
                MessageBox.Show("ERRO AO SE CONECTAR COM O BANCO!", ex.Message);
            }*/
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.estadoTableAdapter.FillBy(this.ministerio_MeioAmbienteDataSet1.Estado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
