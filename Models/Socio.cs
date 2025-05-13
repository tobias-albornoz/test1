using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class Socio
    {
        [Key]
        public int Id { get; set; }

        public DateTime? FechaAlta { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [EmailAddress]
        public string Mail { get; set; }

        [Required]
        public string CodAreaTelefono { get; set; }

        [Required]
        public string NroTelefono { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public int TipoDocumentoId { get; set; }

        [Required]
        public string NroDoc { get; set; }

        [Required]
        public int ArchivosId { get; set; }

        [Required]
        public int ContactoEmergenciaId { get; set; }

        [Required]
        public int TipoPagoId { get; set; }


        // Relaciones
        public TipoDocumento TipoDocumento { get; set; }
        public Archivos Archivos { get; set; }
        public ContactoEmergencia ContactoEmergencia { get; set; }
        public TipoPago TipoPago { get; set; }

        public ICollection<Membresia> Membresias { get; set; }
    }
}
