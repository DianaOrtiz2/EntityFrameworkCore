using Microsoft.EntityFrameworkCore;
using WebApplicationPOO2.Entities;

namespace WebApplicationPOO2
{
    public class ApplicationBdContext : DbContext
    {
        public ApplicationBdContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Choferes> Choferes { get; set; }

    }
}