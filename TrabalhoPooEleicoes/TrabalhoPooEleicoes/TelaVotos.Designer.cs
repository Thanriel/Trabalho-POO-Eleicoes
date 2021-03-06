namespace TrabalhoPooEleicoes
{
    partial class TelaVotos
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
            this.label3 = new System.Windows.Forms.Label();
            this.eleicaoVoto = new System.Windows.Forms.ComboBox();
            this.candidatoVoto = new System.Windows.Forms.ComboBox();
            this.btnVoto = new System.Windows.Forms.Button();
            this.comboBoxVoto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Voto = new System.Windows.Forms.Label();
            this.ImportarVotos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(271, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programa de eleições";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(340, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Realizar Voto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(290, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eleição";
            // 
            // eleicaoVoto
            // 
            this.eleicaoVoto.FormattingEnabled = true;
            this.eleicaoVoto.Location = new System.Drawing.Point(294, 153);
            this.eleicaoVoto.Name = "eleicaoVoto";
            this.eleicaoVoto.Size = new System.Drawing.Size(169, 21);
            this.eleicaoVoto.TabIndex = 6;
            // 
            // candidatoVoto
            // 
            this.candidatoVoto.FormattingEnabled = true;
            this.candidatoVoto.Location = new System.Drawing.Point(294, 209);
            this.candidatoVoto.Name = "candidatoVoto";
            this.candidatoVoto.Size = new System.Drawing.Size(169, 21);
            this.candidatoVoto.TabIndex = 8;
            // 
            // btnVoto
            // 
            this.btnVoto.Location = new System.Drawing.Point(388, 307);
            this.btnVoto.Name = "btnVoto";
            this.btnVoto.Size = new System.Drawing.Size(75, 23);
            this.btnVoto.TabIndex = 9;
            this.btnVoto.Text = "Votar";
            this.btnVoto.UseVisualStyleBackColor = true;
            this.btnVoto.Click += new System.EventHandler(this.btnVoto_Click);
            // 
            // comboBoxVoto
            // 
            this.comboBoxVoto.FormattingEnabled = true;
            this.comboBoxVoto.Items.AddRange(new object[] {
            "Normal",
            "Nulo",
            "Branco"});
            this.comboBoxVoto.Location = new System.Drawing.Point(294, 264);
            this.comboBoxVoto.Name = "comboBoxVoto";
            this.comboBoxVoto.Size = new System.Drawing.Size(169, 21);
            this.comboBoxVoto.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(290, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Candidato";
            // 
            // Voto
            // 
            this.Voto.AutoSize = true;
            this.Voto.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.Voto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Voto.Location = new System.Drawing.Point(290, 242);
            this.Voto.Name = "Voto";
            this.Voto.Size = new System.Drawing.Size(38, 19);
            this.Voto.TabIndex = 11;
            this.Voto.Text = "Voto";
            // 
            // ImportarVotos
            // 
            this.ImportarVotos.Location = new System.Drawing.Point(294, 307);
            this.ImportarVotos.Name = "ImportarVotos";
            this.ImportarVotos.Size = new System.Drawing.Size(88, 23);
            this.ImportarVotos.TabIndex = 12;
            this.ImportarVotos.Text = "Importar Votos";
            this.ImportarVotos.UseVisualStyleBackColor = true;
            this.ImportarVotos.Click += new System.EventHandler(this.ImportarVotos_Click);
            // 
            // TelaVotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImportarVotos);
            this.Controls.Add(this.Voto);
            this.Controls.Add(this.comboBoxVoto);
            this.Controls.Add(this.btnVoto);
            this.Controls.Add(this.candidatoVoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eleicaoVoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaVotos";
            this.Text = "Tela Votos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox eleicaoVoto;
        private System.Windows.Forms.ComboBox candidatoVoto;
        private System.Windows.Forms.Button btnVoto;
        private System.Windows.Forms.ComboBox comboBoxVoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Voto;
        private System.Windows.Forms.Button ImportarVotos;
    }
}