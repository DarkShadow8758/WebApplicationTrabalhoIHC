using System.ComponentModel.DataAnnotations;

namespace WebApplicationTrabalhoIHC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }
        public string NomePai { get; set; }

    }
}
