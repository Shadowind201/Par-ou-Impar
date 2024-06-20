namespace Par_ou_Impar
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdPar = new System.Windows.Forms.RadioButton();
            this.rdImpar = new System.Windows.Forms.RadioButton();
            this.btnJogar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do jogador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdImpar);
            this.groupBox1.Controls.Add(this.rdPar);
            this.groupBox1.Location = new System.Drawing.Point(45, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 44);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha";
            // 
            // rdPar
            // 
            this.rdPar.AutoSize = true;
            this.rdPar.Location = new System.Drawing.Point(6, 19);
            this.rdPar.Name = "rdPar";
            this.rdPar.Size = new System.Drawing.Size(41, 17);
            this.rdPar.TabIndex = 5;
            this.rdPar.TabStop = true;
            this.rdPar.Text = "Par";
            this.rdPar.UseVisualStyleBackColor = true;
            // 
            // rdImpar
            // 
            this.rdImpar.AutoSize = true;
            this.rdImpar.Location = new System.Drawing.Point(53, 19);
            this.rdImpar.Name = "rdImpar";
            this.rdImpar.Size = new System.Drawing.Size(51, 17);
            this.rdImpar.TabIndex = 6;
            this.rdImpar.TabStop = true;
            this.rdImpar.Text = "Ímpar";
            this.rdImpar.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(126, 176);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(92, 32);
            this.btnJogar.TabIndex = 5;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(45, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(245, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(190, 127);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPar;
        private System.Windows.Forms.RadioButton rdImpar;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
    }
}

