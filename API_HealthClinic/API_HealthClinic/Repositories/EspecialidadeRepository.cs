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
<<<<<<< HEAD
            ctx = new HealthContext();
=======
                ctx = new HealthContext();
>>>>>>> c355ffe71834f8f6e0e5910bab367a2b5a4b1e19
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
<<<<<<< HEAD
            ctx.Especialidade.Remove(especialidade);
=======
            ctx.Especialidade.Remove(especialidade!);
>>>>>>> c355ffe71834f8f6e0e5910bab367a2b5a4b1e19
            ctx.SaveChanges();
        }

        public List<Especialidade> ListarTodos()
        {
            return ctx.Especialidade.ToList();
        }
    }
}
