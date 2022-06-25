using System;
using System.IO;
using System.Windows.Forms;

namespace TrabalhoPooEleicoes.Entidades
{
    public  class Candidato
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Partido { get; set; }

        public int Idade { get; set; }

        public string Tipo { get; set; }

        public static int ContadorId = 1; 

        public Candidato( 
            int Id,
            string Nome,
            string Partido,
            int Idade,
            string Tipo)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Partido = Partido;
            this.Idade = Idade;
            this.Tipo = Tipo;
        }


        public void CadastrarCandidato(Candidato candidato)
        {
            Listas.listaCandidato.Add(candidato);
        }
    }
}
