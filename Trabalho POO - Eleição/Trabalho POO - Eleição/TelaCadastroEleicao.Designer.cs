﻿namespace Trabalho_POO___Eleição
{
    partial class TelaCadastroEleicao
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
            this.btnCadastroPartido = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.anoEleicao = new System.Windows.Forms.TextBox();
            this.T = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(292, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa de eleições";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(344, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadastro de eleição";
            // 
            // btnCadastroPartido
            // 
            this.btnCadastroPartido.Location = new System.Drawing.Point(375, 351);
            this.btnCadastroPartido.Name = "btnCadastroPartido";
            this.btnCadastroPartido.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroPartido.TabIndex = 8;
            this.btnCadastroPartido.Text = "Cadastrar";
            this.btnCadastroPartido.UseVisualStyleBackColor = true;
            this.btnCadastroPartido.Click += new System.EventHandler(this.btnCadastroPartido_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(395, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ano";
            // 
            // anoEleicao
            // 
            this.anoEleicao.Location = new System.Drawing.Point(310, 185);
            this.anoEleicao.Name = "anoEleicao";
            this.anoEleicao.Size = new System.Drawing.Size(208, 20);
            this.anoEleicao.TabIndex = 9;
            // 
            // T
            // 
            this.T.FormattingEnabled = true;
            this.T.Items.AddRange(new object[] {
            "Prefeito",
            "Vereador"});
            this.T.Location = new System.Drawing.Point(310, 279);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(211, 21);
            this.T.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(395, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo";
            // 
            // TelaCadastroEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.T);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.anoEleicao);
            this.Controls.Add(this.btnCadastroPartido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroEleicao";
            this.Text = "Tela Cadastro de Eleições";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastroPartido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox anoEleicao;
        private System.Windows.Forms.ComboBox T;
        private System.Windows.Forms.Label label5;
    }
}

