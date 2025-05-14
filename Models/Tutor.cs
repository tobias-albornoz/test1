using System.ComponentModel.DataAnnotations;
using System;

namespace test1.Models
{
    public class Tutor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public DateTime? FechaNac { get; set; }

        [Required]
        public int? TipoDocumentoId { get; set; }

        [Required]
        public string NroDoc { get; set; }

        [Required,EmailAddress]
        public string Mail { get; set; }

        [Required]
        public string CodAreaTelefono { get; set; }

        [Required]
        public string NroTelefono { get; set; }

        // Relaciones
        public TipoDocumento TipoDocumento { get; set; }
    }
}
