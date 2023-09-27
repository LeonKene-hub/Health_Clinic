using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly HealthContext ctx;
        public TiposUsuarioRepository()
        {
            ctx = new HealthContext();
        }

        public void Cadastrar(TiposUsuario tiposUsuario)
        {
            tiposUsuario.IdTipoUsuario = Guid.NewGuid();
            ctx.TiposUsuarios.Add(tiposUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposUsuario tipo = ctx.TiposUsuarios.Find(id)!;
            ctx.TiposUsuarios.Remove(tipo);
            ctx.SaveChanges();
        }

        public List<TiposUsuario> ListarTodos()
        {
            return ctx.TiposUsuarios.ToList();
        }
    }
}
