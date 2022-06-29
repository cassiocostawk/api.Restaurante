using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace api.Restaurante.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }

        [JsonIgnore]
        public virtual ICollection<ClienteContato> ClienteContatos { get; set; }

        public Cliente()
        {
            ClienteContatos = new HashSet<ClienteContato>();
        }
    }
}
