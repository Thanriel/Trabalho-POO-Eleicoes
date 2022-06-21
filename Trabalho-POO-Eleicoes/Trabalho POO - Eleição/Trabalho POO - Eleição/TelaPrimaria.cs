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
using Trabalho_POO___Eleição.Entidades;

namespace Trabalho_POO___Eleição
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
            var path = "votos.txt";

            Stream saidaVotos = File.Open(path, FileMode.Create);

            StreamWriter escritorVotos = new StreamWriter(saidaVotos);

            escritorVotos.WriteLine("Eleição;TipoVoto;Candidato");

            foreach (Voto voto in Listas.listaVoto)
            {
                escritorVotos.WriteLine(voto.ToString());
            }

            escritorVotos.Close();
            saidaVotos.Close();

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
