namespace TrabalhoPooEleicoes
{
    partial class TelaCadastroCandidato
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
            this.label2 = new System.Windows.Forms.Label();
            this.nomeCandidato = new System.Windows.Forms.TextBox();
            this.idadeCandidato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.partidoCandidato = new System.Windows.Forms.ComboBox();
            this.btnCadastrarCandidato = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoCandidato = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ImportarCandidatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Programa de eleições";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(347, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // nomeCandidato
            // 
            this.nomeCandidato.Location = new System.Drawing.Point(310, 126);
            this.nomeCandidato.Name = "nomeCandidato";
            this.nomeCandidato.Size = new System.Drawing.Size(121, 20);
            this.nomeCandidato.TabIndex = 5;
            // 
            // idadeCandidato
            // 
            this.idadeCandidato.Location = new System.Drawing.Point(310, 192);
            this.idadeCandidato.Name = "idadeCandidato";
            this.idadeCandidato.Size = new System.Drawing.Size(121, 20);
            this.idadeCandidato.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(347, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(347, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Partido";
            // 
            // partidoCandidato
            // 
            this.partidoCandidato.FormattingEnabled = true;
            this.partidoCandidato.Location = new System.Drawing.Point(310, 260);
            this.partidoCandidato.Name = "partidoCandidato";
            this.partidoCandidato.Size = new System.Drawing.Size(121, 21);
            this.partidoCandidato.TabIndex = 9;
            // 
            // btnCadastrarCandidato
            // 
            this.btnCadastrarCandidato.Location = new System.Drawing.Point(393, 383);
            this.btnCadastrarCandidato.Name = "btnCadastrarCandidato";
            this.btnCadastrarCandidato.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCandidato.TabIndex = 10;
            this.btnCadastrarCandidato.Text = "Cadastrar";
            this.btnCadastrarCandidato.UseVisualStyleBackColor = true;
            this.btnCadastrarCandidato.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(306, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cadastrar Candidato";
            // 
            // tipoCandidato
            // 
            this.tipoCandidato.FormattingEnabled = true;
            this.tipoCandidato.Items.AddRange(new object[] {
            "Prefeito",
            "Vereador"});
            this.tipoCandidato.Location = new System.Drawing.Point(310, 331);
            this.tipoCandidato.Name = "tipoCandidato";
            this.tipoCandidato.Size = new System.Drawing.Size(121, 21);
            this.tipoCandidato.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(347, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo";
            // 
            // ImportarCandidatos
            // 
            this.ImportarCandidatos.Location = new System.Drawing.Point(274, 383);
            this.ImportarCandidatos.Name = "ImportarCandidatos";
            this.ImportarCandidatos.Size = new System.Drawing.Size(110, 23);
            this.ImportarCandidatos.TabIndex = 14;
            this.ImportarCandidatos.Text = "Importar Candidatos";
            this.ImportarCandidatos.UseVisualStyleBackColor = true;
            this.ImportarCandidatos.Click += new System.EventHandler(this.ImportarCandidatos_Click);
            // 
            // TelaCadastroCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImportarCandidatos);
            this.Controls.Add(this.tipoCandidato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCadastrarCandidato);
            this.Controls.Add(this.partidoCandidato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idadeCandidato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomeCandidato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroCandidato";
            this.Text = "TelaCadastroCandidato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeCandidato;
        private System.Windows.Forms.TextBox idadeCandidato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox partidoCandidato;
        private System.Windows.Forms.Button btnCadastrarCandidato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipoCandidato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ImportarCandidatos;
    }
}