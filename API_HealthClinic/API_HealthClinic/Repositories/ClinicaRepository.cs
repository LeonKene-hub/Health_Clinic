using API_HealthClinic.Context;
using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;

namespace API_HealthClinic.Repositories
{
    /// <summary>
    /// Repositorio de clinica
    /// </summary>
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthContext ctx;

        /// <summary>
        /// Construtor de clinica
        /// </summary>
        public ClinicaRepository()
        {
            ctx = new HealthContext();
        }

        /// <summary>
        /// Metodo de atualizar clinica
        /// </summary>
        /// <param name="id">id da clinica</param>
        /// <param name="clinica">novas informacoes</param>
        public void Atualizar(Guid id, Clinica clinica)
        {
            Clinica clinicaBuscada = ctx.Clinicas.Find(id)!;

            if (clinicaBuscada != null)
            {
                clinicaBuscada.RazaoSocial = clinica.RazaoSocial;
                clinicaBuscada.NomeFantasia = clinica.NomeFantasia;
                clinicaBuscada.CNPJ= clinica.CNPJ;
                clinicaBuscada.Endereco= clinica.Endereco;
                clinicaBuscada.HorarioAbertura = clinica.HorarioAbertura;
                clinicaBuscada.HorarioFechamento = clinica.HorarioFechamento;
            }
            ctx.Update(clinicaBuscada);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de buscar por id da clinica
        /// </summary>
        /// <param name="id">id da clinica</param>
        /// <returns>clinica encontrada</returns>
        public Clinica BuscarPorId(Guid id)
        {
            Clinica clinica = ctx.Clinicas.Find(id)!;

            if (clinica != null)
            {
                return clinica;
            }
            return null!;
        }

        /// <summary>
        /// Metodo de cadastrar clinica
        /// </summary>
        /// <param name="clinica">Informacoes da nova clinica</param>
        public void Cadastrar(Clinica clinica)
        {
            clinica.IdClinica = Guid.NewGuid();
            ctx.Clinicas.Add(clinica);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de deletar clinica
        /// </summary>
        /// <param name="id">id da clinica</param>
        public void Deletar(Guid id)
        {
            Clinica clinica = ctx.Clinicas.Find(id)!;
            ctx.Clinicas.Remove(clinica);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Metodo de listar clinicas
        /// </summary>
        /// <returns>Lista de clinicas</returns>
        public List<Clinica> ListarTodos()
        {
            return ctx.Clinicas.ToList();
        }
    }
}
