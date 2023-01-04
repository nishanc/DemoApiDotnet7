using DemoApiDotnet7.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApiDotnet7.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Asset> Assets { get; set; }
        public DbSet<WorkStation> WorkStations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Asset>()
                .HasOne<WorkStation>(a => a.WorkStation)
                .WithMany(w => w.Assets)
                .HasForeignKey(a => a.WorkStationId);          
        }
    }
}