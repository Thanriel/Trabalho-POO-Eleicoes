using System.Linq;
using System.Windows.Forms;

namespace TrabalhoPooEleicoes.Entidades
{
    public class Voto
    {
        public int Id { get; set; }

        public string Candidato { get; set; }

        public string Eleicao { get; set; }

        public string TipoVoto { get; set; }

        public static int ContadorId = 1;

        public Voto(
            int id, 
            string candidato, 
            string eleicao,
            string tipoVoto)
        {
            this.Id = id;
            this.Candidato = candidato;
            this.Eleicao = eleicao;
            this.TipoVoto = tipoVoto;
        }

        public override string ToString()
        {
            return $"{this.Eleicao};{this.TipoVoto};{this.Candidato}";
        }

        public static int ContaVotosBrancos(string Eleicao)
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

        public static int ContaVotosNulos(string Eleicao)
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

        public static void ContagemVotosCandidato(string eleicao)
        {
            var qtdCandidato = Listas.listaCandidato.Count();
            int[] votos = new int[qtdCandidato];
            int i;

            foreach (Voto voto in Listas.listaVoto)
            {
                if (voto.Eleicao.Equals(eleicao))
                {
                    if (voto.TipoVoto != "Branco" && voto.TipoVoto != "Nulo")
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
            i = Vencedor(votos);

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

        private static int Vencedor(int[] votos)
        {
            int count = 0;
            int qtd_votos = 0;

            for (int i = 1; i <= votos.Length; i++)
            {
                if (votos[i - 1] == qtd_votos)
                    count = -1;

                if (votos[i - 1] > qtd_votos)
                {
                    qtd_votos = votos[i - 1];
                    count = i;
                }
            }

            return count;
        }
    }
}
