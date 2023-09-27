using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    [Table(nameof(Medico))]
    [Index(nameof(CRM), IsUnique = true)]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; }

        [Column(TypeName = "VARCHAR(8)")]
        [Required(ErrorMessage = "CRM obrigatorio!")]
        public string? CRM { get; set; }

        //referencia a tabela usuario
        [Required(ErrorMessage = "Identificacao do usuario obrigatoria!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? usuario { get; set; }

        //referencia a tabela clinica
        [Required(ErrorMessage = "Identificacao da clinica obrigatoria!")]
        public Guid IdClinica { get; set; }

        [ForeignKey(nameof(IdClinica))]
        public Clinica? clinica { get; set; }

        //referencia a tabela
        [Required(ErrorMessage = "Identificacao da especialidade obrigatoria!")]
        public Guid IdEspecialidade { get; set; }

        [ForeignKey(nameof(IdEspecialidade))]
        public Especialidade? especialidade { get; set; }
    }
}
