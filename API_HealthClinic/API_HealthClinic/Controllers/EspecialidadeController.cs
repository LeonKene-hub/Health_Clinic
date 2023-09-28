using API_HealthClinic.Domains;
using API_HealthClinic.Interfaces;
using API_HealthClinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EspecialidadeController : ControllerBase
    {
        private IEspecialidadeRepository _especialidadeRepository;

        public EspecialidadeController()
        {
<<<<<<< HEAD
            _especialidadeRepository = new EspecialidadeRepository();
=======
              _especialidadeRepository = new EspecialidadeRepository();
>>>>>>> c355ffe71834f8f6e0e5910bab367a2b5a4b1e19
        }

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
