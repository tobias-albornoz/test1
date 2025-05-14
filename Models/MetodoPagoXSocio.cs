using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class MetodoPagoXSocio
    {
        [Key]
        public int Id { get; set; }

        public int? MetodoId { get; set; }

        public int? SocioId { get; set; }

        public MetodoPago MetodoPago { get; set; }

        public Socio Socio { get; set; }
    }

}