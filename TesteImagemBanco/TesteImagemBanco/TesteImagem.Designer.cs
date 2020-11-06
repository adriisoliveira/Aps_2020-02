namespace TesteImagemBanco
{
    partial class TesteImagem
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.btnObterImagem = new System.Windows.Forms.Button();
            this.dgvBancoImagens = new System.Windows.Forms.DataGridView();
            this.txtCodigoImagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.btnSalvarImagem = new System.Windows.Forms.Button();
            this.txtDescricaoImagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancoImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagem
            // 
            this.pbxImagem.Location = new System.Drawing.Point(12, 46);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(271, 256);
            this.pbxImagem.TabIndex = 0;
            this.pbxImagem.TabStop = false;
            // 
            // btnObterImagem
            // 
            this.btnObterImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterImagem.Location = new System.Drawing.Point(289, 46);
            this.btnObterImagem.Name = "btnObterImagem";
            this.btnObterImagem.Size = new System.Drawing.Size(276, 35);
            this.btnObterImagem.TabIndex = 1;
            this.btnObterImagem.Text = "Obter Imagem do Banco de Dados";
            this.btnObterImagem.UseVisualStyleBackColor = true;
            this.btnObterImagem.Click += new System.EventHandler(this.btnObterImagem_Click);
            // 
            // dgvBancoImagens
            // 
            this.dgvBancoImagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBancoImagens.Location = new System.Drawing.Point(12, 359);
            this.dgvBancoImagens.Name = "dgvBancoImagens";
            this.dgvBancoImagens.Size = new System.Drawing.Size(553, 135);
            this.dgvBancoImagens.TabIndex = 2;
            this.dgvBancoImagens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBancoImagens_CellContentClick);
            // 
            // txtCodigoImagem
            // 
            this.txtCodigoImagem.Location = new System.Drawing.Point(289, 106);
            this.txtCodigoImagem.Multiline = true;
            this.txtCodigoImagem.Name = "txtCodigoImagem";
            this.txtCodigoImagem.Size = new System.Drawing.Size(276, 69);
            this.txtCodigoImagem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "RECUPERAÇÃO E ENVIO DE IMAGENS";
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarImagem.Location = new System.Drawing.Point(12, 317);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(271, 27);
            this.btnCarregarImagem.TabIndex = 5;
            this.btnCarregarImagem.Text = "Carregar Imagem";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // btnSalvarImagem
            // 
            this.btnSalvarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarImagem.Location = new System.Drawing.Point(289, 317);
            this.btnSalvarImagem.Name = "btnSalvarImagem";
            this.btnSalvarImagem.Size = new System.Drawing.Size(276, 27);
            this.btnSalvarImagem.TabIndex = 6;
            this.btnSalvarImagem.Text = "Salvar Imagem no Banco";
            this.btnSalvarImagem.UseVisualStyleBackColor = true;
            this.btnSalvarImagem.Click += new System.EventHandler(this.btnSalvarImagem_Click);
            // 
            // txtDescricaoImagem
            // 
            this.txtDescricaoImagem.Location = new System.Drawing.Point(289, 207);
            this.txtDescricaoImagem.Multiline = true;
            this.txtDescricaoImagem.Name = "txtDescricaoImagem";
            this.txtDescricaoImagem.Size = new System.Drawing.Size(276, 84);
            this.txtDescricaoImagem.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descrição da imagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Código da imagem:";
            // 
            // TesteImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricaoImagem);
            this.Controls.Add(this.btnSalvarImagem);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoImagem);
            this.Controls.Add(this.dgvBancoImagens);
            this.Controls.Add(this.btnObterImagem);
            this.Controls.Add(this.pbxImagem);
            this.Name = "TesteImagem";
            this.Text = "Teste Imagem";
            this.Load += new System.EventHandler(this.TesteImagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancoImagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.Button btnObterImagem;
        private System.Windows.Forms.DataGridView dgvBancoImagens;
        private System.Windows.Forms.TextBox txtCodigoImagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.Button btnSalvarImagem;
        private System.Windows.Forms.TextBox txtDescricaoImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

