using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgApi.Models.Enuns;
using RpgApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimaisController : ControllerBase
    {

         private Animal c = new Animal();
        private static List<Animal> animais = new List<Animal> {
            new Animal(),
            new Animal { Id = 1, Peixes = "Pacu", Repteis = "Cobra", Anfibios = "Sapo", Aves = "Periquito", Mamiferos = "Capivara"},
            new Animal { Id = 2, Peixes = "Tilapia", Repteis = "Lagarto", Anfibios = "rãs", Aves = "Canario", Mamiferos = "Muriqui"},
            new Animal { Id = 3, Peixes = "Curvina", Repteis = "Aperema", Anfibios = "Pererecas", Aves = "Calopsita", Mamiferos = "Preguiça"},
            new Animal { Id = 4, Peixes = "Salmão", Repteis = "Cotiarinha", Anfibios = "salamandra", Aves = "Cacatua", Mamiferos = "Tatu"},
            new Animal { Id = 5, Peixes = "Nemo", Repteis = "Jacaré-do-Pantanal", Anfibios = "tritoes", Aves = "Agapornis", Mamiferos = "Lobo-Guará"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(animais);
        }

        [HttpPost]
        public IActionResult AddAnimal(Animal novoAnimal)
        {
            animais.Add(novoAnimal);
            return Ok(animais);
        }

        

        
    }
}