using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthContext ctx;

        public MedicoRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Medico medico)
        {
            Medico medicoBuscado = ctx.Medico.Find(id)!;

            if (medicoBuscado != null)
            {
                medicoBuscado.IdClinica = medico.IdClinica;
                medicoBuscado.IdEspecialidade = medico.IdEspecialidade;
                medicoBuscado.CRM = medico.CRM;
            }
            ctx.Update(medicoBuscado);
            ctx.SaveChanges();
        }

        public Medico BuscarPorId(Guid id)
        {
            Medico medico = ctx.Medico.Find(id)!;

            if (medico != null)
            {
                return medico;
            }
            return null!;
        }

        public void Cadastrar(Medico medico)
        {
            medico.IdMedico = Guid.NewGuid();
            ctx.Medico.Add(medico);
            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Medico medico = ctx.Medico.Find(id)!;
            ctx.Medico.Remove(medico);
            ctx.SaveChanges();
        }

        public List<Medico> ListarTodos()
        {
            return ctx.Medico.ToList();
        }
    }
}
