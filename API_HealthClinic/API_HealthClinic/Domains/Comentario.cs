using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    /// <summary>
    /// Domain de comentario, define tabela comentario
    /// </summary>
    [Table(nameof(Comentario))]
    public class Comentario
    {
        /// <summary>
        /// Identificador unico de comentario
        /// </summary>
        [Key]
        public Guid IdComentario { get; set; }

        /// <summary>
        /// Texto do comentario feito
        /// </summary>
        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Comentario obrigatorio!")]
        public string? ComentarioConsulta { get; set; }

        /// <summary>
        /// Status que define se o comentario sera exibido ao publico geral
        /// </summary>
        [Column(TypeName = "BIT")]
        //[DefaultValue(0)]
        [DefaultValue("false")]
        public bool Permissao { get; set; }

        /// <summary>
        /// Identificador do usuario que realizou o comentario
        /// </summary>
        //referencia a tabela paciente
        public Guid IdPaciente { get; set; }
        /// <summary>
        /// Referencia a tabela de paciente
        /// </summary>
        public Paciente? paciente { get; set; }
    }
}
