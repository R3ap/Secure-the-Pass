using Microsoft.EntityFrameworkCore;
using Password_Manager_Services_Core.Model;

namespace Password_Manager_Services_Core.Context
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
