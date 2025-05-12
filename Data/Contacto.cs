using System.ComponentModel.DataAnnotations;

namespace test1.Data
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El email no es válido.")]
        public string Email { get; set; }

        [Range(1, 120, ErrorMessage = "Edad inválida.")]
        public int Edad { get; set; }
    }
}






