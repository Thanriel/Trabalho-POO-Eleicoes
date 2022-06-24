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
                Partido partido = new Partido(Partido.ContadorId, this.nomePartido.Text);
                Listas.listaPartido.Add(partido);

                MessageBox.Show("Partido cadastrado com sucesso");
                Partido.ContadorId++;

                tela.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar partido {ex}");   
            }
        }

        private void ImportarPartidos_Click(object sender, EventArgs e)
        {
            var path = "dadospartidos.txt";

            if (File.Exists(path))
            {
                Stream entrada = File.Open(path, FileMode.Open);

                StreamReader leitor = new StreamReader(entrada);

                string dadosLinha = leitor.ReadLine();

                while (dadosLinha != null)
                {
                    var partidosDoc = new Partido(
                        Partido.ContadorId,
                        dadosLinha);

                    Listas.listaPartido.Add(partidosDoc);
                    Partido.ContadorId++;
                    dadosLinha = leitor.ReadLine();
                }

                leitor.Close();
                entrada.Close();

                MessageBox.Show("Partidos importados com sucesso!");
            }
        }
    }
}
