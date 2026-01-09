using FCG.Domain.Models;
using FCG.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FCG.Infrastructure.Context
{
    public class FCGContext : DbContext
    {
        public FCGContext(DbContextOptions<FCGContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            JogoMap.Map(modelBuilder);
            PromocaoMap.Map(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Promocao> Promocao { get; set; }
    }
}
