using System;
using System.ComponentModel.DataAnnotations;

namespace test1.Models
{  //No se que cosas son necesarias aca corte required ? pq tiene que poder seleccionar si debito autom o credito visa
    public class MetodoPago
    {
        [Key]
        public int Id { get; set; }

        public int? TipoPagoId { get; set; }

        public int? TipoDocumentoId { get; set; }

        public string NroDoc { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NroTarjeta { get; set; }

        public DateTime? FechaVencimiento { get; set; }

        public int? TipoCuentaId { get; set; }

        public string Cbu { get; set; }

        public string Banco { get; set; }

        public string Sucursal { get; set; }

        public int? CodExpensa { get; set; }

        public string Barrio { get; set; }

        public int? Lote { get; set; }

        // Relaciones
        public TipoDocumento TipoDocumento { get; set; }

        public TipoCuentaBancaria TipoCuentaBancaria { get; set; }

        public TipoPago TipoPago { get; set; }
    }
}
