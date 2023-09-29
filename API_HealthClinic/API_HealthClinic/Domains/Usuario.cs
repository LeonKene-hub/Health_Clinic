using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    /// <summary>
    /// Domain de usuario, define tabela usuario
    /// </summary>
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        /// <summary>
        /// Identificador unico de usuario
        /// </summary>
        [Key]
        public Guid IdUsuario { get; set; }

        /// <summary>
        /// Email do usuario
        /// </summary>
        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "Email obrigatorio!")]
        public string? Email { get; set; }

        /// <summary>
        /// Senha do usuario
        /// </summary>
        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "Senha obrigatoria!")]
        public string? Senha { get; set; }

        /// <summary>
        /// Nome do usuario
        /// </summary>
        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "Nome obrigatorio!")]
        public string? Nome { get; set; }

        /// <summary>
        /// Identificador unico de tipoUsuario
        /// </summary>
        //referencia a tabela tipoUsuario
        [Required(ErrorMessage = "Informe o tipo do usuario!")]
        public Guid IdTipoUsuario { get; set; }

        /// <summary>
        /// Referencia a tabela de tipoUsuario
        /// </summary>
        [ForeignKey(nameof(IdTipoUsuario))]
        public TiposUsuario? TiposUsuario { get; set; }
    }
}
