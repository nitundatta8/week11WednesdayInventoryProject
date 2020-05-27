using Microsoft.EntityFrameworkCore;
using Inventory.Models;

namespace Inventory.Models
{
  public class InventoryContext : DbContext
  {
    public DbSet<Product> inventories { get; set; }

    public InventoryContext(DbContextOptions options) : base(options) { }
  }
}