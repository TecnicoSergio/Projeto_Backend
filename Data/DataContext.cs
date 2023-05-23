using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Personagem> Personagens { get; set; } 
        public DbSet<Arma> Armas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>().HasData
            (
                new Personagem() {Id = 1 },
                new Personagem { Id = 2, Nome = "Sam"},
                new Personagem { Id = 3, Nome = "Sérgio", PontosVida=100, Forca=15},
                new Personagem { Id = 4, Nome = "Duda" , PontosVida=100, Forca=15},
                new Personagem { Id = 5, Nome = "Marta", PontosVida=100, Forca=15},
                new Personagem { Id = 6, Nome = "Olga", PontosVida=100, Forca=15},

                //==============================================================
                new Arma() {Id = 1 },
                new Arma { Id = 2, Nome = "Fuzil", Dano=100, Personagem="Mane"},
                new Arma { Id = 3, Nome = "Ponto 40", Dano=100, Personagem="ola"}

            );
            
        }
        
       

        
    }
}