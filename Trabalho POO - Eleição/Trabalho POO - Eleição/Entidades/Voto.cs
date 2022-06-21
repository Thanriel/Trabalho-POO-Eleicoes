using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO___Eleição.Entidades
{
    public class Voto
    {
        public int Id { get; set; }

        public string Candidato { get; set; }

        public string Eleicao { get; set; }

        public Voto(
            int id, 
            string candidato, 
            string eleicao)
        {
            this.Id = id;
            this.Candidato = candidato;
            this.Eleicao = eleicao;
        }
    }
}
