namespace Trabalho_POO___Eleição.Entidades
{
    public class Eleicao
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Ano { get; set; }

        public string Tipo { get; set; }

        public static int ContadorId = 1;

        public Eleicao(int id, string nome, int ano, string tipo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Ano = ano;
            this.Tipo = tipo;
        }
    }
}
