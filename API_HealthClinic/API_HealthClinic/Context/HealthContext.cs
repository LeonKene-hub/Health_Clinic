using API_HealthClinic.Domains;
using Microsoft.EntityFrameworkCore;

namespace API_HealthClinic.Context
{
    public class HealthContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuarios { get; set; }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Comentario> Comentario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= NOTE20-S15; Database= Health_Clinic; user id= sa; pwd= Senai@134; TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
