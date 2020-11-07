namespace ProjetoProcessamentoImagens
{
    partial class VerificacaoBiometria
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxBiometria = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserirBiometria = new System.Windows.Forms.Button();
            this.btnAutenticar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBiometria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(319, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 32);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.Location = new System.Drawing.Point(381, 14);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Usuário:";
            // 
            // pbxBiometria
            // 
            this.pbxBiometria.Location = new System.Drawing.Point(12, 53);
            this.pbxBiometria.Name = "pbxBiometria";
            this.pbxBiometria.Size = new System.Drawing.Size(293, 223);
            this.pbxBiometria.TabIndex = 28;
            this.pbxBiometria.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Autenticação de biometria de usuário";
            // 
            // btnInserirBiometria
            // 
            this.btnInserirBiometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirBiometria.Location = new System.Drawing.Point(319, 163);
            this.btnInserirBiometria.Name = "btnInserirBiometria";
            this.btnInserirBiometria.Size = new System.Drawing.Size(162, 32);
            this.btnInserirBiometria.TabIndex = 26;
            this.btnInserirBiometria.Text = "Inserir Biometria";
            this.btnInserirBiometria.UseVisualStyleBackColor = true;
            this.btnInserirBiometria.Click += new System.EventHandler(this.btnInserirBiometria_Click);
            // 
            // btnAutenticar
            // 
            this.btnAutenticar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutenticar.Location = new System.Drawing.Point(319, 201);
            this.btnAutenticar.Name = "btnAutenticar";
            this.btnAutenticar.Size = new System.Drawing.Size(162, 32);
            this.btnAutenticar.TabIndex = 31;
            this.btnAutenticar.Text = "Autenticar";
            this.btnAutenticar.UseVisualStyleBackColor = true;
            this.btnAutenticar.Click += new System.EventHandler(this.btnAutenticar_Click);
            // 
            // VerificacaoBiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 302);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAutenticar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxBiometria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserirBiometria);
            this.Name = "VerificacaoBiometria";
            this.Text = "VerificacaoBiometria";
            this.Load += new System.EventHandler(this.VerificacaoBiometria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBiometria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxBiometria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserirBiometria;
        private System.Windows.Forms.Button btnAutenticar;
    }
}