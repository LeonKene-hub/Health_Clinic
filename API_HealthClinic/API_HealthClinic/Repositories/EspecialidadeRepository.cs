using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    /// <summary>
    /// Repositorio de especialidade
    /// </summary>
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly HealthContext ctx;

        /// <summary>
        /// Construtor de especialidade
        /// </summary>
        public EspecialidadeRepository()
        {
            ctx = new HealthContext();
        }

        /// <summary>
        /// Metodo de cadastrar especialidade
        /// </summary>
        /// <param name="especialidade">Informacoes da nova especialidade</param>
        public void Cadastrar(Especialidade especialidade)
        {
            especialidade.IdEspecialidade = Guid.NewGuid();
            ctx.Especialidade.Add(especialidade);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de deletar especialidade
        /// </summary>
        /// <param name="id">id da especialidade</param>
        public void Deletar(Guid id)
        {
            Especialidade especialidade = ctx.Especialidade.Find(id)!;
            ctx.Especialidade.Remove(especialidade);
            ctx.Especialidade.Remove(especialidade!);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de listar especialidades
        /// </summary>
        /// <returns>Lista de especialidades</returns>
        public List<Especialidade> ListarTodos()
        {
            return ctx.Especialidade.ToList();
        }
    }
}
