using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Generales
{
    [Table("PermisosUsuario")]
    public class PermisosUsuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdUsuario { get; set; }

        public int IdProceso { get; set; }

        public int Permisos { get; set; }

        public int? Uso { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}