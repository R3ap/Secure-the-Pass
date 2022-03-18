using Microsoft.EntityFrameworkCore;
using Services_Core.Model;

namespace Services_Core.Context
{
    class PMContext : DbContext
    {
        public DbSet<Account> Account { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost;Database=PassManager;Trusted_Connection=True;");
        }
    }
}
