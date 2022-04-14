using api.Restaurante.Dto.ClienteContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Restaurante.Dto.Cliente
{
    public class ClienteUpdateDto : IUpdateDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public IList<ClienteContatoUpdateDto> ClienteContatos { get; set; } = new List<ClienteContatoUpdateDto>();
    }
}
