using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "Email obrigatorio!")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "Senha obrigatoria!")]
        public string? Senha { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "Nome obrigatorio!")]
        public string? Nome { get; set; }

        //referencia a tabela tipoUsuario
        [Required(ErrorMessage = "Informe o tipo do usuario!")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TiposUsuario? TiposUsuario { get; set; }
    }
}
