﻿using api.Restaurante.Dto.ClienteContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Restaurante.Dto
{
    public class ClienteReadDto : IReadDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }

        public IList<ClienteContatoReadDto> ClienteContatos { get; set; } = new List<ClienteContatoReadDto>();
    }
}
