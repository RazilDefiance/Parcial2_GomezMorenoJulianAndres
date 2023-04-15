using Microsoft.EntityFrameworkCore;
using SoftBol.DAL.Entities;

namespace SoftBol.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        // Creación Tablas
        public DbSet<Ticket> Tickets { get; set; }

        // Creación Indice Tablas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(t => t.Id).IsUnique();
        }

    }
}
