using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;
using API_HealthClinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_HealthClinic.Controllers
{
    /// <summary>
    /// Controller de clinica
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ClinicaController : ControllerBase
    {
        private IClinicaRepository _clinicaRepository;

        /// <summary>
        /// Construtor do controller
        /// </summary>
        public ClinicaController()
        {
            _clinicaRepository = new ClinicaRepository();
        }

        /// <summary>
        /// Endpoint que aciona o metodo ListarTodos
        /// </summary>
        /// <returns>Lista de clinica</returns>
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                List<Clinica> lista = _clinicaRepository.ListarTodos();
                return Ok(lista);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o metodo BuscarPorId
        /// </summary>
        /// <param name="id">id da clinica</param>
        /// <returns>clinica encontrada</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            try
            {
                Clinica clinica = _clinicaRepository.BuscarPorId(id);
                return Ok(clinica);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o metodo de cadastrar
        /// </summary>
        /// <param name="clinica">nova clinica</param>
        /// <returns>confirmacao ou erro</returns>
        [HttpPost]
        public IActionResult Cadastrar(Clinica clinica)
        {
            try
            {
                _clinicaRepository.Cadastrar(clinica);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o metodo Atualizar
        /// </summary>
        /// <param name="id">Id da clinica</param>
        /// <param name="clinica">novas informacoes</param>
        /// <returns>confirmacao ou erro</returns>
        [HttpPut]
        public IActionResult Atualizar(Guid id, Clinica clinica)
        {
            try
            {
                _clinicaRepository.Atualizar(id, clinica);
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
        /// <param name="id">Id da clinica</param>
        /// <returns>confirmacao ou erro</returns>
        [HttpDelete]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _clinicaRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
