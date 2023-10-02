using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    /// <summary>
    /// Repositorio de paciente
    /// </summary>
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthContext ctx;

        /// <summary>
        /// Construtor de paciente
        /// </summary>
        public PacienteRepository()
        {
            ctx = new HealthContext();
        }

        /// <summary>
        /// Metodo de atualizar paciente
        /// </summary>
        /// <param name="id">id do paciente</param>
        /// <param name="paciente">novas informacoes</param>
        public void Atualizar(Guid id, Paciente paciente)
        {
            Paciente pacienteBuscado = ctx.Paciente.Find(id)!;

            if (pacienteBuscado != null)
            {
                pacienteBuscado.DataNascimento = paciente.DataNascimento;
                pacienteBuscado.Genero= paciente.Genero;
                pacienteBuscado.Telefone= paciente.Telefone;
                pacienteBuscado.Endereco= paciente.Endereco;
                pacienteBuscado.CPF= paciente.CPF;
            }
            ctx.Update(pacienteBuscado);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de buscar por id da paciente
        /// </summary>
        /// <param name="id">id da paciente</param>
        /// <returns>paciente encontrada</returns>
        public Paciente BuscarPorId(Guid id)
        {
            Paciente pacienteBuscado = ctx.Paciente.Find(id)!;

            if (pacienteBuscado != null)
            {
                return pacienteBuscado;
            }
            return null!;
        }

        /// <summary>
        /// Metodo de cadastrar paciente
        /// </summary>
        /// <param name="paciente">Informacoes do novo paciente</param>
        public void Cadastrar(Paciente paciente)
        {
            paciente.IdPaciente = Guid.NewGuid();
            ctx.Paciente.Add(paciente);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de deletar paciente
        /// </summary>
        /// <param name="id">id da paciente</param>
        public void Deletar(Guid id)
        {
            Paciente pacienteBuscado = ctx.Paciente.Find(id)!;
            ctx.Paciente.Remove(pacienteBuscado);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de listar paciente
        /// </summary>
        /// <returns>Lista de pacientes</returns>
        public List<Paciente> ListarTodos()
        {
            return ctx.Paciente.ToList();
        }
    }
}
