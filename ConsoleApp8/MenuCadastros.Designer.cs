namespace ConsoleApp8
{
    partial class MenuCadastros
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarVotacao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarPartido = new System.Windows.Forms.Button();
            this.btnCadastrarCandidato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Urna Eleitoral";
            // 
            // btnIniciarVotacao
            // 
            this.btnIniciarVotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarVotacao.Location = new System.Drawing.Point(217, 276);
            this.btnIniciarVotacao.Name = "btnIniciarVotacao";
            this.btnIniciarVotacao.Size = new System.Drawing.Size(374, 60);
            this.btnIniciarVotacao.TabIndex = 13;
            this.btnIniciarVotacao.Text = "Iniciar Votação";
            this.btnIniciarVotacao.UseVisualStyleBackColor = true;
            this.btnIniciarVotacao.Click += new System.EventHandler(this.btnIniciarVotacao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastrarPartido
            // 
            this.btnCadastrarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPartido.Location = new System.Drawing.Point(217, 144);
            this.btnCadastrarPartido.Name = "btnCadastrarPartido";
            this.btnCadastrarPartido.Size = new System.Drawing.Size(374, 60);
            this.btnCadastrarPartido.TabIndex = 11;
            this.btnCadastrarPartido.Text = "Cadastrar Partido";
            this.btnCadastrarPartido.UseVisualStyleBackColor = true;
            this.btnCadastrarPartido.Click += new System.EventHandler(this.btnCadastrarPartido_Click);
            // 
            // btnCadastrarCandidato
            // 
            this.btnCadastrarCandidato.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastrarCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCandidato.Location = new System.Drawing.Point(217, 210);
            this.btnCadastrarCandidato.Name = "btnCadastrarCandidato";
            this.btnCadastrarCandidato.Size = new System.Drawing.Size(374, 60);
            this.btnCadastrarCandidato.TabIndex = 10;
            this.btnCadastrarCandidato.Text = "Cadastrar Candidato";
            this.btnCadastrarCandidato.UseVisualStyleBackColor = true;
            this.btnCadastrarCandidato.Click += new System.EventHandler(this.btnCadastrarCandidato_Click);
            // 
            // MenuCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciarVotacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrarPartido);
            this.Controls.Add(this.btnCadastrarCandidato);
            this.Name = "MenuCadastros";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciarVotacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarPartido;
        private System.Windows.Forms.Button btnCadastrarCandidato;
    }
}