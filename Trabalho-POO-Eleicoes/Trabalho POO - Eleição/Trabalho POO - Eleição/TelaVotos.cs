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

        private void TelaVotos_Load(object sender, EventArgs e)
        {

        }
    }
}
