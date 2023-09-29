using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthContext ctx;

        public ComentarioRepository()
        {
            ctx = new HealthContext();
        }

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

        public void Cadastrar(Comentario comentario)
        {
            comentario.IdComentario = Guid.NewGuid();
            ctx.Comentario.Add(comentario);
            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Comentario comentarioBuscado = ctx.Comentario.Find(id)!;
            ctx.Comentario.Remove(comentarioBuscado);
            ctx.SaveChanges();
        }

        public List<Comentario> ListarTodos()
        {
            return ctx.Comentario.ToList();
        }
    }
}
