namespace Trabalho_POO___Eleição.Entidades
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
    }
}
