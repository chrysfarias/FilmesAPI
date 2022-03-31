using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class FilmeController : ControllerBase
    {
        private static list<Filme> filmes = new List<Filme>();
        public void AdicionaFilme(Filme filme)
        {
            
        }
    }
}

