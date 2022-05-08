using Microsoft.EntityFrameworkCore;
using FilmesAPI.Models;



namespace FilmesAPI.Data
{
    public class FilmeContext : DbContext 
    {


        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {

        }
       
        // obj a ser mapeado e acessado dentro do banco de dados
        public DbSet<Filme> Filmes { get; set; }  
    }
}
