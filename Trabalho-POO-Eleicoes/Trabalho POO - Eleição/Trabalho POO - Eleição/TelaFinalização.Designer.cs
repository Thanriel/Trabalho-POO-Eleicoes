namespace Trabalho_POO___Eleição
{
    partial class TelaFinalização
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
            this.comboBoxEleicaoFin = new System.Windows.Forms.ComboBox();
            this.btnFinalizarEleicao = new System.Windows.Forms.Button();
            this.comboBoxIdEleicao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Programa de eleições";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(315, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cadastro de partido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(353, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Eleição";
            // 
            // comboBoxEleicaoFin
            // 
            this.comboBoxEleicaoFin.FormattingEnabled = true;
            this.comboBoxEleicaoFin.Location = new System.Drawing.Point(269, 221);
            this.comboBoxEleicaoFin.Name = "comboBoxEleicaoFin";
            this.comboBoxEleicaoFin.Size = new System.Drawing.Size(221, 21);
            this.comboBoxEleicaoFin.TabIndex = 13;
            this.comboBoxEleicaoFin.SelectedIndexChanged += new System.EventHandler(this.comboBoxEleicaoFin_SelectedIndexChanged);
            this.comboBoxEleicaoFin.TextChanged += new System.EventHandler(this.comboBoxEleicaoFin_TextChanged);
            // 
            // btnFinalizarEleicao
            // 
            this.btnFinalizarEleicao.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarEleicao.Location = new System.Drawing.Point(344, 346);
            this.btnFinalizarEleicao.Name = "btnFinalizarEleicao";
            this.btnFinalizarEleicao.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizarEleicao.TabIndex = 14;
            this.btnFinalizarEleicao.Text = "Finalizar";
            this.btnFinalizarEleicao.UseVisualStyleBackColor = true;
            this.btnFinalizarEleicao.Click += new System.EventHandler(this.btnFinalizarEleicao_Click);
            // 
            // comboBoxIdEleicao
            // 
            this.comboBoxIdEleicao.FormattingEnabled = true;
            this.comboBoxIdEleicao.Location = new System.Drawing.Point(319, 248);
            this.comboBoxIdEleicao.Name = "comboBoxIdEleicao";
            this.comboBoxIdEleicao.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdEleicao.TabIndex = 15;
            // 
            // TelaFinalização
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxIdEleicao);
            this.Controls.Add(this.btnFinalizarEleicao);
            this.Controls.Add(this.comboBoxEleicaoFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Name = "TelaFinalização";
            this.Text = "TelaFinalização";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEleicaoFin;
        private System.Windows.Forms.Button btnFinalizarEleicao;
        private System.Windows.Forms.ComboBox comboBoxIdEleicao;
    }
}