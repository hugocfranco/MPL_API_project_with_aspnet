using Microsoft.EntityFrameworkCore;
using Mpl.Models;


namespace Mpl.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Advogado> Advogados { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Escritorio> Escritorios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=MPLDB;User ID=SA;Password=Tel-32388771");
        }
    }
}