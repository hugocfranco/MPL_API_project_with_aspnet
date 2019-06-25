using Microsoft.EntityFrameworkCore;
using Mpl.Data.Maps;
using Mpl.Models;


namespace Mpl.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Advogado> Advogados { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Escritorio> Escritorios { get; set; }
        public DbSet<AdvArea> AdvAreas { get; set; }
        public DbSet<EscArea> EscAreas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer(@"Server=localhost,1433;Database=MPLDB;User ID=SA;Password=Tel-32388771");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AdvAreaMap());
            builder.ApplyConfiguration(new AdvogadoMap());
            builder.ApplyConfiguration(new AreaMap());
            builder.ApplyConfiguration(new ClienteMap());
            builder.ApplyConfiguration(new EscAreaMap());
            builder.ApplyConfiguration(new EscritorioMap());
        }
    }
}