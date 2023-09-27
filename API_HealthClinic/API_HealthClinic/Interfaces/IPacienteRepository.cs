using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        List<Paciente> ListarTodos();

        void Atualizar(Guid id, Paciente paciente);

        void Deletar(Guid id);

        Paciente BuscarPorId(Guid id);
    }
}
