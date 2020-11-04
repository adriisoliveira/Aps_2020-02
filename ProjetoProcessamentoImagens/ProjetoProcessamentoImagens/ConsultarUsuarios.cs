﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProcessamentoImagens
{
    public partial class ConsultarUsuarios : Form
    {
        public ConsultarUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ministerio_MeioAmbienteDataSet5.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter1.Fill(this.ministerio_MeioAmbienteDataSet5.Usuario);
            txtUsuario.Text = Global.UsuarioLogado;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicio telaInicio = new TelaInicio();
            telaInicio.Show();
            this.Hide();
        }
    }
}
