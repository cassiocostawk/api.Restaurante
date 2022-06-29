using api.Restaurante.Data;
using api.Restaurante.Dto;
using AutoMapper;
using FluentResults;
using System.Collections.Generic;
using System.Linq;
using api.Restaurante.Model;

namespace api.Restaurante.Services
{
    public class ClienteService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ClienteService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Result Delete(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null) return Result.Fail("Não encontrado.");

            _context.Remove(cliente);
            _context.SaveChanges();

            return Result.Ok();
        }

        public IEnumerable<ClienteReadDto> GetAll()
        {
            IEnumerable<Cliente> cliente = _context.Clientes;
            if (cliente == null) return null;

            return _mapper.Map<IEnumerable<ClienteReadDto>>(cliente);
        }

        public ClienteReadDto GetById(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);

            if (cliente == null) return null;
            
            return _mapper.Map<ClienteReadDto>(cliente);
        }

        public ClienteReadDto Insert(ClienteCreateDto createDto)
        {
            Cliente cliente = _mapper.Map<Cliente>(createDto);
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return _mapper.Map<ClienteReadDto>(cliente);
        }

        public Result Update(int id, ClienteUpdateDto updateDto)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente == null) return Result.Fail("Não encontrado.");

            _mapper.Map(updateDto, cliente);
            _context.SaveChanges();

            return Result.Ok();
        }
    }
}
