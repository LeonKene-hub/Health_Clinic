using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    /// <summary>
    /// Interface de Especialidade
    /// </summary>
    public interface IEspecialidadeRepository
    {
        /// <summary>
        /// Realiza o cadastro de especialidade
        /// </summary>
        /// <param name="especialidade">Nova especialidade</param>
        void Cadastrar(Especialidade especialidade);

        /// <summary>
        /// Lista todas as especialidades presentes no banco de dados
        /// </summary>
        /// <returns>Lista de especialidade</returns>
        List<Especialidade> ListarTodos();

        /// <summary>
        /// Deleta uma especialidade presente no banco de dados
        /// </summary>
        /// <param name="id">Id da especialidade a ser deletada</param>
        void Deletar(Guid id);
    }
}
