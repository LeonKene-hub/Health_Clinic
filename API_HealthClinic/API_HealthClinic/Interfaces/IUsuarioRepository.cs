using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        List<Usuario> ListarTodos();

        void Atualizar(Guid id, Usuario usuario);

        void Delete(Guid id);

        Usuario Login(string email, string senha);
    }
}
