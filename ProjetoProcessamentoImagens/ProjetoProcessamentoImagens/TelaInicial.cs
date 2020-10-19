using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace ProjetoProcessamentoImagens
{
    public partial class TelaInicial : Form
    {
        private Button btnBuscarPropriedade;
        private Button btnCadastrarAgrotoxico;
        private Button btnCadastarUsuarios;
        private Button btnBuscaAvancada;
        private Button btnBuscarAgrotoxico;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Button btnCadastrarPropriedade;

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnBuscarPropriedade = new System.Windows.Forms.Button();
            this.btnCadastrarAgrotoxico = new System.Windows.Forms.Button();
            this.btnCadastarUsuarios = new System.Windows.Forms.Button();
            this.btnBuscaAvancada = new System.Windows.Forms.Button();
            this.btnBuscarAgrotoxico = new System.Windows.Forms.Button();
            this.btnCadastrarPropriedade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscarPropriedade
            // 
            this.btnBuscarPropriedade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPropriedade.Location = new System.Drawing.Point(25, 91);
            this.btnBuscarPropriedade.Name = "btnBuscarPropriedade";
            this.btnBuscarPropriedade.Size = new System.Drawing.Size(169, 48);
            this.btnBuscarPropriedade.TabIndex = 0;
            this.btnBuscarPropriedade.Text = "Buscar Propriedade";
            this.btnBuscarPropriedade.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarAgrotoxico
            // 
            this.btnCadastrarAgrotoxico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAgrotoxico.Location = new System.Drawing.Point(214, 164);
            this.btnCadastrarAgrotoxico.Name = "btnCadastrarAgrotoxico";
            this.btnCadastrarAgrotoxico.Size = new System.Drawing.Size(169, 48);
            this.btnCadastrarAgrotoxico.TabIndex = 1;
            this.btnCadastrarAgrotoxico.Text = "Cadastrar Agrotoxico";
            this.btnCadastrarAgrotoxico.UseVisualStyleBackColor = true;
            // 
            // btnCadastarUsuarios
            // 
            this.btnCadastarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastarUsuarios.Location = new System.Drawing.Point(401, 164);
            this.btnCadastarUsuarios.Name = "btnCadastarUsuarios";
            this.btnCadastarUsuarios.Size = new System.Drawing.Size(169, 48);
            this.btnCadastarUsuarios.TabIndex = 2;
            this.btnCadastarUsuarios.Text = "Cadastrar Usuários";
            this.btnCadastarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnBuscaAvancada
            // 
            this.btnBuscaAvancada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaAvancada.Location = new System.Drawing.Point(401, 91);
            this.btnBuscaAvancada.Name = "btnBuscaAvancada";
            this.btnBuscaAvancada.Size = new System.Drawing.Size(169, 48);
            this.btnBuscaAvancada.TabIndex = 3;
            this.btnBuscaAvancada.Text = "Busca Avançada";
            this.btnBuscaAvancada.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAgrotoxico
            // 
            this.btnBuscarAgrotoxico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAgrotoxico.Location = new System.Drawing.Point(214, 91);
            this.btnBuscarAgrotoxico.Name = "btnBuscarAgrotoxico";
            this.btnBuscarAgrotoxico.Size = new System.Drawing.Size(169, 48);
            this.btnBuscarAgrotoxico.TabIndex = 4;
            this.btnBuscarAgrotoxico.Text = "Buscar Agrotoxico";
            this.btnBuscarAgrotoxico.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarPropriedade
            // 
            this.btnCadastrarPropriedade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPropriedade.Location = new System.Drawing.Point(25, 164);
            this.btnCadastrarPropriedade.Name = "btnCadastrarPropriedade";
            this.btnCadastrarPropriedade.Size = new System.Drawing.Size(169, 48);
            this.btnCadastrarPropriedade.TabIndex = 5;
            this.btnCadastrarPropriedade.Text = "Cadastar Propriedade";
            this.btnCadastrarPropriedade.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione a opção desejada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.Location = new System.Drawing.Point(463, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // TelaInicial
            // 
            this.ClientSize = new System.Drawing.Size(585, 232);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarPropriedade);
            this.Controls.Add(this.btnBuscarAgrotoxico);
            this.Controls.Add(this.btnBuscaAvancada);
            this.Controls.Add(this.btnCadastarUsuarios);
            this.Controls.Add(this.btnCadastrarAgrotoxico);
            this.Controls.Add(this.btnBuscarPropriedade);
            this.Name = "TelaInicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}
