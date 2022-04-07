using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmesAPI.Models;





namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        public static int id = 1;


        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
        }

        [HttpGet]
        public IActionResult RecuperaFilme()
        {
            return Ok(filmes);
        }

        [HttpGet("{id}")]

        public IActionResult RecuperaFilmePorId(int id)
        {
          Filme filme = filmes.FirstOrDefault(filme => filme.Id == id );
            if(filme != null)
            {
                return Ok(filme);            
            }
            return NotFound();
        }
    }
}

