namespace ProjetoProcessamentoImagens
{
    partial class CadastroBiometria
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
            this.btnBuscarBiometria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxBiometria = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBiometria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarBiometria
            // 
            this.btnBuscarBiometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBiometria.Location = new System.Drawing.Point(323, 161);
            this.btnBuscarBiometria.Name = "btnBuscarBiometria";
            this.btnBuscarBiometria.Size = new System.Drawing.Size(162, 32);
            this.btnBuscarBiometria.TabIndex = 0;
            this.btnBuscarBiometria.Text = "Buscar Biometria";
            this.btnBuscarBiometria.UseVisualStyleBackColor = true;
            this.btnBuscarBiometria.Click += new System.EventHandler(this.btnBuscarBiometria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de biometria de usuário:";
            // 
            // pbxBiometria
            // 
            this.pbxBiometria.Location = new System.Drawing.Point(16, 51);
            this.pbxBiometria.Name = "pbxBiometria";
            this.pbxBiometria.Size = new System.Drawing.Size(293, 223);
            this.pbxBiometria.TabIndex = 2;
            this.pbxBiometria.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.Location = new System.Drawing.Point(385, 12);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Usuário:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(323, 199);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(162, 32);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(323, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 32);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastroBiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 299);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxBiometria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarBiometria);
            this.Name = "CadastroBiometria";
            this.Text = "CadastroBiometria";
            this.Load += new System.EventHandler(this.CadastroBiometria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBiometria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarBiometria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxBiometria;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}