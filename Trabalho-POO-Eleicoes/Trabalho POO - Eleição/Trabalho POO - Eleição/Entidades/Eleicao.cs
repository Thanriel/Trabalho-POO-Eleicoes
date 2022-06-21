namespace Trabalho_POO___Eleição.Entidades
{
    public class Eleicao
    {
        public int Id { get; set; }

        public int Ano { get; set; }

        public string Tipo { get; set; }

        public static int ContadorId = 1;

        public Eleicao(int id, int ano, string tipo)
        {
            this.Id = id;
            this.Ano = ano;
            this.Tipo = tipo;
        }
    }
}
