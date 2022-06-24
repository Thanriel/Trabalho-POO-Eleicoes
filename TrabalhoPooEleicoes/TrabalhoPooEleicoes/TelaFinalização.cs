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

            MessageBox.Show($"Votos em Branco: {this.ContaVotosBrancos(comboBoxEleicaoFin.Text)}");
            MessageBox.Show($"Votos Nulos: {this.ContaVotosNulos(comboBoxEleicaoFin.Text)}");
            this.ContagemVotosCandidato(comboBoxEleicaoFin.Text);
        }

        public void GerarComboBoxEleicao()
        {
            foreach (Eleicao eleicao in Listas.listaEleicao)
            {
                this.comboBoxEleicaoFin.Items.Add(eleicao.Nome);
            }
        }

        public int ContaVotosBrancos(string Eleicao)
        {
            int votoBranco = 0;

            foreach (Voto voto in Listas.listaVoto)
            {
                if (voto.TipoVoto.Equals("Branco") && voto.Eleicao.Equals(Eleicao))
                {
                    votoBranco++;
                }
            }

            return votoBranco;
        }

        public int ContaVotosNulos(string Eleicao)
        {
            int votoNulo = 0;

            foreach (Voto voto in Listas.listaVoto)
            {
                if (voto.TipoVoto.Equals("Nulo") && voto.Eleicao.Equals(Eleicao))
                {
                    votoNulo++;
                }
            }

            return votoNulo;
        }

        public void ContagemVotosCandidato(string eleicao)
        {
            var qtdCandidato = Listas.listaCandidato.Count();
            int[] votos = new int[qtdCandidato];
            int i;

            foreach (Voto voto in Listas.listaVoto)
            {
                if (voto.Eleicao.Equals(eleicao))
                {
                    if(voto.TipoVoto!="Branco" && voto.TipoVoto!="Nulo")
                    {
                        foreach (Candidato candidato in Listas.listaCandidato)
                        {
                            if (voto.Candidato.Equals(candidato.Nome))
                            {
                                votos[candidato.Id - 1]++;
                            }
                        }
                    }
                }
            }
            string CandidatoVencedor = "";
            i = this.Vencedor(votos);

            if (i >= 0)
            {
                foreach (Candidato candidato1 in Listas.listaCandidato)
                {
                    if (candidato1.Id == i)
                        CandidatoVencedor = candidato1.Nome;
                }

                MessageBox.Show($"Candidato Vencedor {CandidatoVencedor}");
            }
            else
            {
                MessageBox.Show($"Houve um empate, deve haver um segundo turno!");
            }
        }

        public int Vencedor(int[] votos)
        {
            int count = 0;
            int qtd_votos = 0;

            for (int i = 1; i <= votos.Length; i++)
            {
                if (votos[i-1] == qtd_votos)
                    count = -1;

                if (votos[i-1] > qtd_votos)
                {
                    qtd_votos = votos[i-1];
                    count = i;
                }
            }

            return count;
        }
    }
}
