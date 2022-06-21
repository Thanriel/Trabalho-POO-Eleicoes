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
        }

        private void btnVoto_Click(object sender, EventArgs e)
        {

            try
            {
                TelaVotos tela = new TelaVotos();
                Voto voto = new Voto(1, this.candidatoVoto.Text, this.eleicaoVoto.Text);
                Listas.listaVoto.Add(voto);

                MessageBox.Show("Voto inserido com sucesso");
                tela.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao inserir voto {ex}");
            }
        }
    }
}
