﻿namespace ProjetoProcessamentoImagens
{
    partial class TelaInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarPropriedade = new System.Windows.Forms.Button();
            this.btnBuscarAgrotoxico = new System.Windows.Forms.Button();
            this.btnConsultarUsuarios = new System.Windows.Forms.Button();
            this.btnCadastarUsuarios = new System.Windows.Forms.Button();
            this.btnCadastrarAgrotoxico = new System.Windows.Forms.Button();
            this.btnBuscarPropriedade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(528, 279);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(225, 41);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.Location = new System.Drawing.Point(607, 36);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Selecione a opção desejada:";
            // 
            // btnCadastrarPropriedade
            // 
            this.btnCadastrarPropriedade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPropriedade.Location = new System.Drawing.Point(23, 194);
            this.btnCadastrarPropriedade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarPropriedade.Name = "btnCadastrarPropriedade";
            this.btnCadastrarPropriedade.Size = new System.Drawing.Size(225, 59);
            this.btnCadastrarPropriedade.TabIndex = 15;
            this.btnCadastrarPropriedade.Text = "Cadastar Propriedade";
            this.btnCadastrarPropriedade.UseVisualStyleBackColor = true;
            this.btnCadastrarPropriedade.Click += new System.EventHandler(this.btnCadastrarPropriedade_Click);
            // 
            // btnBuscarAgrotoxico
            // 
            this.btnBuscarAgrotoxico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAgrotoxico.Location = new System.Drawing.Point(275, 105);
            this.btnBuscarAgrotoxico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarAgrotoxico.Name = "btnBuscarAgrotoxico";
            this.btnBuscarAgrotoxico.Size = new System.Drawing.Size(225, 59);
            this.btnBuscarAgrotoxico.TabIndex = 14;
            this.btnBuscarAgrotoxico.Text = "Buscar Agrotoxico";
            this.btnBuscarAgrotoxico.UseVisualStyleBackColor = true;
            this.btnBuscarAgrotoxico.Click += new System.EventHandler(this.btnBuscarAgrotoxico_Click);
            // 
            // btnConsultarUsuarios
            // 
            this.btnConsultarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarUsuarios.Location = new System.Drawing.Point(524, 105);
            this.btnConsultarUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultarUsuarios.Name = "btnConsultarUsuarios";
            this.btnConsultarUsuarios.Size = new System.Drawing.Size(225, 59);
            this.btnConsultarUsuarios.TabIndex = 13;
            this.btnConsultarUsuarios.Text = "Consultar Usuários";
            this.btnConsultarUsuarios.UseVisualStyleBackColor = true;
            this.btnConsultarUsuarios.Click += new System.EventHandler(this.btnConsultarUsuarios_Click);
            // 
            // btnCadastarUsuarios
            // 
            this.btnCadastarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastarUsuarios.Location = new System.Drawing.Point(524, 194);
            this.btnCadastarUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastarUsuarios.Name = "btnCadastarUsuarios";
            this.btnCadastarUsuarios.Size = new System.Drawing.Size(225, 59);
            this.btnCadastarUsuarios.TabIndex = 12;
            this.btnCadastarUsuarios.Text = "Cadastrar Usuários";
            this.btnCadastarUsuarios.UseVisualStyleBackColor = true;
            this.btnCadastarUsuarios.Click += new System.EventHandler(this.btnCadastarUsuarios_Click);
            // 
            // btnCadastrarAgrotoxico
            // 
            this.btnCadastrarAgrotoxico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAgrotoxico.Location = new System.Drawing.Point(275, 194);
            this.btnCadastrarAgrotoxico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarAgrotoxico.Name = "btnCadastrarAgrotoxico";
            this.btnCadastrarAgrotoxico.Size = new System.Drawing.Size(225, 59);
            this.btnCadastrarAgrotoxico.TabIndex = 11;
            this.btnCadastrarAgrotoxico.Text = "Cadastrar Agrotoxico";
            this.btnCadastrarAgrotoxico.UseVisualStyleBackColor = true;
            this.btnCadastrarAgrotoxico.Click += new System.EventHandler(this.btnCadastrarAgrotoxico_Click);
            // 
            // btnBuscarPropriedade
            // 
            this.btnBuscarPropriedade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPropriedade.Location = new System.Drawing.Point(23, 105);
            this.btnBuscarPropriedade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarPropriedade.Name = "btnBuscarPropriedade";
            this.btnBuscarPropriedade.Size = new System.Drawing.Size(225, 59);
            this.btnBuscarPropriedade.TabIndex = 10;
            this.btnBuscarPropriedade.Text = "Buscar Propriedade";
            this.btnBuscarPropriedade.UseVisualStyleBackColor = true;
            this.btnBuscarPropriedade.Click += new System.EventHandler(this.btnBuscarPropriedade_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarPropriedade);
            this.Controls.Add(this.btnBuscarAgrotoxico);
            this.Controls.Add(this.btnConsultarUsuarios);
            this.Controls.Add(this.btnCadastarUsuarios);
            this.Controls.Add(this.btnCadastrarAgrotoxico);
            this.Controls.Add(this.btnBuscarPropriedade);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaInicio";
            this.Text = "TelaInicio";
            this.Load += new System.EventHandler(this.TelaInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarPropriedade;
        private System.Windows.Forms.Button btnBuscarAgrotoxico;
        private System.Windows.Forms.Button btnConsultarUsuarios;
        private System.Windows.Forms.Button btnCadastarUsuarios;
        private System.Windows.Forms.Button btnCadastrarAgrotoxico;
        private System.Windows.Forms.Button btnBuscarPropriedade;
        private System.Windows.Forms.Button button1;
    }
}