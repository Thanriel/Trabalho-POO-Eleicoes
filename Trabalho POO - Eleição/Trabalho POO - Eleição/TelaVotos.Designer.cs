namespace Trabalho_POO___Eleição
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
            this.label4 = new System.Windows.Forms.Label();
            this.candidatoVoto = new System.Windows.Forms.ComboBox();
            this.btnVoto = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(340, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Realizar Voto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(356, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eleição";
            // 
            // eleicaoVoto
            // 
            this.eleicaoVoto.FormattingEnabled = true;
            this.eleicaoVoto.Location = new System.Drawing.Point(295, 184);
            this.eleicaoVoto.Name = "eleicaoVoto";
            this.eleicaoVoto.Size = new System.Drawing.Size(169, 21);
            this.eleicaoVoto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(340, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Candidato";
            // 
            // candidatoVoto
            // 
            this.candidatoVoto.FormattingEnabled = true;
            this.candidatoVoto.Location = new System.Drawing.Point(295, 276);
            this.candidatoVoto.Name = "candidatoVoto";
            this.candidatoVoto.Size = new System.Drawing.Size(169, 21);
            this.candidatoVoto.TabIndex = 8;
            // 
            // btnVoto
            // 
            this.btnVoto.Location = new System.Drawing.Point(338, 367);
            this.btnVoto.Name = "btnVoto";
            this.btnVoto.Size = new System.Drawing.Size(75, 23);
            this.btnVoto.TabIndex = 9;
            this.btnVoto.Text = "Votar";
            this.btnVoto.UseVisualStyleBackColor = true;
            this.btnVoto.Click += new System.EventHandler(this.btnVoto_Click);
            // 
            // TelaVotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox candidatoVoto;
        private System.Windows.Forms.Button btnVoto;
    }
}