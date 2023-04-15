using Microsoft.EntityFrameworkCore;
using SoftTicket.DAL.Entities;

namespace SoftTicket.DAL
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
            modelBuilder.Entity<Ticket>().HasIndex(t => t.TicketID).IsUnique();
        }

    }
}
