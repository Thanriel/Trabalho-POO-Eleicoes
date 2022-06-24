using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPooEleicoes.Entidades;

namespace TrabalhoPooEleicoes
{
    public partial class TelaPrimaria : Form
    {
        public TelaPrimaria()
        {
            InitializeComponent();
        }

        private void btnRegistrarEleicao_Click(object sender, EventArgs e)
        {
            TelaCadastroEleicao tela = new TelaCadastroEleicao();
            tela.Show();
        }

        private void btnInserirVoto_Click(object sender, EventArgs e)
        {
            TelaVotos tela = new TelaVotos();
            tela.Show();
        }

        private void btnFinalizarEleicao_Click(object sender, EventArgs e)
        {
            TelaFinalização tela = new TelaFinalização();
            tela.Show();

        }

        private void btnCadastrarPartido_Click(object sender, EventArgs e)
        {
            TelaCadastroPartidos tela = new TelaCadastroPartidos();
            tela.Show();
        }

        private void btnCadastrarCandidato_Click(object sender, EventArgs e)
        {
            TelaCadastroCandidato tela = new TelaCadastroCandidato();
            tela.Show();
        }
    }
}
