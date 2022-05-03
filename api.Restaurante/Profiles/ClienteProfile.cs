using api.Restaurante.Dto;
using api.Restaurante.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Restaurante.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteCreateDto, Cliente>();
            CreateMap<Cliente, ClienteReadDto>();
            CreateMap<ClienteUpdateDto, Cliente>();
        }
    }
}
