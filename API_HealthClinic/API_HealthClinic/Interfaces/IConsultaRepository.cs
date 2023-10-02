using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    /// <summary>
    /// Interface de consulta
    /// </summary>
    public interface IConsultaRepository
    {
        /// <summary>
        /// Realiza o cadastro de consulta
        /// </summary>
        /// <param name="consulta"></param>
        void Cadastrar(Consulta consulta);

        /// <summary>
        /// Lista todos as consultas presentes no banco de dados
        /// </summary>
        /// <returns>Lista de consulta</returns>
        List<Consulta> ListarTodos();

        /// <summary>
        /// Atualiza uma consulta presente no banco de dados
        /// </summary>
        /// <param name="id">Id da consulta a ser atualizada</param>
        /// <param name="consulta">novas informacoes de consulta</param>
        void Atualizar(Guid id, Consulta consulta);

        /// <summary>
        /// Deleta uma consulta presente no banco de dados
        /// </summary>
        /// <param name="id">Id do comentario a ser deletado</param>
        void Delete(Guid id);

        /// <summary>
        /// Lista todos as consultas presentes de paciente
        /// </summary>
        /// <param name="id">Id do paciente</param>
        /// <returns>Lista de consulta do paciente</returns>
        List<Consulta> ListarPorPaciente(Guid id);

        /// <summary>
        /// Lista todos as consultas presentes de medico
        /// </summary>
        /// <param name="id">Id do medico</param>
        /// <returns>Lista de consulta do medico</returns>
        List<Consulta> ListarPorMedico(Guid id);
    }
}
