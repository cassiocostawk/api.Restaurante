namespace api.Restaurante.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string UnidadeMedida { get; set; }
        public double ValorUnitario { get; set; }
        public bool Ativo { get; set; }
    }
}
