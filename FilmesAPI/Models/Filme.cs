using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get;  set; }


        [Range(1, 600, ErrorMessage ="A duração deve possuir um intervalor de 1 a 600 minutos.")]

        public int Duracao { get; set; }


        [Required(ErrorMessage = "O campo Título é obrigatório.")]

        public string Titulo { get; set; }


        [Required(ErrorMessage = "O campo Diretor é obrigatório.")]

        public string Diretor { get; set; }


        [StringLength(35,ErrorMessage = "O gênero não deve passar de 35 caracteres.")]

        public string Genero { get; set; }

       

        


        
    }
}

