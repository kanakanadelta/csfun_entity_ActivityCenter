using Microsoft.EntityFrameworkCore;

namespace ActivityCenter.Models
{
    public class ACContext : DbContext
    {
        ACContext(DbContextOptions options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Association> Associations { get; set; }

    }
}