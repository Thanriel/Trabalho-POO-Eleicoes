namespace Trabalho_POO___Eleição.Entidades
{
    public class Partido
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Partido(
            int id, 
            string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }
}
