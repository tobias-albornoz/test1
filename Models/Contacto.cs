using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class Contacto
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Edad { get; set; }
    }
}
