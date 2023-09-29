using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    /// <summary>
    /// Domain de consulta, define tabela consulta
    /// </summary>
    [Table(nameof(Consulta))]
    public class Consulta
    {
        /// <summary>
        /// Identificador unico de consulta
        /// </summary>
        [Key]
        public Guid IdConsulta { get; set; }

        /// <summary>
        /// Endereco e local a qual a consulta foi agendada
        /// </summary>
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Local da consulta obrigatorio!")]
        public string? Local { get; set; }

        /// <summary>
        /// Horario marcado para a consulta
        /// </summary>
        [Column(TypeName = "SMALLDATETIME")]
        [Required(ErrorMessage = "Horario da consulta obrigatorio!")]
        public DateTime? Hora { get; set; }

        /// <summary>
        /// Descricao da consulta a ser realizada
        /// </summary>
        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descricao da consulta obrigatorio!")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Status que exibe se a consulta esta ativa ou cancelada
        /// </summary>
        [Column(TypeName = "BIT")]
        [DefaultValue("false")]
        [Required(ErrorMessage = "Consulta confirmada?")]
        public bool Status { get; set; }

        /// <summary>
        /// Identificador unico de paciente
        /// </summary>
        //referencia a tabela paciente
        [Required(ErrorMessage = "Identificacao do paciente obrigatorio!")]
        public Guid IdPaciente { get; set; }

        /// <summary>
        /// Referencia a tabela de paciente
        /// </summary>
        [ForeignKey(nameof(IdPaciente))]
        public Paciente? paciente { get; set; }

        /// <summary>
        /// Identificador unico de medico
        /// </summary>
        //referencia a tabela medico
        [Required(ErrorMessage = "Identificacao do medico obrigatorio!")]
        public Guid IdMedico { get; set; }

        /// <summary>
        /// Referencia a tabela de medico
        /// </summary>
        [ForeignKey(nameof(IdMedico))]
        public Medico? medico { get; set; }
    }
}
