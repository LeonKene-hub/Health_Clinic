using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        [Key]
        public Guid IdConsulta { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Local da consulta obrigatorio!")]
        public string? Local { get; set; }

        [Column(TypeName = "SMALLDATETIME")]
        [Required(ErrorMessage = "Horario da consulta obrigatorio!")]
        public DateTime? Hora { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descricao da consulta obrigatorio!")]
        public string? Descricao { get; set; }

        //referencia a tabela paciente
        [Required(ErrorMessage = "Identificacao do paciente obrigatorio!")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? paciente { get; set; }

        //referencia a tabela medico
        [Required(ErrorMessage = "Identificacao do medico obrigatorio!")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? medico { get; set; }
    }
}
