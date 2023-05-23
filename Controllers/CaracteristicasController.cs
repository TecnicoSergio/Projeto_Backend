using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Models.Enuns;
using RpgApi.Models;




namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaracteristicasController : ControllerBase
    {
        private Caracteristica c = new Caracteristica();
        private static List<Caracteristica> caracteristicas = new List<Caracteristica> {
            new Caracteristica(),
            new Caracteristica { Id = 1, Etinia = "Negro", Idade = 45, Altura = 1.58, Peso = 58, Estatura = "Media"},
            new Caracteristica { Id = 2, Etinia = "Pardo", Idade = 22, Altura = 1.89, Peso = 88, Estatura = "Grande"},
            new Caracteristica { Id = 3, Etinia = "Amarelo", Idade = 30, Altura = 1.78, Peso = 98, Estatura = "Pequena"},
            new Caracteristica { Id = 4, Etinia = "Branco", Idade = 12, Altura = 1.22, Peso = 100, Estatura = "Media"},
            new Caracteristica { Id = 5, Etinia = "Africano", Idade = 45, Altura = 1.60, Peso = 115, Estatura = "Pequena"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(caracteristicas);
        }



        
    }
}