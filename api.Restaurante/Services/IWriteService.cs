using api.Restaurante.Dto;
using FluentResults;

namespace api.Restaurante.Services
{
    public interface IWriteService
    {
        public IReadDto Insert(ICreateDto createDto);
        public Result Update(int id, IUpdateDto updateDto);
        public Result Delete(int id);
    }
}
