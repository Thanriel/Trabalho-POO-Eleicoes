namespace TrabalhoPooEleicoes.Entidades
{
    public class Partido
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public static int ContadorId = 1;

        public Partido(
            int id, 
            string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }
}
