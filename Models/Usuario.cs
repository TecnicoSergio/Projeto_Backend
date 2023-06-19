using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RpgApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public byte[] PasswordHash { get; set; } 
        public byte[] PasswordSalt { get; set; }
        public byte[] Foto { get; set; } 
        public string Latitude { get; set; } = "";
        public string Longitude { get; set; } = "";
        //public Datetime? DataAcesso { get; set; }

        [NotMapped]
        public string PasswordString { get; set; } = "132131321";
        public List<Personagem> Personagens { get; set;}
        public DateTime DataAcesso { get; internal set; }
    }
}