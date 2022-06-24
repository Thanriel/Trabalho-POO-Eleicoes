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
    public partial class TelaVotos : Form
    {
        public TelaVotos()
        {
            InitializeComponent();
            GeraComboxEleicao();
            GeraComboxTipoCandidato();
        }

        public void GeraComboxEleicao()
        {
            foreach (Eleicao p in Listas.listaEleicao)
            {
                this.eleicaoVoto.Items.Add(p.Nome);
            }
        }

        public void GeraComboxTipoCandidato()
        {
            foreach (Candidato candidato in Listas.listaCandidato)
            {
                this.candidatoVoto.Items.Add(candidato.Nome);
            }
        }

        private void btnVoto_Click(object sender, EventArgs e)
        {
            try
            {
                TelaVotos tela = new TelaVotos();
                Voto voto = new Voto(Entidades.Voto.ContadorId, this.candidatoVoto.Text, this.eleicaoVoto.Text, this.comboBoxVoto.Text);
                Listas.listaVoto.Add(voto);

                MessageBox.Show("Voto inserido com sucesso");
                Entidades.Voto.ContadorId++;

                tela.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao inserir voto {ex}");
            }
        }

        private void ImportarVotos_Click(object sender, EventArgs e)
        {
            var path = "dadosvotos.txt";

            if (File.Exists(path))
            {
                Stream entrada = File.Open(path, FileMode.Open);

                StreamReader leitor = new StreamReader(entrada);

                string linha = leitor.ReadLine();

                while (linha != null)
                {
                    var dadosLinha = linha.Split(',');

                    if (dadosLinha != null)
                    {
                        var votosDoc = new Voto(Entidades.Voto.ContadorId, dadosLinha[0], dadosLinha[1], dadosLinha[2]);

                        votosDoc.Candidato = dadosLinha[0];
                        votosDoc.Eleicao = dadosLinha[1];
                        votosDoc.TipoVoto = dadosLinha[2];

                        Listas.listaVoto.Add(votosDoc);
                        Entidades.Voto.ContadorId++;
                    }

                    linha = leitor.ReadLine();
                }

                leitor.Close();
                entrada.Close();

                MessageBox.Show("Votos importados com sucesso!");
            }
        }
    }
}
