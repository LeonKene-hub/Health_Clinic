using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    /// <summary>
    /// Domain de clinica, define tabela clinica
    /// </summary>
    [Table(nameof(Clinica))]
    [Index(nameof(CNPJ), IsUnique = true)]
    public class Clinica
    {
        /// <summary>
        /// Identificador unico de clinica
        /// </summary>
        [Key]
        public Guid IdClinica { get; set; }

        /// <summary>
        /// Nome oficial da clinica
        /// </summary>
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Razao social obrigatoria!")]
        public string? RazaoSocial { get; set; }

        /// <summary>
        /// Nome popular da clinica
        /// </summary>
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome fantasia obrigatorio!")]
        public string? NomeFantasia { get; set; }

        /// <summary>
        /// Endereco da unidade
        /// </summary>
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Endereco obrigatorio!")]
        public string? Endereco { get; set; }

        /// <summary>
        /// Codigo de identificacao da empresa
        /// </summary>
        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "CNPJ obrigatorio!")]
        public string? CNPJ { get;set; }

        /// <summary>
        /// Horario de abertura da clinica
        /// </summary>
        [Column(TypeName = "SMALLDATETIME")]
        [Required(ErrorMessage = "Horario de abertura obrigatoria!")]
        public DateTime HorarioAbertura { get; set; }

        /// <summary>
        /// Horario de fechamento da clinica
        /// </summary>
        [Column(TypeName = "SMALLDATETIME")]
        [Required(ErrorMessage = "Horario de fechamento obrigatoria!")]
        public DateTime HorarioFechamento { get; set; }
    }
}
