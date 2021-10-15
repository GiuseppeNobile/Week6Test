using Microsoft.EntityFrameworkCore;
using System;
using Week6Test.Core.Models;
using Week6Test.EF.Configurations;

namespace Week6Test.EF
{
    public class GestioneOrdiniContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Order> Orders { get; set; }

        public GestioneOrdiniContext() : base()
        {

        }

        public GestioneOrdiniContext(DbContextOptions<GestioneOrdiniContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GestioneOrdini;Integrated Security=true;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClientConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());

        }
    }
}
