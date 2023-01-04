using DemoApiDotnet7.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApiDotnet7.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Asset> Assets { get; set; }
    }
}