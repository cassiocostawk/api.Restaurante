using api.Restaurante.Dto;
using api.Restaurante.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace api.Restaurante.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _service;

        public ClienteController(ClienteService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var readDto = _service.GetAll();
            if (readDto == null) return NoContent();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var readDto = _service.GetById(id);
            if (readDto == null) return NotFound("Não encontrado.");

            return Ok(readDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ClienteUpdateDto updateDto)
        {
            var result = _service.Update(id, updateDto);

            if (!result.IsSuccess) return BadRequest(result.Errors);

            return Ok(result.Successes);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(ClienteCreateDto createDto)
        {
            var readDto = _service.Insert(createDto);
            if (readDto == null) return BadRequest("Não foi possível inserir.");

            return Ok(readDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _service.Delete(id);

            if (!result.IsSuccess) return NotFound(result.Errors);

            return NoContent();
        }
    }
}
