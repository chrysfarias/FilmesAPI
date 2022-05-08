using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmesAPI.Models;
using FilmesAPI.Data;
using FilmesAPI.Data.DTOs;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;
        public FilmeController(FilmeContext context)
        {
            _context = context;
        }
       

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
        {
            Filme filme = new Filme
            {
                Diretor = filmeDto.Diretor,
                Duracao = filmeDto.Duracao,
                Titulo = filmeDto.Titulo,
                Genero = filmeDto.Genero     
            };


            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFilmesPorId), new { Id = filme.Id }, filme);
        }

       
        [HttpGet]

        public IActionResult RecuperaFilmes()
        {
            return Ok(_context.Filmes);
        }


        [HttpGet("{id}")]

        public IActionResult RecuperaFilmesPorId(int id)
        {
          Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id );
            if(filme != null)
            {
                return Ok(filme);            
            }
            return NotFound();
        }


        [HttpPut("{id}")]

        public IActionResult AtualizaFilme(int id, [FromBody] Filme filmeNovo)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id );
            if (filme == null)
            {
                return NotFound();
            }
            filme.Titulo= filmeNovo.Titulo;
            filme.Genero= filmeNovo.Genero;
            filme.Duracao= filmeNovo.Duracao;
            filme.Diretor   = filmeNovo.Diretor;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]

        public IActionResult DeletaFilme(int id)
        {
             Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id );
            if (filme == null)
            {
                return NotFound();
            }
            _context.Remove(filme);
            return NoContent();
        
        }
    }
}

