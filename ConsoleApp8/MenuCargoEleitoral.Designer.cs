using System.Windows.Forms;

namespace ConsoleApp8
{
    partial class MenuCargoEleitoral
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSegundaOpcao = new System.Windows.Forms.Button();
            this.btnPrimeiraOpcao = new System.Windows.Forms.Button();
            this.btnTerceiraOpcao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eleição";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSegundaOpcao
            // 
            this.btnSegundaOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundaOpcao.Location = new System.Drawing.Point(221, 208);
            this.btnSegundaOpcao.Name = "btnSegundaOpcao";
            this.btnSegundaOpcao.Size = new System.Drawing.Size(374, 60);
            this.btnSegundaOpcao.TabIndex = 5;
            this.btnSegundaOpcao.Text = "Deputado Federal";
            this.btnSegundaOpcao.UseVisualStyleBackColor = true;
            this.btnSegundaOpcao.Click += new System.EventHandler(this.btnSegundaOpcao_Click);
            // 
            // btnPrimeiraOpcao
            // 
            this.btnPrimeiraOpcao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrimeiraOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiraOpcao.Location = new System.Drawing.Point(221, 142);
            this.btnPrimeiraOpcao.Name = "btnPrimeiraOpcao";
            this.btnPrimeiraOpcao.Size = new System.Drawing.Size(374, 60);
            this.btnPrimeiraOpcao.TabIndex = 4;
            this.btnPrimeiraOpcao.Text = "Deputado Estadual";
            this.btnPrimeiraOpcao.UseVisualStyleBackColor = true;
            this.btnPrimeiraOpcao.Click += new System.EventHandler(this.btnPrimeiraOpcao_Click);
            // 
            // btnTerceiraOpcao
            // 
            this.btnTerceiraOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerceiraOpcao.Location = new System.Drawing.Point(221, 274);
            this.btnTerceiraOpcao.Name = "btnTerceiraOpcao";
            this.btnTerceiraOpcao.Size = new System.Drawing.Size(374, 60);
            this.btnTerceiraOpcao.TabIndex = 7;
            this.btnTerceiraOpcao.Text = "Vereador Municipal";
            this.btnTerceiraOpcao.UseVisualStyleBackColor = true;
            this.btnTerceiraOpcao.Click += new System.EventHandler(this.btnTerceiraOpcao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Urna Eleitoral";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(17, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // MenuCargoEleitoral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTerceiraOpcao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSegundaOpcao);
            this.Controls.Add(this.btnPrimeiraOpcao);
            this.Name = "MenuCargoEleitoral";
            this.Text = "MenuCargoEleitoral";
            this.Load += new System.EventHandler(this.MenuCargoEleitoral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSegundaOpcao;
        private System.Windows.Forms.Button btnPrimeiraOpcao;
        private System.Windows.Forms.Button btnTerceiraOpcao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;

        public Button BtnSegundaOpcao { get => btnSegundaOpcao; set => btnSegundaOpcao = value; }
        public Button BtnPrimeiraOpcao { get => btnPrimeiraOpcao; set => btnPrimeiraOpcao = value; }
        public Button BtnTerceiraOpcao { get => btnTerceiraOpcao; set => btnTerceiraOpcao = value; }
    }
}