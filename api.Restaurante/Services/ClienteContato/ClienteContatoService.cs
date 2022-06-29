using api.Restaurante.Data;
using api.Restaurante.Dto.ClienteContato;
using api.Restaurante.Model;
using AutoMapper;
using FluentResults;
using System.Collections.Generic;
using System.Linq;

namespace api.Restaurante.Services
{
    public class ClienteContatoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ClienteContatoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Result Delete(int id)
        {
            ClienteContato clienteContato = _context.ClienteContatos.FirstOrDefault(c => c.Id == id);
            if (clienteContato == null) return Result.Fail("Não encontrado");

            _context.Remove(clienteContato);
            _context.SaveChanges();

            return Result.Ok();
        }

        public IEnumerable<ClienteContatoReadDto> GetAll()
        {
            IEnumerable<ClienteContato> clienteContato = _context.ClienteContatos.ToList();
            if (clienteContato == null) return null;

            return _mapper.Map<IEnumerable<ClienteContatoReadDto>>(clienteContato);
        }

        public ClienteContatoReadDto GetById(int id)
        {
            var clienteContato = _context.ClienteContatos.FirstOrDefault(c => c.Id == id);

            if (clienteContato == null) return null;
            
            return _mapper.Map<ClienteContatoReadDto>(clienteContato);
        }

        public ClienteContatoReadDto Insert(ClienteContatoCreateDto createDto)
        {
            ClienteContato clienteContato = _mapper.Map<ClienteContato>(createDto);
            _context.ClienteContatos.Add(clienteContato);
            _context.SaveChanges();

            return _mapper.Map<ClienteContatoReadDto>(clienteContato);
        }

        public Result Update(int id, ClienteContatoUpdateDto updateDto)
        {
            ClienteContato clienteContato = _context.ClienteContatos.FirstOrDefault(c => c.Id == id);
            if (clienteContato == null) return Result.Fail("Não encontrado.");

            _mapper.Map(updateDto, clienteContato);
            _context.SaveChanges();

            return Result.Ok();
        }
    }
}
