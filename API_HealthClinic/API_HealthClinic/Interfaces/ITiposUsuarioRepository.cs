using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    public interface ITiposUsuarioRepository
    {
        void Cadastrar(TiposUsuario tiposUsuario);

        List<TiposUsuario> ListarTodos();

        void Deletar(Guid id);
    }
}
