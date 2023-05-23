using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgApi.Models.Enuns;

namespace RpgApi.Models
{
    public class Arma
    {
        public int Id { get; set; }
        public string Nome { get; set;} = "Pistola 365";
        public int Dano { get; set; }
        public  string Personagem { get; set; } = "Animado";
        public ClasseEnum Classe{ get; set; } = ClasseEnum.Cavaleiro;
        
    }
}