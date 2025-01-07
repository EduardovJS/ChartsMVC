using GraficosASPNETMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GraficosASPNETMVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        DbSet<Pedido> Pedidos { get; set; }
        DbSet<Produto> Produtos { get; set; }
        DbSet<ItemPedido> ItemsPedidos { get; set; }


    }
}
