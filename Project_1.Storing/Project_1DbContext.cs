using Microsoft.EntityFrameworkCore;
using Project_1.Domain.Models;

namespace Project_1.Storing
{
  public class Project_1DbContext : DbContext
  {
    public DbSet<PizzaModel> Pizzas { get; set; } //create table
    public DbSet<OrderModel> Orders {get; set; }

    public Project_1DbContext(DbContextOptions options) : base(options){} //dependency injection

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<PizzaModel>().HasKey(e => e.Id); //primary constraint
      builder.Entity<CrustModel>().HasKey(e => e.Id);
      builder.Entity<SizeModel>().HasKey(e => e.Id);
      builder.Entity<ToppingModel>().HasKey(e => e.Id);
    }
  }
}