using Microsoft.EntityFrameworkCore;
using SistemaTicket.Models;

namespace SistemaTicket.DAL
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {

        }

        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<TicketsDetalles> TicketsDetalles { get; set; }

    }
}
