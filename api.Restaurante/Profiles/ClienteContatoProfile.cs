using api.Restaurante.Dto.ClienteContato;
using api.Restaurante.Model;
using AutoMapper;

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
