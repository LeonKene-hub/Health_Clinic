using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    /// <summary>
    /// Interface de clinica
    /// </summary>
    public interface IClinicaRepository
    {
        /// <summary>
        /// Realiza o cadastro de clinica
        /// </summary>
        /// <param name="clinica">informacoes da clinica em JSON</param>
        void Cadastrar(Clinica clinica);

        /// <summary>
        /// Lista todos os clinicas presentes no banco de dados
        /// </summary>
        /// <returns>uma lista</returns>
        List<Clinica> ListarTodos();

        /// <summary>
        /// Atualiza uma clinica presente no banco de dados
        /// </summary>
        /// <param name="id">identificador da clinica a ser atualizada</param>
        /// <param name="clinica">novas informacoes</param>
        void Atualizar(Guid id, Clinica clinica);

        /// <summary>
        /// Deleta uma clinica presente no banco de dados
        /// </summary>
        /// <param name="id">identificador da clinica a ser apagada</param>
        void Deletar(Guid id);

        /// <summary>
        /// Busca uma clinica no banco de dados atraves do seu identificador
        /// </summary>
        /// <param name="id">identificador da clinica</param>
        /// <returns>clinica encontrada</returns>
        Clinica BuscarPorId(Guid id);
    }
}
