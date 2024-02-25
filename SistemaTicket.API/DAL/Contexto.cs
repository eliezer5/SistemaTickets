using Microsoft.EntityFrameworkCore;
using SistemaTicket.Models;

namespace SistemaTicket.DAL
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {

        }

        DbSet<Tickets> Tickets { get; set; }
        DbSet<TicketsDetalles> TicketsDetalles { get; set; }

    }
}
