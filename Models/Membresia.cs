using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class Membresia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SocioId { get; set; }  

        public int? SocioReferenteId { get; set; }

        public int TipoRelacionId { get; set; }

        public int TipoSocioId { get; set; }

        // Relaciones
        public Socio Socio { get; set; }

        public Socio SocioReferente { get; set; }

        public TipoRelacion TipoRelacion { get; set; }

        public TipoSocio TipoSocio { get; set; }
    }
}
