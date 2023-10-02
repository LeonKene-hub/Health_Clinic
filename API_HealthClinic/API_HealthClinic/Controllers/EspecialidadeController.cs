using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;
using API_HealthClinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_HealthClinic.Controllers
{
    /// <summary>
    /// Controller de especialidade
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EspecialidadeController : ControllerBase
    {
        private IEspecialidadeRepository _especialidadeRepository;

        /// <summary>
        /// Construtor do controller
        /// </summary>
        public EspecialidadeController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }

        /// <summary>
        /// Endpoint que aciona o metodo ListarTodos
        /// </summary>
        /// <returns>Lista de especialidade</returns>
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                List<Especialidade> lista = _especialidadeRepository.ListarTodos();
                return Ok(lista);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o metodo de cadastrar
        /// </summary>
        /// <param name="especialidade">nova especialidade</param>
        /// <returns>confirmacao ou erro</returns>
        [HttpPost]
        public IActionResult Cadastrar(Especialidade especialidade)
        {
            try
            {
                _especialidadeRepository.Cadastrar(especialidade);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o metodo Deletar
        /// </summary>
        /// <param name="id">Id da especialidade</param>
        /// <returns>confirmacao ou erro</returns>
        [HttpDelete]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _especialidadeRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
