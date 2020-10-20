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
    public partial class BuscarAgrotoxicos : Form
    {
        public BuscarAgrotoxicos()
        {
            InitializeComponent();
        }

        private void btnBuscaNome_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                //MessageBox.Show(cbxCarregar.SelectedValue.ToString());
                SqlCommand cmd = new SqlCommand();
                string nome = txtNome.Text;
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = ("select * from Agrotoxico WHERE Nome_Agrotoxico =@nome");
                //O campo SelectedValue se refere ao que eu selecionar na ComboBox
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", nome);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nome = reader["Nome_Agrotoxico"].ToString();
                }
                else
                {
                    MessageBox.Show("AGROTOXICO INEXISTENTE!");
                }
                reader.Close();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvResultados.DataSource = dt;

                dgvResultados.AllowUserToAddRows = false;


                cmd.ExecuteNonQuery();
                conexao.desconectar();

            }
            catch (Exception exe)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS!\n" + exe.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaInicio telaInicio = new TelaInicio();
            telaInicio.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtUsuario.Clear();
            dgvResultados.ClearSelection();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
