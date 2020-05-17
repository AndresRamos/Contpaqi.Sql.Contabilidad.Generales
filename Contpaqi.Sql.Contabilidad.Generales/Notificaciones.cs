using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Generales
{
    public class Notificaciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(36)]
        public string Llave { get; set; }

        [Required]
        [StringLength(20)]
        public string Usuario { get; set; }

        public int? Tipo { get; set; }

        [StringLength(1000)]
        public string Mensaje { get; set; }

        [StringLength(1000)]
        public string MensajeEnIngles { get; set; }

        public int? TipoMensaje { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaNotificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Empresa { get; set; }
    }
}