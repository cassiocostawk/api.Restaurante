using api.Restaurante.Data;
using api.Restaurante.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Restaurante.Services
{
    public interface IReadService
    {
        IReadDto GetById(int id);
        IList<IReadDto> GetAll();
    }
}
