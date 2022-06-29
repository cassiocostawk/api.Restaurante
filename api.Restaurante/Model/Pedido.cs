using api.Restaurante.Model.Enum;
using System;
using System.Collections.Generic;

namespace api.Restaurante.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public StatusPedido Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public Cliente Cliente { get; set; }
        public IList<PedidoItem> PedidoItems { get; set; }
    }
}
