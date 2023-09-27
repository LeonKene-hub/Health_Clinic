using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    [Table(nameof(Especialidade))]
    [Index(nameof(Nome))]
    public class Especialidade
    {
        [Key]
        public Guid IdEspecialidade { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "Nome da especialidade obrigatorio!")]
        public string? Nome { get; set; }
    }
}
