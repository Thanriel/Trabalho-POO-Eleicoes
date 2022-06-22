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
    public partial class TelaFinalização : Form
    {
        public TelaFinalização()
        {
            InitializeComponent();
            GerarComboBoxEleicao();
        }

        private void btnFinalizarEleicao_Click(object sender, EventArgs e)
        {
            var path = "C:/Users/weule/source/repos/Trabalho-POO-Eleicoes/Trabalho-POO-Eleicoes/Trabalho POO - Eleição/Trabalho POO - Eleição/votos.txt";

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

        private void comboBoxEleicaoFin_TextChanged(object sender, EventArgs e)
        {
            foreach (Eleicao eleicao in Listas.listaEleicao)
            {
                if(eleicao.Nome.Equals(comboBoxEleicaoFin.Text))
                this.comboBoxIdEleicao.Items.Add(eleicao.Id);
            }
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

        private void ImportarVotos_Click(object sender, EventArgs e)
        {
            var path = "C:/Users/weule/source/repos/Trabalho-POO-Eleicoes/Trabalho-POO-Eleicoes/Trabalho POO - Eleição/Trabalho POO - Eleição/dadosvotos.txt";

            if (File.Exists(path))
            {
                Stream entrada = File.Open(path, FileMode.Open);

                StreamReader leitor = new StreamReader(entrada);

                leitor.ReadLine();

                string linha = leitor.ReadLine();

                while (linha != null)
                {
                    var dadosLinha = linha.Split(',');

                    if (dadosLinha != null)
                    {
                        var votosDoc = new Voto(Voto.ContadorId, dadosLinha[0], dadosLinha[1], dadosLinha[2]);

                        votosDoc.Candidato = dadosLinha[0];
                        votosDoc.Eleicao = dadosLinha[1];
                        votosDoc.TipoVoto = dadosLinha[2];

                        Listas.listaVoto.Add(votosDoc);
                    }

                    linha = leitor.ReadLine();
                }
            }

            
        }
    }
}
