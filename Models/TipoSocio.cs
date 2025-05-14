using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class TipoSocio
    {
        [Key]
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public int Monto { get; set; }

        public bool EsVecino { get; set; }
    }
}
