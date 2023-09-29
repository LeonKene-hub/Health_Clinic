using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    /// <summary>
    /// Domain de medico, define tabela medico
    /// </summary>
    [Table(nameof(TiposUsuario))]
    [Index(nameof(TituloTipoUsuario), IsUnique = true)]
    public class TiposUsuario
    {
        /// <summary>
        /// Identificador unico de tiposUsuario
        /// </summary>
        [Key]
        public Guid IdTipoUsuario { get; set; }

        /// <summary>
        /// Nome/Titulo do tipo de usuario
        /// </summary>
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Tipo de usuario necessario")]
        public string? TituloTipoUsuario { get; set; }
    }
}
