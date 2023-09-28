using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext ctx;

        public ConsultaRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Consulta consulta)
        {
            Consulta consultaBuscada = ctx.Consulta.Find(id)!;

            if (consultaBuscada != null)
            {
                consultaBuscada.Hora = consulta.Hora;
                consultaBuscada.Local = consulta.Local;
                consultaBuscada.Status = consulta.Status;
                consultaBuscada.Descricao = consulta.Descricao;
            }

            ctx.Update(consultaBuscada);
            ctx.SaveChanges();
        }

        public void Cadastrar(Consulta consulta)
        {
            consulta.IdConsulta = Guid.NewGuid();
            ctx.Consulta.Add(consulta);
            ctx.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Consulta consultaBuscada = ctx.Consulta.Find(id)!;
            ctx.Consulta.Remove(consultaBuscada);
            ctx.SaveChanges();
        }

        public List<Consulta> ListarPorMedico(Guid id)
        {
            List<Consulta> lista = new List<Consulta>();

            foreach (var consulta in ctx.Consulta)
            {
                if (consulta.IdMedico == id)
                {
                    lista.Add(consulta);
                }
            }

            return lista;
        }

        public List<Consulta> ListarPorPaciente(Guid id)
        {
            List<Consulta> lista = new List<Consulta>();

            foreach (var consulta in ctx.Consulta)
            {
                if (consulta.IdPaciente == id)
                {
                    lista.Add(consulta);
                }
            }

            return lista;
        }

        public List<Consulta> ListarTodos()
        {
            return ctx.Consulta.ToList();
        }
    }
}
