using api.Restaurante.Dto;
using api.Restaurante.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Restaurante.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : Controller
    {
        private ClienteService _service;

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
            if (readDto == null) return NoContent();

            return Ok(readDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ClienteUpdateDto updateDto)
        {
            var result = _service.Update(id, updateDto);

            return result.IsSuccess ? Ok(result.Successes) : NotFound(result.Errors); 
        }

        [HttpPost]
        public async Task<IActionResult> Insert(ClienteCreateDto createDto)
        {
            var readDto = _service.Insert(createDto);
            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _service.Delete(id);

            return result.IsSuccess ? NoContent() : NotFound(result.Errors);
        }
    }
}
