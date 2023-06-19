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
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Habilidade> Habilidades { get; set; }
        public DbSet<PersonagemHabilidade> PersonagemHabilidades { get; set; }

        public DbSet<Caracteristica> Caracteristicas { get; set; }
        public DbSet<Animal> Animais { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>().HasData
            (
                new Personagem() {Id = 1 },
                new Personagem() { Id = 2, Nome = "Sam"},
                new Personagem() { Id = 3, Nome = "Sérgio", PontosVida=100, Forca=15},
                new Personagem() { Id = 4, Nome = "Duda" , PontosVida=100, Forca=15},
                new Personagem() { Id = 5, Nome = "Marta", PontosVida=100, Forca=15},
                new Personagem() { Id = 6, Nome = "Olga", PontosVida=100, Forca=15}
  
            );

            modelBuilder.Entity<Arma>().HasData
            (
                new Arma() {Id = 2, Nome = "Fuzil", Dano=100, PersonagemId=1},
                new Arma() {Id = 2, Nome = "Fuzil", Dano=45, PersonagemId=2},
                new Arma() {Id = 3, Nome = "Ponto 40", Dano=25, PersonagemId=3}


            );

              modelBuilder.Entity<Usuario>().HasData
            (
                new Usuario() {Id = 1, Username = "Fuzil",
                Latitude= "32131",Longitude="32131", PasswordString="32131"},
                new Usuario() {Id = 2, Username = "Fuzil",
                Latitude= "32131",Longitude="32131", PasswordString="32131"},
                new Usuario() {Id = 3, Username = "Fuzil",
                Latitude= "32131",Longitude="32131", PasswordString="32131"}


            );

        
 
        }

        

      

        
       

        
    }
}