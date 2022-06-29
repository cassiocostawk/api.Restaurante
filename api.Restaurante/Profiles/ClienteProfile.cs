using api.Restaurante.Dto;
using api.Restaurante.Model;
using AutoMapper;

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
