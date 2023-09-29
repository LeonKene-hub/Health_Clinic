using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    /// <summary>
    /// Domain de Paciente, define tabela Paciente
    /// </summary>
    [Table(nameof(Paciente))]
    [Index(nameof(CPF), IsUnique = true)]
    public class Paciente
    {
        /// <summary>
        /// Identificador unico de Paciente
        /// </summary>
        [Key]
        public Guid IdPaciente { get; set; }

        /// <summary>
        /// Data de nascimento do paciente
        /// </summary>
        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de nascimento obrigatorio!")]
        public DateTime DataNascimento { get; set;}

        /// <summary>
        /// Genero do paciente
        /// </summary>
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Genero obrigatorio!")]
        public string? Genero { get; set; }

        /// <summary>
        /// Telefone do paciente
        /// </summary>
        [Column(TypeName = "VARCHAR(13)")]
        [Required(ErrorMessage = "Numero de telefone obrigatorio!")]
        public string? Telefone { get; set; }

        /// <summary>
        /// Endereco do paciente
        /// </summary>
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Endereco obrigatorio!")]
        public string? Endereco { get; set;}

        /// <summary>
        /// CPF do paciente
        /// </summary>
        [Column(TypeName = "VARCHAR(11)")]
        [Required(ErrorMessage = "CPF obrigatorio!")]
        public string? CPF { get; set; }

        /// <summary>
        /// Identificador unico de Usuario
        /// </summary>
        //referencia a tabela usuairo
        [Required(ErrorMessage = "Informe o usuario!")]
        public Guid IdUsuario { get; set; }

        /// <summary>
        /// referencia a tabela de Usuario
        /// </summary>
        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set;}
    }
}
