using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
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

          private readonly DataContext _context;

        public ArmasController(DataContext context)
        {
            _context = context;
        }


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
        public async Task<IActionResult> Add(Arma novaArma)
        {
            try
            {
                if (novaArma.Dano == 0)
                    throw new System.Exception("O dano da armwa não pode ser 0");

                Personagem p = await _context.Personagens
                .FirstOrDefaultAsync(p => p.Id == novaArma.PersonagemId);

                if(p == null)
                throw new System.Exception("Não existe personagem com o Id INFORMADO. ");

                await _context.Armas.AddAsync(novaArma);
                await _context.SaveChangesAsync();
                return Ok(novaArma.Id);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
            
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