using api.Restaurante.Dto.ClienteContato;
using api.Restaurante.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Restaurante.Profiles
{
    public class ClienteContatoProfile : Profile
    {
        public ClienteContatoProfile()
        {
            CreateMap<ClienteContatoCreateDto, ClienteContato>();
            CreateMap<ClienteContato, ClienteContatoReadDto>();
            CreateMap<ClienteContatoUpdateDto, ClienteContato>();
        }
    }
}
