using System.ComponentModel.DataAnnotations;


namespace test1.Models
{
    public class Tutor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Edad { get; set; }

        // Relación de uno a uno: cada contacto puede tener un tutor
        public int? TutorId { get; set; }
        public Tutor Tutor { get; set; }

        public bool EsMenorDeEdad => Edad < 18;
    }
}
