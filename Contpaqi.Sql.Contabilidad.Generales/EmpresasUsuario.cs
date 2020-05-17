using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Generales
{
    [Table("EmpresasUsuario")]
    public class EmpresasUsuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdUsuario { get; set; }

        public int IdEmpresa { get; set; }
    }
}