using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);

        List<Especialidade> ListarTodos();

        void Deletar(Guid id);
    }
}
