using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class Actividad
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int? Monto { get; set; }

        public ICollection<SocioActividad> SocioActividades { get; set; }
    }
}
