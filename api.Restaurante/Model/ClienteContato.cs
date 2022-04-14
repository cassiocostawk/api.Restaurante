using api.Restaurante.Model.Enum;

namespace api.Restaurante.Model
{
    public class ClienteContato
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public TipoContato Tipo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
