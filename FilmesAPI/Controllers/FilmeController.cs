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
        private static List<Filme> filmes = new List<Filme>(); // criando lista

        [HttpPost]
        public void AdicionaFilme([FromBody]Filme filme)
        {
            filmes.Add(filme);
            Console.WriteLine("filme add");
        }
    }
}

