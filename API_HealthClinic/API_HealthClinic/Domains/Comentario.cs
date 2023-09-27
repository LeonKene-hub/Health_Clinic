using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    [Table(nameof(Comentario))]
    public class Comentario
    {
        [Key]
        public Guid IdComentario { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Comentario obrigatorio!")]
        public string? ComentarioConsulta { get; set; }

        [Column(TypeName = "BIT")]
        //[DefaultValue(0)]
        [DefaultValue("false")]
        public bool Permissao { get; set; }

        //referencia a tabela paciente
        public Guid IdPaciente { get; set; }
        public Paciente? paciente { get; set; }
    }
}
