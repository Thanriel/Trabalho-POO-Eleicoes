using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_POO___Eleição.Entidades;

namespace Trabalho_POO___Eleição
{
    public partial class TelaCadastroEleicao : Form
    {
        public TelaCadastroEleicao()
        {
            InitializeComponent();
        }

        private void btnCadastroPartido_Click(object sender, EventArgs e)
        {
            try 
            {
                Eleicao eleicao = new Eleicao(1, int.Parse(this.anoEleicao.Text), this.T.Text);
                Listas.listaEleicao.Add(eleicao);
                TelaCadastroEleicao tela = new TelaCadastroEleicao();


                MessageBox.Show("Eleição cadastrada com sucesso");
                tela.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar eleição: {ex}");
            }
            



        }
    }
}
