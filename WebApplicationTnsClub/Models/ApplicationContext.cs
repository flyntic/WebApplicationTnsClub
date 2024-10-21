using Azure;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationTnsClub.Models
{

    /*      public class ApplicationContext : DbContext
          {
              public ApplicationContext(DbContextOptions<ApplicationContext> options)
                  : base(options)
              {
                  Database.EnsureCreated();
              }

              public DbSet<Product> Products { get; set; }
          }
    */

    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
       /*   public ApplicationContext(DbContextOptions<ApplicationContext> options)
          {
              Database.EnsureCreated();
          }*/
     //   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     //   {
     //       optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=tennisclub;Username=postgres;Password=09870");
     //   }
      /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .ValueGeneratedOnAdd();
        }*/
    }
}
