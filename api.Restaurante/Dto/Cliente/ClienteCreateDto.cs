using api.Restaurante.Dto.ClienteContato;
using System;
using System.Collections.Generic;

namespace api.Restaurante.Dto
{
    public class ClienteCreateDto : ICreateDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<ClienteContatoCreateDto> ClienteContatos { get; set; } = new List<ClienteContatoCreateDto>();
    }
}
