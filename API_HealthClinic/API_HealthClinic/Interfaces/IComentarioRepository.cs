using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);

        List<Comentario> ListarTodos();

        void Atualizar(Guid id, Consulta consulta);

        void Deletar(Guid id);
    }
}
