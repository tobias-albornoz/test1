using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class TipoPago
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
