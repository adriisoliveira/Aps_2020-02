namespace ProjetoProcessamentoImagens
{
    partial class ConsultarUsuarios
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.iDUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biometriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAcessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ministerio_MeioAmbienteDataSet5 = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet5();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ministerio_MeioAmbienteDataSet = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet();
            this.usuarioTableAdapter = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSetTableAdapters.UsuarioTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioTableAdapter1 = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet5TableAdapters.UsuarioTableAdapter();
            this.ministerio_MeioAmbienteDataSet12 = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet12();
            this.usuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter2 = new ProjetoProcessamentoImagens.Ministerio_MeioAmbienteDataSet12TableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.Location = new System.Drawing.Point(653, 9);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Usuário:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(579, 275);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(173, 38);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUsuarioDataGridViewTextBoxColumn,
            this.biometriaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.tipoAcessoDataGridViewTextBoxColumn,
            this.usuarioLoginDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.usuarioBindingSource2;
            this.dgvUsuarios.Location = new System.Drawing.Point(16, 37);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(736, 220);
            this.dgvUsuarios.TabIndex = 24;
            // 
            // iDUsuarioDataGridViewTextBoxColumn
            // 
            this.iDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.HeaderText = "ID_Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.Name = "iDUsuarioDataGridViewTextBoxColumn";
            this.iDUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // biometriaDataGridViewTextBoxColumn
            // 
            this.biometriaDataGridViewTextBoxColumn.DataPropertyName = "Biometria";
            this.biometriaDataGridViewTextBoxColumn.HeaderText = "Biometria";
            this.biometriaDataGridViewTextBoxColumn.Name = "biometriaDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // tipoAcessoDataGridViewTextBoxColumn
            // 
            this.tipoAcessoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Acesso";
            this.tipoAcessoDataGridViewTextBoxColumn.HeaderText = "Tipo_Acesso";
            this.tipoAcessoDataGridViewTextBoxColumn.Name = "tipoAcessoDataGridViewTextBoxColumn";
            // 
            // usuarioLoginDataGridViewTextBoxColumn
            // 
            this.usuarioLoginDataGridViewTextBoxColumn.DataPropertyName = "UsuarioLogin";
            this.usuarioLoginDataGridViewTextBoxColumn.HeaderText = "UsuarioLogin";
            this.usuarioLoginDataGridViewTextBoxColumn.Name = "usuarioLoginDataGridViewTextBoxColumn";
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.ministerio_MeioAmbienteDataSet5;
            // 
            // ministerio_MeioAmbienteDataSet5
            // 
            this.ministerio_MeioAmbienteDataSet5.DataSetName = "Ministerio_MeioAmbienteDataSet5";
            this.ministerio_MeioAmbienteDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.ministerio_MeioAmbienteDataSet;
            // 
            // ministerio_MeioAmbienteDataSet
            // 
            this.ministerio_MeioAmbienteDataSet.DataSetName = "Ministerio_MeioAmbienteDataSet";
            this.ministerio_MeioAmbienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuários Cadastrados no sistema:";
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // ministerio_MeioAmbienteDataSet12
            // 
            this.ministerio_MeioAmbienteDataSet12.DataSetName = "Ministerio_MeioAmbienteDataSet12";
            this.ministerio_MeioAmbienteDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource2
            // 
            this.usuarioBindingSource2.DataMember = "Usuario";
            this.usuarioBindingSource2.DataSource = this.ministerio_MeioAmbienteDataSet12;
            // 
            // usuarioTableAdapter2
            // 
            this.usuarioTableAdapter2.ClearBeforeFill = true;
            // 
            // ConsultarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 325);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarUsuarios";
            this.Text = "ConsultarUsuarios";
            this.Load += new System.EventHandler(this.ConsultarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ministerio_MeioAmbienteDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private Ministerio_MeioAmbienteDataSet ministerio_MeioAmbienteDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private Ministerio_MeioAmbienteDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biometriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAcessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private Ministerio_MeioAmbienteDataSet5 ministerio_MeioAmbienteDataSet5;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private Ministerio_MeioAmbienteDataSet5TableAdapters.UsuarioTableAdapter usuarioTableAdapter1;
        private Ministerio_MeioAmbienteDataSet12 ministerio_MeioAmbienteDataSet12;
        private System.Windows.Forms.BindingSource usuarioBindingSource2;
        private Ministerio_MeioAmbienteDataSet12TableAdapters.UsuarioTableAdapter usuarioTableAdapter2;
    }
}