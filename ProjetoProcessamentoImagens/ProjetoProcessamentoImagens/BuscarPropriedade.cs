﻿using System;
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
    public partial class BuscarPropriedade : Form
    {
        public BuscarPropriedade()
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
                }
                else
                {
                    MessageBox.Show("CNPJ INEXISTENTE!");
                }
                reader.Close();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvResultados.DataSource = dt;

                //dtaInfo.Rows.RemoveAt(dtaInfo.RowCount);

                dgvResultados.AllowUserToAddRows = false;

                /*string info = "";
                info = dgvResultados.SelectedRows[0].Cells[1].Value.ToString();
                rtbResultados. = info;*/

                cmd.ExecuteNonQuery();
                conexao.desconectar();

            }
            catch (Exception exe)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS!\n" + exe.Message);
            }

           

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            TelaInicio telaInicio = new TelaInicio();
            telaInicio.Show();
            this.Hide();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtCnpj.Clear();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            TelaInicio telaInicio = new TelaInicio();
            telaInicio.Show();
            this.Hide();
        }

        private void rtbResultados_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Global.UsuarioLogado;
            if (Global.Tipo_Acesso == 1 || Global.Tipo_Acesso == 2)
            {
                btnConsultar.Enabled = false;

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AssociaçãoAgotoxicoPropriedade associaçãoAgotoxico = new AssociaçãoAgotoxicoPropriedade();
            associaçãoAgotoxico.Show();
            this.Hide();
        }
    }
}
