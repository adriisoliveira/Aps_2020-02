namespace ProjetoProcessamentoImagens
{
    partial class BuscarPropriedade
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.iDPropriedadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJPropriedadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFProprietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propriedadeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ministerio_MeioAmbienteDataSet4 = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet4();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.ministerio_MeioAmbienteDataSet3 = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet3();
            this.propriedadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propriedadeTableAdapter = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet3TableAdapters.PropriedadeTableAdapter();
            this.propriedadeTableAdapter1 = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet4TableAdapters.PropriedadeTableAdapter();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propriedadeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propriedadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.Location = new System.Drawing.Point(687, 9);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Digite o CNPJ para continuar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "CNPJ:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(65, 48);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(265, 20);
            this.txtCnpj.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(336, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvResultados);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(16, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 167);
            this.panel1.TabIndex = 25;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToOrderColumns = true;
            this.dgvResultados.AutoGenerateColumns = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPropriedadeDataGridViewTextBoxColumn,
            this.cNPJPropriedadeDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.nomeCidadeDataGridViewTextBoxColumn,
            this.uFEstadoDataGridViewTextBoxColumn,
            this.tamanhoDataGridViewTextBoxColumn,
            this.producaoDataGridViewTextBoxColumn,
            this.cPFProprietarioDataGridViewTextBoxColumn});
            this.dgvResultados.DataSource = this.propriedadeBindingSource1;
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.Location = new System.Drawing.Point(0, 0);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(774, 167);
            this.dgvResultados.TabIndex = 27;
            // 
            // iDPropriedadeDataGridViewTextBoxColumn
            // 
            this.iDPropriedadeDataGridViewTextBoxColumn.DataPropertyName = "ID_Propriedade";
            this.iDPropriedadeDataGridViewTextBoxColumn.HeaderText = "ID_Propriedade";
            this.iDPropriedadeDataGridViewTextBoxColumn.Name = "iDPropriedadeDataGridViewTextBoxColumn";
            this.iDPropriedadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNPJPropriedadeDataGridViewTextBoxColumn
            // 
            this.cNPJPropriedadeDataGridViewTextBoxColumn.DataPropertyName = "CNPJ_Propriedade";
            this.cNPJPropriedadeDataGridViewTextBoxColumn.HeaderText = "CNPJ_Propriedade";
            this.cNPJPropriedadeDataGridViewTextBoxColumn.Name = "cNPJPropriedadeDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // nomeCidadeDataGridViewTextBoxColumn
            // 
            this.nomeCidadeDataGridViewTextBoxColumn.DataPropertyName = "Nome_Cidade";
            this.nomeCidadeDataGridViewTextBoxColumn.HeaderText = "Nome_Cidade";
            this.nomeCidadeDataGridViewTextBoxColumn.Name = "nomeCidadeDataGridViewTextBoxColumn";
            // 
            // uFEstadoDataGridViewTextBoxColumn
            // 
            this.uFEstadoDataGridViewTextBoxColumn.DataPropertyName = "UF_Estado";
            this.uFEstadoDataGridViewTextBoxColumn.HeaderText = "UF_Estado";
            this.uFEstadoDataGridViewTextBoxColumn.Name = "uFEstadoDataGridViewTextBoxColumn";
            // 
            // tamanhoDataGridViewTextBoxColumn
            // 
            this.tamanhoDataGridViewTextBoxColumn.DataPropertyName = "Tamanho";
            this.tamanhoDataGridViewTextBoxColumn.HeaderText = "Tamanho";
            this.tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
            // 
            // producaoDataGridViewTextBoxColumn
            // 
            this.producaoDataGridViewTextBoxColumn.DataPropertyName = "Producao";
            this.producaoDataGridViewTextBoxColumn.HeaderText = "Producao";
            this.producaoDataGridViewTextBoxColumn.Name = "producaoDataGridViewTextBoxColumn";
            // 
            // cPFProprietarioDataGridViewTextBoxColumn
            // 
            this.cPFProprietarioDataGridViewTextBoxColumn.DataPropertyName = "CPF_Proprietario";
            this.cPFProprietarioDataGridViewTextBoxColumn.HeaderText = "CPF_Proprietario";
            this.cPFProprietarioDataGridViewTextBoxColumn.Name = "cPFProprietarioDataGridViewTextBoxColumn";
            // 
            // propriedadeBindingSource1
            // 
            this.propriedadeBindingSource1.DataMember = "Propriedade";
            this.propriedadeBindingSource1.DataSource = this.ministerio_MeioAmbienteDataSet4;
            // 
            // ministerio_MeioAmbienteDataSet4
            // 
            this.ministerio_MeioAmbienteDataSet4.DataSetName = "Ministerio_MeioAmbienteDataSet4";
            this.ministerio_MeioAmbienteDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "RESULTADOS";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(20, 274);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 30);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(509, 274);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 30);
            this.btnLimpar.TabIndex = 54;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(669, 274);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 30);
            this.btnSair.TabIndex = 53;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // ministerio_MeioAmbienteDataSet3
            // 
            this.ministerio_MeioAmbienteDataSet3.DataSetName = "Ministerio_MeioAmbienteDataSet3";
            this.ministerio_MeioAmbienteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propriedadeBindingSource
            // 
            this.propriedadeBindingSource.DataMember = "Propriedade";
            this.propriedadeBindingSource.DataSource = this.ministerio_MeioAmbienteDataSet3;
            // 
            // propriedadeTableAdapter
            // 
            this.propriedadeTableAdapter.ClearBeforeFill = true;
            // 
            // propriedadeTableAdapter1
            // 
            this.propriedadeTableAdapter1.ClearBeforeFill = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(174, 274);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(286, 30);
            this.btnConsultar.TabIndex = 56;
            this.btnConsultar.Text = "Consutar Agrotoxicos Utilizados";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // rtbResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 324);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rtbResultados";
            this.Text = "Buscar Propriedade";
            this.Load += new System.EventHandler(this.rtbResultados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propriedadeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propriedadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvResultados;
        private Ministerio_MeioAmbienteDataSet3 ministerio_MeioAmbienteDataSet3;
        private System.Windows.Forms.BindingSource propriedadeBindingSource;
        private Ministerio_MeioAmbienteDataSet3TableAdapters.PropriedadeTableAdapter propriedadeTableAdapter;
        private Ministerio_MeioAmbienteDataSet4 ministerio_MeioAmbienteDataSet4;
        private System.Windows.Forms.BindingSource propriedadeBindingSource1;
        private Ministerio_MeioAmbienteDataSet4TableAdapters.PropriedadeTableAdapter propriedadeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPropriedadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJPropriedadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFProprietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnConsultar;
    }
}