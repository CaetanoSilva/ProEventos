using Microsoft.EntityFrameworkCore;

namespace ProEventos.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Eventos> Eventos { get; set; }
    }
}