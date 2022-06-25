using System;
using System.IO;
using System.Windows.Forms;
using TrabalhoPooEleicoes.Entidades;

namespace TrabalhoPooEleicoes
{
    public partial class TelaFinalização : Form
    {
        public TelaFinalização()
        {
            InitializeComponent();
            GerarComboBoxEleicao();
        }

        private void btnFinalizarEleicao_Click(object sender, EventArgs e)
        {
            var path = "votosinseridos.txt";

            Stream saidaVotos = File.Open(path, FileMode.Create);

            StreamWriter escritorVotos = new StreamWriter(saidaVotos);

            escritorVotos.WriteLine("Eleição;TipoVoto;Candidato");

            foreach (Voto voto in Listas.listaVoto)
            {
                escritorVotos.WriteLine(voto.ToString());
            }

            escritorVotos.Close();
            saidaVotos.Close();

            MessageBox.Show($"Votos em Branco: {Voto.ContaVotosBrancos(comboBoxEleicaoFin.Text)}");
            MessageBox.Show($"Votos Nulos: {Voto.ContaVotosNulos(comboBoxEleicaoFin.Text)}");
            Voto.ContagemVotosCandidato(comboBoxEleicaoFin.Text);
        }

        public void GerarComboBoxEleicao()
        {
            foreach (Eleicao eleicao in Listas.listaEleicao)
            {
                this.comboBoxEleicaoFin.Items.Add(eleicao.Nome);
            }
        }
    }
}
