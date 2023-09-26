using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    [Table(nameof(Especialidade))]
    public class Especialidade
    {
        public Guid IdEspecialidade { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "Nome da especialidade obrigatorio!")]
        public string? Nome { get; set; }
    }
}
