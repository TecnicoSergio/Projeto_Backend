using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enuns;



namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArmasController : ControllerBase
    {
        private Arma a =new Arma();
        private static List<Arma> armas = new List<Arma> {
            new Arma(),
            new Arma { Id = 1, Nome = "Ponto Quarenta de MENTIRA"},
            new Arma { Id = 2, Nome = "Espingarda Calibri 12"},
            new Arma { Id = 3, Nome = "765"},
            new Arma { Id = 4, Nome = "Fuzil"},
            new Arma { Id = 5, Nome = " Calibri 38"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(armas);
        }

        public IActionResult GetSingle()
        {
            return Ok(armas[0]);
        }

        [HttpPost]
        public IActionResult AddArma(Arma novaArma)
        {
            armas.Add(novaArma);
            return Ok(armas);
        }

         /*[HttpGet("GetRemovendoMago")]
        public IActionResult GetRemovendoMagos()
        {
            Arma aRemove = armas.Find(a => a.Classe == ClasseEnum.Mago);
            armas.Remove(aRemove);
            return Ok("Personagem removido: " + aRemove.Nome);

        }*/


        
    }
}