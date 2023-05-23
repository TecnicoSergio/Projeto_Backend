using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgApi.Models.Enuns;

namespace RpgApi.Models
{
    public class Caracteristica
    {
        public int Id { get; set; }
        public string Etinia { get; set; } = "";
        public int Idade { get; set; }
        public double Altura { get; set; } = 1.75;
        public int Peso { get; set; } = 100;
        public string Estatura { get; set; } = "";
        public ClasseEnum Classe{ get; set; } = ClasseEnum.Caracteristica;
        
    }
}