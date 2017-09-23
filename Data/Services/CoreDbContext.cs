using Core.Data.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Core.Data.Services
{
    public class CoreDbContext : DbContext, ICoreDbContext
    {
        /* Core */
        //public DbSet<Client> Clients { get; set; }

        //public DbSet<Tweet> Tweets { get; set; }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
