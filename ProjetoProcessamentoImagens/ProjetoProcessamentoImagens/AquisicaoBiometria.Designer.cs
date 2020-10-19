namespace ProjetoProcessamentoImagens
{
    partial class AquisicaoBiometria
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUP = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(482, 231);
            this.btnUP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(75, 41);
            this.btnUP.TabIndex = 3;
            this.btnUP.Text = "Subir";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.ErrorImage = null;
            this.pbImagem.Location = new System.Drawing.Point(43, 41);
            this.pbImagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(375, 284);
            this.pbImagem.TabIndex = 2;
            this.pbImagem.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 93);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AquisicaoBiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.pbImagem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AquisicaoBiometria";
            this.Text = "AquisicaoBiometria";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button button1;
    }
}