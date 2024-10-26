using Azure;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationTnsClub.Models
{

    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
