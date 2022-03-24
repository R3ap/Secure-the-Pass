using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Secure_The_Pass_Services_Core.Model;

namespace Secure_The_Pass_Services_Core.Context
{
    class PMContext : DbContext
    {
        public DbSet<Account> Account { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.;Database=PassManager;Trusted_Connection=True;");
        }
    }
}
