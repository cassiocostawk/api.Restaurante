using api.Restaurante.Dto.ClienteContato;
using System;
using System.Collections.Generic;

namespace api.Restaurante.Dto
{
    public class ClienteUpdateDto : IUpdateDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public IList<ClienteContatoUpdateDto> ClienteContatos { get; set; } = new List<ClienteContatoUpdateDto>();
    }
}
