namespace Trabalho_POO___Eleição
{
    partial class TelaPrimaria
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarEleicao = new System.Windows.Forms.Button();
            this.btnInserirVoto = new System.Windows.Forms.Button();
            this.btnFinalizarEleicao = new System.Windows.Forms.Button();
            this.btnCadastrarCandidato = new System.Windows.Forms.Button();
            this.btnCadastrarPartido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(283, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Programa de eleições";
            // 
            // btnRegistrarEleicao
            // 
            this.btnRegistrarEleicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEleicao.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarEleicao.Location = new System.Drawing.Point(104, 203);
            this.btnRegistrarEleicao.Name = "btnRegistrarEleicao";
            this.btnRegistrarEleicao.Size = new System.Drawing.Size(180, 50);
            this.btnRegistrarEleicao.TabIndex = 7;
            this.btnRegistrarEleicao.Text = "Registrar Eleição";
            this.btnRegistrarEleicao.UseVisualStyleBackColor = true;
            this.btnRegistrarEleicao.Click += new System.EventHandler(this.btnRegistrarEleicao_Click);
            // 
            // btnInserirVoto
            // 
            this.btnInserirVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnInserirVoto.ForeColor = System.Drawing.Color.Black;
            this.btnInserirVoto.Location = new System.Drawing.Point(203, 275);
            this.btnInserirVoto.Name = "btnInserirVoto";
            this.btnInserirVoto.Size = new System.Drawing.Size(180, 50);
            this.btnInserirVoto.TabIndex = 9;
            this.btnInserirVoto.Text = "Inserir Voto";
            this.btnInserirVoto.UseVisualStyleBackColor = true;
            this.btnInserirVoto.Click += new System.EventHandler(this.btnInserirVoto_Click);
            // 
            // btnFinalizarEleicao
            // 
            this.btnFinalizarEleicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarEleicao.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarEleicao.Location = new System.Drawing.Point(410, 275);
            this.btnFinalizarEleicao.Name = "btnFinalizarEleicao";
            this.btnFinalizarEleicao.Size = new System.Drawing.Size(180, 50);
            this.btnFinalizarEleicao.TabIndex = 11;
            this.btnFinalizarEleicao.Text = "Finalizar Eleição";
            this.btnFinalizarEleicao.UseVisualStyleBackColor = true;
            this.btnFinalizarEleicao.Click += new System.EventHandler(this.btnFinalizarEleicao_Click);
            // 
            // btnCadastrarCandidato
            // 
            this.btnCadastrarCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarCandidato.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarCandidato.Location = new System.Drawing.Point(304, 203);
            this.btnCadastrarCandidato.Name = "btnCadastrarCandidato";
            this.btnCadastrarCandidato.Size = new System.Drawing.Size(180, 50);
            this.btnCadastrarCandidato.TabIndex = 13;
            this.btnCadastrarCandidato.Text = "Cadastrar Candidato";
            this.btnCadastrarCandidato.UseVisualStyleBackColor = true;
            this.btnCadastrarCandidato.Click += new System.EventHandler(this.btnCadastrarCandidato_Click);
            // 
            // btnCadastrarPartido
            // 
            this.btnCadastrarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarPartido.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarPartido.Location = new System.Drawing.Point(505, 203);
            this.btnCadastrarPartido.Name = "btnCadastrarPartido";
            this.btnCadastrarPartido.Size = new System.Drawing.Size(180, 50);
            this.btnCadastrarPartido.TabIndex = 15;
            this.btnCadastrarPartido.Text = "Cadastrar Partido";
            this.btnCadastrarPartido.UseVisualStyleBackColor = true;
            this.btnCadastrarPartido.Click += new System.EventHandler(this.btnCadastrarPartido_Click);
            // 
            // TelaPrimaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarPartido);
            this.Controls.Add(this.btnCadastrarCandidato);
            this.Controls.Add(this.btnFinalizarEleicao);
            this.Controls.Add(this.btnInserirVoto);
            this.Controls.Add(this.btnRegistrarEleicao);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TelaPrimaria";
            this.Text = "Tela Primaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarEleicao;
        private System.Windows.Forms.Button btnInserirVoto;
        private System.Windows.Forms.Button btnFinalizarEleicao;
        private System.Windows.Forms.Button btnCadastrarCandidato;
        private System.Windows.Forms.Button btnCadastrarPartido;
    }
}