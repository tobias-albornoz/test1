using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class SocioTutor
    { //chequear que cosas son no null
        [Key]
        public int Id { get; set; }

        public int? SocioId { get; set; }

        public int? TutorId { get; set; }

        public Socio Socio { get; set; }

        public Tutor Tutor { get; set; }
    }
}
