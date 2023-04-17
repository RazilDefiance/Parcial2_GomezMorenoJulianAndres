using Microsoft.AspNetCore.Components.Routing;
using SoftTicket.DAL;
using System.Diagnostics.Metrics;

namespace SoftTicket.DAL
{
    public class SeederDb
    {
        private readonly DataBaseContext _context;
        public SeederDb(DataBaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync(); // Crea la DB
            PopulateTickets(); // Llenamos Tickets hasta 50.000

            await _context.SaveChangesAsync();
        }

        private void PopulateTickets()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 1; i <= 50000; i++)
                {
                    _context.Tickets.Add(new Entities.Ticket
                    {
                        TicketID = i,
                        UseDate = null,
                        IsUsed = false,
                        EntranceGate = null,
                        CreateDate = DateTime.Now,
                    }
                    );
                }

            }
        }
    }
}