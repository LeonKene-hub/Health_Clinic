using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly HealthContext ctx;

        public EspecialidadeRepository()
        {
            ctx = new HealthContext();
        }

        public void Cadastrar(Especialidade especialidade)
        {
            especialidade.IdEspecialidade = Guid.NewGuid();
            ctx.Especialidade.Add(especialidade);
            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Especialidade especialidade = ctx.Especialidade.Find(id)!;
            ctx.Especialidade.Remove(especialidade);
            ctx.Especialidade.Remove(especialidade!);
            ctx.SaveChanges();
        }

        public List<Especialidade> ListarTodos()
        {
            return ctx.Especialidade.ToList();
        }
    }
}
