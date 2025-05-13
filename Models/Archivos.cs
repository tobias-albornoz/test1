using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class Archivos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AptoFisico { get; set; }

        [Required]
        public string DocFrente { get; set; }

        [Required]
        public string DocDorso { get; set; }

    }
}
