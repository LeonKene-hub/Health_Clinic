using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    /// <summary>
    /// Interface de tiposUsuario
    /// </summary>
    public interface ITiposUsuarioRepository
    {
        /// <summary>
        /// Realiza o cadastro de tiposUsuario
        /// </summary>
        /// <param name="tiposUsuario">Novo tiposUsuario</param>
        void Cadastrar(TiposUsuario tiposUsuario);

        /// <summary>
        /// Lista todos os tiposUsuario presentes no banco de dados
        /// </summary>
        /// <returns>Lista de tiposUsuario</returns>
        List<TiposUsuario> ListarTodos();

        /// <summary>
        /// Deleta um tiposUsuario presente no banco de dados
        /// </summary>
        /// <param name="id">Id do tiposUsuario a ser deletado</param>
        void Deletar(Guid id);
    }
}
