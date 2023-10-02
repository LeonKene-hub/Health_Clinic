using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    /// <summary>
    /// Repositorio de medico
    /// </summary>
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthContext ctx;

        /// <summary>
        /// Construtor de medico
        /// </summary>
        public MedicoRepository()
        {
            ctx = new HealthContext();
        }

        /// <summary>
        /// Metodo de atualizar medico
        /// </summary>
        /// <param name="id">id da medico</param>
        /// <param name="medico">novas informacoes</param>
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

        /// <summary>
        /// Metodo de buscar por id do medico
        /// </summary>
        /// <param name="id">id da medico</param>
        /// <returns>medico encontrado</returns>
        public Medico BuscarPorId(Guid id)
        {
            Medico medico = ctx.Medico.Find(id)!;

            if (medico != null)
            {
                return medico;
            }
            return null!;
        }

        /// <summary>
        /// Metodo de cadastrar medico
        /// </summary>
        /// <param name="medico">Informacoes da novo medico</param>
        public void Cadastrar(Medico medico)
        {
            medico.IdMedico = Guid.NewGuid();
            ctx.Medico.Add(medico);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de deletar medico
        /// </summary>
        /// <param name="id">id do medico</param>
        public void Deletar(Guid id)
        {
            Medico medico = ctx.Medico.Find(id)!;
            ctx.Medico.Remove(medico);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de listar medicos
        /// </summary>
        /// <returns>Lista de medicos</returns>
        public List<Medico> ListarTodos()
        {
            return ctx.Medico.ToList();
        }
    }
}
