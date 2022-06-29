namespace api.Restaurante.Model
{
    public class PedidoItem
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double PercentualDesconto { get; set; }
        public double ValorDesconto { get; set; }
        public double ValorTotal { get; set; }

        public Produto Produto { get; set; }
    }
}
