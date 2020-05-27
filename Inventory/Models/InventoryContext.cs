using Microsoft.EntityFrameworkCore;


namespace Inventory.Models
{
  public class InventoryContext : DbContext
  {
    public DbSet<Product> Inventories { get; set; }

    public InventoryContext(DbContextOptions options) : base(options) { }
  }
}