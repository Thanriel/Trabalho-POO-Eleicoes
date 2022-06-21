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
    public partial class TelaFinalização : Form
    {
        public TelaFinalização()
        {
            InitializeComponent();
            GerarComboBoxEleicao();
        }

        private void btnFinalizarEleicao_Click(object sender, EventArgs e)
        {
            this.ContaVotosBrancos(comboBoxEleicaoFin.Text);
            this.ContaVotosNulos(comboBoxEleicaoFin.Text);
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
                if (voto.TipoVoto.Equals("Branco") && voto.Eleicao.Equals(Eleicao))
                {
                    votoNulo++;
                }
            }

            return votoNulo;
        }

        private void comboBoxEleicaoFin_TextChanged(object sender, EventArgs e)
        {
            foreach (Eleicao eleicao in Listas.listaEleicao)
            {
                if(eleicao.Nome.Equals(comboBoxEleicaoFin.Text))
                this.comboBoxIdEleicao.Items.Add(eleicao.Id);
            }
        }

        private void comboBoxEleicaoFin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ContagemVotosCandidato(string eleicao)
        {
            var qtdCandidato = Listas.listaCandidato.Count();
            int[] votos = new int[qtdCandidato];
            int i = 0;

            foreach (Voto voto in Listas.listaVoto)
            {
                if (voto.Eleicao.Equals(eleicao))
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
            string CandidatoVencedor = "";
            foreach (Candidato candidato1 in Listas.listaCandidato)
            {
                if(candidato1.Id == this.Vencedor(votos))
                    CandidatoVencedor = candidato1.Nome;
            }

            MessageBox.Show($"Candidato Vencedor {CandidatoVencedor}");
        }

        public int Vencedor(int[] votos)
        {
            int count = 0;
            int qtd_votos = 0;

            for (int i = 0; i < votos.Length; i++)
            {
                if (votos[i] > qtd_votos)
                {
                    qtd_votos = votos[i];
                    count = i;
                }
            }

            return count+1;
        }
    }
}
