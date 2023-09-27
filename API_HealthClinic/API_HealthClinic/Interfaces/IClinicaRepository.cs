using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    public interface IClinicaRepository
    {
        void Cadastrar(Clinica clinica);

        List<Clinica> ListarTodos();

        void Atualizar(Guid id, Clinica clinica);

        void Deletar(Guid id);

        Clinica BuscarPorId(Guid id);
    }
}
