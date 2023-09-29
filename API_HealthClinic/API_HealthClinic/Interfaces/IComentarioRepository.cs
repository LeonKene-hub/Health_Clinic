using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);

        List<Comentario> ListarTodos();

        void Atualizar(Guid id, Comentario comentario);

        void Deletar(Guid id);
    }
}
