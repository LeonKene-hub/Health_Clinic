using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    /// <summary>
    /// Domain de especialidade, define tabela especialidade
    /// </summary>
    [Table(nameof(Especialidade))]
    [Index(nameof(Nome))]
    public class Especialidade
    {
        /// <summary>
        /// Identificador unico de especialidade
        /// </summary>
        [Key]
        public Guid IdEspecialidade { get; set; }

        /// <summary>
        /// Nome da especialidade
        /// </summary>
        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "Nome da especialidade obrigatorio!")]
        public string? Nome { get; set; }
    }
}
