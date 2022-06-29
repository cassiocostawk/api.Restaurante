using api.Restaurante.Dto;
using System.Collections.Generic;

namespace api.Restaurante.Services
{
    public interface IReadService
    {
        IReadDto GetById(int id);
        IList<IReadDto> GetAll();
    }
}
