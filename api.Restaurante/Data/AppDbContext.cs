using api.Restaurante.Model;
using Microsoft.EntityFrameworkCore;

namespace api.Restaurante.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        /*public DbSet<ClienteContato> ClienteContatos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoItem> PedidoItems { get; set; }*/

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            *//*if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RestauranteDB;Trusted_Connection=true;");*//*
        }*/
    }
}
