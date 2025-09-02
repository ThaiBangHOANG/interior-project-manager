using Interior.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Interior.Api.Data
{
    public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
    }
        public DbSet<InteriorProject> InteriorProjects { get; set; }
    }
}