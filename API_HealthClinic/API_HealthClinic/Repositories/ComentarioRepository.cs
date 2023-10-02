using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    /// <summary>
    /// Repositorio de comentario
    /// </summary>
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthContext ctx;

        /// <summary>
        /// Construtor de comentario
        /// </summary>
        public ComentarioRepository()
        {
            ctx = new HealthContext();
        }

        /// <summary>
        /// Metodo de atualizar comentario
        /// </summary>
        /// <param name="id">id da comentario</param>
        /// <param name="comentario">novas informacoes</param>
        public void Atualizar(Guid id, Comentario comentario)
        {
            Comentario comentarioBuscado = ctx.Comentario.Find(id)!;

            if (comentarioBuscado != null)
            {
                comentarioBuscado.ComentarioConsulta = comentario.ComentarioConsulta;
                comentarioBuscado.Permissao= comentario.Permissao;
            }
            ctx.Update(comentarioBuscado);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de cadastrar comentario
        /// </summary>
        /// <param name="comentario">Informacoes da nova comentario</param>
        public void Cadastrar(Comentario comentario)
        {
            comentario.IdComentario = Guid.NewGuid();
            ctx.Comentario.Add(comentario);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de deletar comentario
        /// </summary>
        /// <param name="id">id do comentario</param>
        public void Deletar(Guid id)
        {
            Comentario comentarioBuscado = ctx.Comentario.Find(id)!;
            ctx.Comentario.Remove(comentarioBuscado);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de listar comentarios
        /// </summary>
        /// <returns>Lista de comentarios</returns>
        public List<Comentario> ListarTodos()
        {
            return ctx.Comentario.ToList();
        }
    }
}
