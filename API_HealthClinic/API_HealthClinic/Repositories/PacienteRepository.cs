using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthContext ctx;

        public PacienteRepository()
        {
            ctx = new HealthContext();
        }

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

        public Paciente BuscarPorId(Guid id)
        {
            Paciente pacienteBuscado = ctx.Paciente.Find(id)!;

            if (pacienteBuscado != null)
            {
                return pacienteBuscado;
            }
            return null!;
        }

        public void Cadastrar(Paciente paciente)
        {
            paciente.IdPaciente = Guid.NewGuid();
            ctx.Paciente.Add(paciente);
            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Paciente pacienteBuscado = ctx.Paciente.Find(id)!;
            ctx.Paciente.Remove(pacienteBuscado);
            ctx.SaveChanges();
        }

        public List<Paciente> ListarTodos()
        {
            return ctx.Paciente.ToList();
        }
    }
}
