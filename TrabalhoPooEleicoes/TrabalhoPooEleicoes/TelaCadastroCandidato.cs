using System;
using System.IO;
using System.Windows.Forms;
using TrabalhoPooEleicoes.Entidades;

namespace TrabalhoPooEleicoes
{
    public partial class TelaCadastroCandidato : Form
    {
        public TelaCadastroCandidato()
        {
            InitializeComponent();
            GeraComboxPartido();
        }

        public void GeraComboxPartido()
        {
            foreach(Partido partido in Listas.listaPartido)
            {
                this.partidoCandidato.Items.Add(partido.Nome);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TelaCadastroCandidato tela = new TelaCadastroCandidato();
                Candidato candidato = new Candidato(Candidato.ContadorId, this.nomeCandidato.Text, this.partidoCandidato.Text, int.Parse(this.idadeCandidato.Text), this.tipoCandidato.Text);
                Listas.listaCandidato.Add(candidato);
                MessageBox.Show("Candidato cadastrado com sucesso");
                Candidato.ContadorId++;

                tela.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar candidato: {ex}");
            }
        }

        private void ImportarCandidatos_Click(object sender, EventArgs e)
        {
            var path = "dadoscandidatos.txt";

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
                        var candidatosDoc = new Candidato(
                            Candidato.ContadorId,
                            dadosLinha[0],
                            dadosLinha[1],
                            int.Parse(dadosLinha[2]),
                            dadosLinha[3]);

                        Listas.listaCandidato.Add(candidatosDoc);
                        Candidato.ContadorId++;
                    }

                    linha = leitor.ReadLine();
                }

                leitor.Close();
                entrada.Close();

                MessageBox.Show("Candidatos importados com sucesso!");
            }
        }
    }
}
