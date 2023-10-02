using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    /// <summary>
    /// Repositorio de consulta
    /// </summary>
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext ctx;

        /// <summary>
        /// Construtor de consulta
        /// </summary>
        public ConsultaRepository()
        {
            ctx = new HealthContext();
        }

        /// <summary>
        /// Metodo de atualizar consulta
        /// </summary>
        /// <param name="id">id da consulta</param>
        /// <param name="consulta">novas informacoes</param>
        public void Atualizar(Guid id, Consulta consulta)
        {
            Consulta consultaBuscada = ctx.Consulta.Find(id)!;

            if (consultaBuscada != null)
            {
                consultaBuscada.Hora = consulta.Hora;
                consultaBuscada.Local = consulta.Local;
                consultaBuscada.Status = consulta.Status;
                consultaBuscada.Descricao = consulta.Descricao;
            }

            ctx.Update(consultaBuscada);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de cadastrar consulta
        /// </summary>
        /// <param name="consulta">Informacoes da nova consulta</param>
        public void Cadastrar(Consulta consulta)
        {
            consulta.IdConsulta = Guid.NewGuid();
            ctx.Consulta.Add(consulta);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de deletar consulta
        /// </summary>
        /// <param name="id">id da consulta</param>
        public void Delete(Guid id)
        {
            Consulta consultaBuscada = ctx.Consulta.Find(id)!;
            ctx.Consulta.Remove(consultaBuscada);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de listar consultas de medicos
        /// </summary>
        /// <param name="id">id de medico</param>
        /// <returns>lista de consultas</returns>
        public List<Consulta> ListarPorMedico(Guid id)
        {
            List<Consulta> lista = new List<Consulta>();

            foreach (var consulta in ctx.Consulta)
            {
                if (consulta.IdMedico == id)
                {
                    lista.Add(consulta);
                }
            }

            return lista;
        }

        /// <summary>
        /// Metodo de listar consultas de pacientes
        /// </summary>
        /// <param name="id">id de medico paciente</param>
        /// <returns>lista de consultas</returns>
        public List<Consulta> ListarPorPaciente(Guid id)
        {
            List<Consulta> lista = new List<Consulta>();

            foreach (var consulta in ctx.Consulta)
            {
                if (consulta.IdPaciente == id)
                {
                    lista.Add(consulta);
                }
            }

            return lista;
        }

        /// <summary>
        /// Metodo de listar consultas
        /// </summary>
        /// <returns>Lista de consultas</returns>
        public List<Consulta> ListarTodos()
        {
            return ctx.Consulta.ToList();
        }
    }
}
