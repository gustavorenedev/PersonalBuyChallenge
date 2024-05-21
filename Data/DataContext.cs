using Microsoft.EntityFrameworkCore;
using PersonalBuy.Models;

namespace PersonalBuy.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> Options) : base(Options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CategoriaProduto> CategoriaProdutos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Compra> Compras { get; set; }
    }
}
