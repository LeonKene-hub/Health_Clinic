using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    /// <summary>
    /// Interface de Comentario
    /// </summary>
    public interface IComentarioRepository
    {
        /// <summary>
        /// Realiza o cadastro de Comentario
        /// </summary>
        /// <param name="comentario">Novo comentario a ser cadastrado</param>
        void Cadastrar(Comentario comentario);

        /// <summary>
        /// Lista todos os comentarios presentes no banco de dados
        /// </summary>
        /// <returns>Lista de comentarios</returns>
        List<Comentario> ListarTodos();

        /// <summary>
        /// Atualiza um comentario presente no banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <param name="comentario"></param>
        void Atualizar(Guid id, Comentario comentario);

        /// <summary>
        /// Deleta um comentario presente no banco de dados
        /// </summary>
        /// <param name="id">Id do comentario a ser deletado</param>
        void Deletar(Guid id);
    }
}
