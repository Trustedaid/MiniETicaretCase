using Microsoft.EntityFrameworkCore;
using MiniETicaretAPI.Domain.Entities;

namespace MiniETicaretAPI.Persistence.Contexts;

public class MiniETicaretCaseAPIDbContext : DbContext
{
    public MiniETicaretCaseAPIDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    
    
    
}