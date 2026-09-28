using Microsoft.EntityFrameworkCore;
using WebBaiTap.Models;

namespace WebBaiTap.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}
