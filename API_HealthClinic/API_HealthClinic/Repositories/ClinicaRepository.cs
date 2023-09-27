using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthContext ctx;

        public ClinicaRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Clinica clinica)
        {
            Clinica clinicaBuscada = ctx.Clinicas.Find(id)!;

            if (clinicaBuscada != null)
            {
                clinicaBuscada.RazaoSocial = clinica.RazaoSocial;
                clinicaBuscada.NomeFantasia = clinica.NomeFantasia;
                clinicaBuscada.CNPJ= clinica.CNPJ;
                clinicaBuscada.Endereco= clinica.Endereco;
                clinicaBuscada.HorarioAbertura = clinica.HorarioAbertura;
                clinicaBuscada.HorarioFechamento = clinica.HorarioFechamento;
            }
            ctx.Update(clinicaBuscada);
            ctx.SaveChanges();
        }

        public Clinica BuscarPorId(Guid id)
        {
            Clinica clinica = ctx.Clinicas.Find(id)!;

            if (clinica != null)
            {
                return clinica;
            }
            return null!;
        }

        public void Cadastrar(Clinica clinica)
        {
            clinica.IdClinica = Guid.NewGuid();
            ctx.Clinicas.Add(clinica);
            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Clinica clinica = ctx.Clinicas.Find(id)!;
            ctx.Clinicas.Remove(clinica);
            ctx.SaveChanges();
        }

        public List<Clinica> ListarTodos()
        {
            return ctx.Clinicas.ToList();
        }
    }
}
