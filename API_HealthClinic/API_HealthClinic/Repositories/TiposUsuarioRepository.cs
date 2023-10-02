using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    /// <summary>
    /// Repositorio de tiposUsuario
    /// </summary>
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly HealthContext ctx;

        /// <summary>
        /// Construtor de tiposUsuario
        /// </summary>
        public TiposUsuarioRepository()
        {
            ctx = new HealthContext();
        }

        /// <summary>
        /// Metodo de cadastrar tiposUsuario
        /// </summary>
        /// <param name="tiposUsuario">Informacoes do novo tiposUsuario</param>
        public void Cadastrar(TiposUsuario tiposUsuario)
        {
            tiposUsuario.IdTipoUsuario = Guid.NewGuid();
            ctx.TiposUsuarios.Add(tiposUsuario);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de deletar tiposUsuario
        /// </summary>
        /// <param name="id">id da tiposUsuario</param>
        public void Deletar(Guid id)
        {
            TiposUsuario tipo = ctx.TiposUsuarios.Find(id)!;
            ctx.TiposUsuarios.Remove(tipo);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de listar tiposUsuario
        /// </summary>
        /// <returns>Lista de tiposUsuario</returns>
        public List<TiposUsuario> ListarTodos()
        {
            return ctx.TiposUsuarios.ToList();
        }
    }
}
