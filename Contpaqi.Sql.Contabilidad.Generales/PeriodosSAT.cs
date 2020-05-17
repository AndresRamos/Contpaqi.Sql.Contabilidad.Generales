using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Generales
{
    [Table("PeriodosSAT")]
    public class PeriodosSAT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(2)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public int? MesInicial { get; set; }

        public int? MesFinal { get; set; }

        [Required]
        [StringLength(2)]
        public string Periodicidad { get; set; }
    }
}