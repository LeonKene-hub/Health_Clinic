using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        List<Medico> ListarTodos();

        void Atualizar(Guid id, Medico medico);

        void Deletar(Guid id);

        Medico BuscarPorId(Guid id);
    }
}
