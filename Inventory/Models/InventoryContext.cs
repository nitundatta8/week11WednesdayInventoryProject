using Microsoft.EntityFrameworkCore;


namespace Inventory.Models
{
  public class InventoryContext : DbContext
  {
    public DbSet<Product> products { get; set; }

    public InventoryContext(DbContextOptions options) : base(options) { }
  }
}