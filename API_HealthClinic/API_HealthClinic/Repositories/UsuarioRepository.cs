using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthContext ctx;

        public UsuarioRepository()
<<<<<<< HEAD
=======
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Usuario usuario)
>>>>>>> c355ffe71834f8f6e0e5910bab367a2b5a4b1e19
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Usuario usuario)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id)!;

            if (usuarioBuscado != null)
            {
                usuarioBuscado.IdTipoUsuario = usuario.IdTipoUsuario;
                usuarioBuscado.Email= usuario.Email; 
                usuarioBuscado.Senha= usuario.Senha;
            }
            ctx.Update(usuarioBuscado);
            ctx.SaveChanges();
        }

        public void Cadastrar(Usuario usuario)
        {
            usuario.IdUsuario = Guid.NewGuid();
            ctx.Usuario.Add(usuario);
            ctx.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id)!;
            ctx.Usuario.Remove(usuarioBuscado);
            ctx.SaveChanges();
        }

        public List<Usuario> ListarTodos()
        {
            return ctx.Usuario.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
