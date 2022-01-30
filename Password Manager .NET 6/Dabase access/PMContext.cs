using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Password_Manager_.NET_6.Model;

namespace Password_Manager_.NET_6
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
