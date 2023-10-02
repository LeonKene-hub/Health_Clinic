using API_HealthClinic.Domains;

namespace API_HealthClinic.Interfaces
{
    /// <summary>
    /// Interface de usuario
    /// </summary>
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Realiza o cadastro de usuario
        /// </summary>
        /// <param name="usuario">Novo usuario</param>
        void Cadastrar(Usuario usuario);

        /// <summary>
        /// Lista todos os usuarios presentes no banco de dados
        /// </summary>
        /// <returns>Lista de usuario</returns>
        List<Usuario> ListarTodos();

        /// <summary>
        /// Atualiza um usuario no banco de dados
        /// </summary>
        /// <param name="id">Id do usuario a ser atualizado</param>
        /// <param name="usuario">Novas informacoes de usuario</param>
        void Atualizar(Guid id, Usuario usuario);

        /// <summary>
        /// Deleta um usuario presente no banco de dados
        /// </summary>
        /// <param name="id">Id do usuario a ser deletado</param>
        void Delete(Guid id);

        /// <summary>
        /// Efetua o login validando acesso do usuario ao sistema
        /// </summary>
        /// <param name="email">Email do usuario</param>
        /// <param name="senha">Senha</param>
        /// <returns>Usuario encontrado (token)</returns>
        Usuario Login(string email, string senha);
    }
}
