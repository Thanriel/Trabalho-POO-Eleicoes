namespace Trabalho_POO___Eleição
{
    partial class TelaCadastroPartidos
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
            this.btnCadastroEleicao = new System.Windows.Forms.Button();
            this.tipoEleicao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.anoEleicao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastroEleicao
            // 
            this.btnCadastroEleicao.Location = new System.Drawing.Point(365, 300);
            this.btnCadastroEleicao.Name = "btnCadastroEleicao";
            this.btnCadastroEleicao.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroEleicao.TabIndex = 15;
            this.btnCadastroEleicao.Text = "Cadastro";
            this.btnCadastroEleicao.UseVisualStyleBackColor = true;
            // 
            // tipoEleicao
            // 
            this.tipoEleicao.FormattingEnabled = true;
            this.tipoEleicao.Items.AddRange(new object[] {
            "Prefeito",
            "Vereador"});
            this.tipoEleicao.Location = new System.Drawing.Point(330, 241);
            this.tipoEleicao.Name = "tipoEleicao";
            this.tipoEleicao.Size = new System.Drawing.Size(144, 21);
            this.tipoEleicao.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(344, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo de Eleição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(385, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ano";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // anoEleicao
            // 
            this.anoEleicao.Location = new System.Drawing.Point(353, 152);
            this.anoEleicao.Name = "anoEleicao";
            this.anoEleicao.Size = new System.Drawing.Size(100, 20);
            this.anoEleicao.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(337, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cadastro de partido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Programa de eleições";
            // 
            // TelaCadastroPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastroEleicao);
            this.Controls.Add(this.tipoEleicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.anoEleicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroPartidos";
            this.Text = "TelaCadastroPartidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroEleicao;
        private System.Windows.Forms.ComboBox tipoEleicao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox anoEleicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}