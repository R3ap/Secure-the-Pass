using Microsoft.EntityFrameworkCore;
using Secure_The_Pass_Services_Core.Model;

namespace Secure_The_Pass_Services_Core.Context
{
    class PMContext : DbContext
    {
        public DbSet<Account> Account { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=144.91.100.193;initial catalog=PassManager;user id=sa;password=wIB8LP§gfc9i8wYbA5?4");
        }
    }
}
