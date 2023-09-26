using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    [Table(nameof(Clinica))]
    [Index(nameof(CNPJ), IsUnique = true)]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Razao social obrigatoria!")]
        public string? RazaoSocial { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome fantasia obrigatorio!")]
        public string? NomeFantasia { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Endereco obrigatorio!")]
        public string? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "CNPJ obrigatorio!")]
        public string? CNPJ { get;set; }

        [Column(TypeName = "SMALLDATETIME")]
        [Required(ErrorMessage = "Horario de abertura obrigatoria!")]
        public DateTime HorarioAbertura { get; set; }

        [Column(TypeName = "SMALLDATETIME")]
        [Required(ErrorMessage = "Horario de fechamento obrigatoria!")]
        public DateTime HorarioFechamento { get; set; }
    }
}
