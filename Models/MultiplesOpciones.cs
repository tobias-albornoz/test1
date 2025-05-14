using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    public class MultiplesOpciones
    {
        public class TipoDocumento
        {  //Esta bien asi?
            [Key]
            public int Id { get; set; }
            public string Descripcion { get; set; }
        }

        public class TipoRelacion
        {
            [Key]
            public int Id { get; set; }
            public string Descripcion { get; set; }
        }

        public class TipoCuentaBancaria
        {
            [Key]
            public int Id { get; set; }
            public string Descripcion { get; set; }
        }

        public class TipoPago
        {
            [Key]
            public int Id { get; set; }
            public string Descripcion { get; set; }
        }
    }
}
