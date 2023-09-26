using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_HealthClinic.Domains
{
    [Table(nameof(Paciente))]
    [Index(nameof(CPF), IsUnique = true)]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de nascimento obrigatorio!")]
        public DateTime DataNascimento { get; set;}

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Genero obrigatorio!")]
        public string? Genero { get; set; }

        [Column(TypeName = "VARCHAR(13)")]
        [Required(ErrorMessage = "Numero de telefone obrigatorio!")]
        public string? Telefone { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Endereco obrigatorio!")]
        public string? Endereco { get; set;}

        [Column(TypeName = "VARCHAR(11)")]
        [Required(ErrorMessage = "CPF obrigatorio!")]
        public string? CPF { get; set; }

        //referencia a tabela usuairo
        [Required(ErrorMessage = "Informe o usuario!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set;}
    }
}
