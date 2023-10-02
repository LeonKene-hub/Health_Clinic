using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;
using API_HealthClinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_HealthClinic.Controllers
{
    /// <summary>
    /// Controller de consulta
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ConsultaController : ControllerBase
    {
        private IConsultaRepository _consultaRepository;

        /// <summary>
        /// Construtor do controller
        /// </summary>
        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();
        }

        /// <summary>
        /// Endpoint que aciona o metodo ListarTodos
        /// </summary>
        /// <returns>Lista de consulta</returns>
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                List<Consulta> lista = _consultaRepository.ListarTodos();
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
        /// <param name="consulta">nova consulta</param>
        /// <returns>confirmacao ou erro</returns>
        [HttpPost]
        public IActionResult Cadastrar(Consulta consulta)
        {
            try
            {
                _consultaRepository.Cadastrar(consulta);
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
        /// <param name="id">Id da consulta</param>
        /// <param name="consulta">novas informacoes</param>
        /// <returns>confirmacao ou erro</returns>
        [HttpPut]
        public IActionResult Atualizar(Guid id, Consulta consulta)
        {
            try
            {
                _consultaRepository.Atualizar(id, consulta);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o metodo ListarListarPorMedico
        /// </summary>
        /// <param name="id">id do medico</param>
        /// <returns>lista de consulta</returns>
        [HttpGet("Medico")]
        public IActionResult ListarListarPorMedico(Guid id)
        {
            try
            {
                List<Consulta> listaMedico = _consultaRepository.ListarPorMedico(id);
                return Ok(listaMedico);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o metodo ListarPorPaciente
        /// </summary>
        /// <param name="id">id do paciente</param>
        /// <returns>lista de consulta</returns>
        [HttpGet("Paciente")]
        public IActionResult ListarPorPaciente(Guid id)
        {
            try
            {
                List<Consulta> listaPaciente = _consultaRepository.ListarPorPaciente(id);
                return Ok(listaPaciente);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o metodo Delete
        /// </summary>
        /// <param name="id">Id da consulta</param>
        /// <returns>confirmacao ou erro</returns>
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _consultaRepository.Delete(id);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
