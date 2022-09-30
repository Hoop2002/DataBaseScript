using DataBaseScript.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBaseScript
{
    public class ConnectionDataBase : DbContext 
    {
        public DbSet<GameInfoSqlSchema> Games { get; set; } = null;

        public ConnectionDataBase()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=GamesCatalogDataBase;Username=postgres;Password=qwerty");
        }
    }
}
