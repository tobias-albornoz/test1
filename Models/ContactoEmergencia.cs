using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class ContactoEmergencia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }
        
        [Required, EmailAddress]
        public string Mail { get; set; }

        [Required]
        public string CodAreaTelefono { get; set; }
        
        [Required]
        public string NroTelefono { get; set; }
    }
}
