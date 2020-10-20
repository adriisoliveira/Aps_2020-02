namespace ProjetoProcessamentoImagens
{
    partial class CadastrarPropriedade
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
            this.components = new System.ComponentModel.Container();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProprietario = new System.Windows.Forms.TextBox();
            this.btnBuscarProprietario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ministerio_MeioAmbienteDataSet1 = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet1();
            this.lbxCidade = new System.Windows.Forms.ListBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ministerio_MeioAmbienteDataSet2 = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet2();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTipoProducao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.estadoTableAdapter = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet1TableAdapters.EstadoTableAdapter();
            this.cidadeTableAdapter = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet2TableAdapters.CidadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.Location = new System.Drawing.Point(526, 10);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Insira os dados da propiedade:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(46, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(91, 20);
            this.txtId.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "ID:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(197, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(429, 20);
            this.txtNome.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "CNPJ:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(68, 106);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(188, 20);
            this.txtCnpj.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Proprietário:";
            // 
            // txtProprietario
            // 
            this.txtProprietario.Location = new System.Drawing.Point(361, 106);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.Size = new System.Drawing.Size(170, 20);
            this.txtProprietario.TabIndex = 32;
            // 
            // btnBuscarProprietario
            // 
            this.btnBuscarProprietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProprietario.Location = new System.Drawing.Point(548, 106);
            this.btnBuscarProprietario.Name = "btnBuscarProprietario";
            this.btnBuscarProprietario.Size = new System.Drawing.Size(80, 20);
            this.btnBuscarProprietario.TabIndex = 33;
            this.btnBuscarProprietario.Text = "Buscar";
            this.btnBuscarProprietario.UseVisualStyleBackColor = true;
            this.btnBuscarProprietario.Click += new System.EventHandler(this.btnBuscarProprietario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(102, 151);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(524, 20);
            this.txtEndereco.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Cidade:";
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.ministerio_MeioAmbienteDataSet1;
            // 
            // ministerio_MeioAmbienteDataSet1
            // 
            this.ministerio_MeioAmbienteDataSet1.DataSetName = "Ministerio_MeioAmbienteDataSet1";
            this.ministerio_MeioAmbienteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbxCidade
            // 
            this.lbxCidade.DataSource = this.cidadeBindingSource;
            this.lbxCidade.DisplayMember = "Nome_Cidade";
            this.lbxCidade.FormattingEnabled = true;
            this.lbxCidade.Location = new System.Drawing.Point(87, 198);
            this.lbxCidade.Name = "lbxCidade";
            this.lbxCidade.Size = new System.Drawing.Size(184, 17);
            this.lbxCidade.TabIndex = 39;
            this.lbxCidade.ValueMember = "Nome_Cidade";
            this.lbxCidade.SelectedIndexChanged += new System.EventHandler(this.lbxCidade_SelectedIndexChanged);
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "Cidade";
            this.cidadeBindingSource.DataSource = this.ministerio_MeioAmbienteDataSet2;
            // 
            // ministerio_MeioAmbienteDataSet2
            // 
            this.ministerio_MeioAmbienteDataSet2.DataSetName = "Ministerio_MeioAmbienteDataSet2";
            this.ministerio_MeioAmbienteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(277, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Tamanho em hectares:";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(429, 195);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(197, 20);
            this.txtTamanho.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Tipo de produção:";
            // 
            // txtTipoProducao
            // 
            this.txtTipoProducao.Location = new System.Drawing.Point(146, 245);
            this.txtTipoProducao.Name = "txtTipoProducao";
            this.txtTipoProducao.Size = new System.Drawing.Size(480, 20);
            this.txtTipoProducao.TabIndex = 43;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(47, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 30);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(236, 289);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(144, 30);
            this.btnLimpar.TabIndex = 45;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(424, 289);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(144, 30);
            this.btnCadastrar.TabIndex = 44;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // CadastrarPropriedade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 343);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtTipoProducao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbxCidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarProprietario);
            this.Controls.Add(this.txtProprietario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarPropriedade";
            this.Text = "CadastrarPropriedade";
            this.Load += new System.EventHandler(this.CadastrarPropriedade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProprietario;
        private System.Windows.Forms.Button btnBuscarProprietario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbxCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTipoProducao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private Ministerio_MeioAmbienteDataSet1 ministerio_MeioAmbienteDataSet1;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private Ministerio_MeioAmbienteDataSet1TableAdapters.EstadoTableAdapter estadoTableAdapter;
        private Ministerio_MeioAmbienteDataSet2 ministerio_MeioAmbienteDataSet2;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private Ministerio_MeioAmbienteDataSet2TableAdapters.CidadeTableAdapter cidadeTableAdapter;
    }
}