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
    public partial class TelaCadastroPartidos : Form
    {
        public TelaCadastroPartidos()
        {
            InitializeComponent();
        }

        private void btnCadastroPartido_Click(object sender, EventArgs e)
        {

            try
            {
                TelaCadastroPartidos tela = new TelaCadastroPartidos();
                Partido partido = new Partido(1, this.nomePartido.Text);
                Listas.listaPartido.Add(partido);

                MessageBox.Show("Partido cadastrado com sucesso");
                tela.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar partido {ex}");   
            }
        }
    }
}
