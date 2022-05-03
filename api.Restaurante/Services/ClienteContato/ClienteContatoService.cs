using api.Restaurante.Data;
using api.Restaurante.Dto;
using api.Restaurante.Dto.ClienteContato;
using AutoMapper;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;

namespace api.Restaurante.Services.ClienteContato
{
    public class ClienteContatoService : IReadService, IWriteService
    {
        private AppDbContext _context;
        private Mapper _mapper;

        public ClienteContatoService(AppDbContext context, Mapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Result Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<IReadDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public IReadDto GetById(int id)
        {
            //var readDto = _mapper.Map<ClienteContatoReadDto>(_context.ClienteContatos.FirstOrDefault(c => c.Id == id));

            //return readDto;
            return null;
        }

        public IReadDto Insert(ICreateDto createDto)
        {
            throw new NotImplementedException();
        }

        public Result Update(int id, IUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
