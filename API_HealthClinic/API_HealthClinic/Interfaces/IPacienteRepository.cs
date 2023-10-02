using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    /// <summary>
    /// Interface de paciente
    /// </summary>
    public interface IPacienteRepository
    {
        /// <summary>
        /// Realiza o cadastro de paciente
        /// </summary>
        /// <param name="paciente">Novo paciente</param>
        void Cadastrar(Paciente paciente);

        /// <summary>
        /// Lista todos os pacientes presentes no banco de dados
        /// </summary>
        /// <returns>Lista de pacientes</returns>
        List<Paciente> ListarTodos();

        /// <summary>
        /// Atualiza um paciente no banco de dados
        /// </summary>
        /// <param name="id">Id do paciente a ser atualizado</param>
        /// <param name="paciente">Novas informacoes de paciente</param>
        void Atualizar(Guid id, Paciente paciente);

        /// <summary>
        /// Deleta um paciente presente no banco de dados
        /// </summary>
        /// <param name="id">Id do paciente a ser deletado</param>
        void Deletar(Guid id);

        /// <summary>
        /// Encontra um paciente pelo seu id
        /// </summary>
        /// <param name="id">Id do paciente</param>
        /// <returns>Paciente encontrado</returns>
        Paciente BuscarPorId(Guid id);
    }
}
