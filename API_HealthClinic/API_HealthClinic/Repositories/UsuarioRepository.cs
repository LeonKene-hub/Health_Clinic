using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;
using API_HealthClinic.Utils;

namespace API_HealthClinic.Repositories
{
    /// <summary>
    /// Repositorio de usuario
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthContext ctx;

        /// <summary>
        /// Construtor de usuario
        /// </summary>
        public UsuarioRepository()
        {
            ctx = new HealthContext();
        }

        /// <summary>
        /// Metodo de atualizar usuario
        /// </summary>
        /// <param name="id">id do usuario</param>
        /// <param name="usuario">novas informacoes</param>
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

        /// <summary>
        /// Metodo de cadastrar usuario
        /// </summary>
        /// <param name="usuario">Informacoes do novo usuario</param>
        public void Cadastrar(Usuario usuario)
        {
            usuario.IdUsuario = Guid.NewGuid();
            usuario.Senha = Criptografia.GerarHash(usuario.Senha!);
            ctx.Usuario.Add(usuario);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de deletar usuario
        /// </summary>
        /// <param name="id">id do usuario</param>
        public void Delete(Guid id)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id)!;
            ctx.Usuario.Remove(usuarioBuscado);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de listar usuarios
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        public List<Usuario> ListarTodos()
        {
            return ctx.Usuario.ToList();
        }

        /// <summary>
        /// Metodo de login do usuario, validacao
        /// </summary>
        /// <param name="email">Email do usuario</param>
        /// <param name="senha">Senha do usuario</param>
        /// <returns></returns>
        public Usuario Login(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = ctx.Usuario.Select(u => new Usuario
                {
                    IdUsuario = u.IdUsuario,
                    Email = u.Email,
                    Senha = u.Senha,
                    Nome = u.Nome,
                    TiposUsuario = new TiposUsuario
                    { 
                        IdTipoUsuario= u.IdTipoUsuario,
                        TituloTipoUsuario = u.TiposUsuario.TituloTipoUsuario
                    }
                }).FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }

                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
