using System;
using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class SocioActividad
    {
        [Key]
        public int Id { get; set; }

        public int ActividadId { get; set; }
        [Required] //todos tienen membresia asique nunca va a ser null esto, esta bien ponelo como required?
        public int MembresiaId { get; set; }

        public DateTime? FechaAlta { get; set; }

        public Actividad Actividad { get; set; }

        public Membresia Membresia { get; set; }
    }
}
