using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consulta);

        List<Consulta> ListarTodos();

        void Atualizar(Guid id, Consulta consulta);

        void Delete(Guid id);

        List<Consulta> ListarPorPaciente(Guid id);

        List<Consulta> ListarPorMedico(Guid id);
    }
}
