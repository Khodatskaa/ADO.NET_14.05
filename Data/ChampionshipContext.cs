using System.Collections.Generic;

namespace Data
{
    public class ChampionshipContext : DbContext
    {
        public DbSet<ChampionshipStandings> Standings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ChampionshipDatabase;Trusted_Connection=True;");
        }
    }
}
