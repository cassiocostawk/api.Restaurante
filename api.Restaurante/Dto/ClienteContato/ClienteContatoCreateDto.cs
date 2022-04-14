using api.Restaurante.Model.Enum;

namespace api.Restaurante.Dto.ClienteContato
{
    public class ClienteContatoCreateDto : ICreateDto
    {
        public int ClienteId { get; set; }
        public TipoContato Tipo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
