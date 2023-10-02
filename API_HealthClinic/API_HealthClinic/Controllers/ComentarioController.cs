using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;
using API_HealthClinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_HealthClinic.Controllers
{
    /// <summary>
    /// Controller de comentario
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ComentarioController : ControllerBase
    {
        private IComentarioRepository _comentarioRepository;

        /// <summary>
        /// Construtor do controller
        /// </summary>
        public ComentarioController()
        {
            _comentarioRepository = new ComentarioRepository();
        }

        /// <summary>
        /// Endpoint que aciona o metodo ListarTodos
        /// </summary>
        /// <returns>Lista de comentario</returns>
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                List<Comentario> lista = _comentarioRepository.ListarTodos();
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
        /// <param name="comentario">novo comentario</param>
        /// <returns>confirmacao ou erro</returns>
        [HttpPost]
        public IActionResult Cadastrar(Comentario comentario)
        {
            try
            {
                _comentarioRepository.Cadastrar(comentario);
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
        /// <param name="id">id do comentario</param>
        /// <param name="comentario">novas informacoes</param>
        /// <returns>confirmacao ou erro</returns>
        [HttpPut]
        public IActionResult Atualizar(Guid id, Comentario comentario)
        {
            try
            {
                _comentarioRepository.Atualizar(id, comentario);
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
        /// <param name="id">id do comentario</param>
        /// <returns>confirmacao ou erro</returns>
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _comentarioRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
