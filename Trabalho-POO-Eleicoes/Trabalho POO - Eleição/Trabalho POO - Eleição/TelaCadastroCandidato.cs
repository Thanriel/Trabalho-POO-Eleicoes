using System;
using System.Windows.Forms;
using Trabalho_POO___Eleição.Entidades;

namespace Trabalho_POO___Eleição
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
    }
}
