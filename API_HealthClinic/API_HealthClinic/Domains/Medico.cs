using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    /// <summary>
    /// Domain de medico, define tabela medico
    /// </summary>
    [Table(nameof(Medico))]
    [Index(nameof(CRM), IsUnique = true)]
    public class Medico
    {
        /// <summary>
        /// Identificador unico de medico
        /// </summary>
        [Key]
        public Guid IdMedico { get; set; }

        /// <summary>
        /// Codigo do identidade do medico
        /// </summary>
        [Column(TypeName = "VARCHAR(8)")]
        [Required(ErrorMessage = "CRM obrigatorio!")]
        public string? CRM { get; set; }

        /// <summary>
        /// Identificador unico de usuario
        /// </summary>
        //referencia a tabela usuario
        [Required(ErrorMessage = "Identificacao do usuario obrigatoria!")]
        public Guid IdUsuario { get; set; }

        /// <summary>
        ///  Referencia a tabela de usuario
        /// </summary>
        [ForeignKey(nameof(IdUsuario))]
        public Usuario? usuario { get; set; }

        /// <summary>
        /// Identificador unico de clinica
        /// </summary>
        //referencia a tabela clinica
        [Required(ErrorMessage = "Identificacao da clinica obrigatoria!")]
        public Guid IdClinica { get; set; }

        /// <summary>
        ///  Referencia a tabela de clinica
        /// </summary>
        [ForeignKey(nameof(IdClinica))]
        public Clinica? clinica { get; set; }

        /// <summary>
        /// Identificador unico da especialidade
        /// </summary>
        //referencia a tabela
        [Required(ErrorMessage = "Identificacao da especialidade obrigatoria!")]
        public Guid IdEspecialidade { get; set; }

        /// <summary>
        ///  Referencia a tabela de especialidade
        /// </summary>
        [ForeignKey(nameof(IdEspecialidade))]
        public Especialidade? especialidade { get; set; }
    }
}
