using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Service_Core.Model;

namespace Service_Core.Context
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
