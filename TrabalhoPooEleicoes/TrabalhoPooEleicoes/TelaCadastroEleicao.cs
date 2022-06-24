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
    public partial class TelaCadastroEleicao : Form
    {
        public TelaCadastroEleicao()
        {
            InitializeComponent();
        }

        private void btnCadastroPartido_Click(object sender, EventArgs e)
        {
            try 
            {
                Eleicao eleicao = new Eleicao(Eleicao.ContadorId,this.nomeEleicao.Text,int.Parse(this.anoEleicao.Text), this.T.Text);
                Listas.listaEleicao.Add(eleicao);
                TelaCadastroEleicao tela = new TelaCadastroEleicao();


                MessageBox.Show("Eleição cadastrada com sucesso");
                Eleicao.ContadorId++;

                tela.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar eleição: {ex}");
            }
            



        }

        private void ImportarEleicoes_Click(object sender, EventArgs e)
        {
            var path = "dadoseleicoes.txt";

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
                        var eleicoesDoc = new Eleicao(
                            Eleicao.ContadorId,
                            dadosLinha[0],
                            int.Parse(dadosLinha[1]),
                            dadosLinha[2]);

                        Listas.listaEleicao.Add(eleicoesDoc);
                        Eleicao.ContadorId++;
                    }

                    linha = leitor.ReadLine();
                }

                leitor.Close();
                entrada.Close();

                MessageBox.Show("Eleições importadas com sucesso!");
            }
        }
    }
}
