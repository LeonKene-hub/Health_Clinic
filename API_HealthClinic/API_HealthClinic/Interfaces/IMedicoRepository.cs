using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    /// <summary>
    /// Interface de medico
    /// </summary>
    public interface IMedicoRepository
    {
        /// <summary>
        /// Realiza o cadastro de medico
        /// </summary>
        /// <param name="medico">Novo medico</param>
        void Cadastrar(Medico medico);

        /// <summary>
        /// Lista todos os medicos presentes no banco de dados
        /// </summary>
        /// <returns>Lista de medico</returns>
        List<Medico> ListarTodos();

        /// <summary>
        /// Atualiza um medico no banco de dados
        /// </summary>
        /// <param name="id">Id do medico a ser atualizado</param>
        /// <param name="medico">Novas informacoes de medico</param>
        void Atualizar(Guid id, Medico medico);

        /// <summary>
        /// Deleta um medico presente no banco de dados
        /// </summary>
        /// <param name="id">Id do medico a ser deletado</param>
        void Deletar(Guid id);

        /// <summary>
        /// Encontra um medico pelo seu id
        /// </summary>
        /// <param name="id">Id do medico</param>
        /// <returns>Medico encontrado</returns>
        Medico BuscarPorId(Guid id);
    }
}
