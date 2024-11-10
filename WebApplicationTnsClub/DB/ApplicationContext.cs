using Azure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.DB
{

    public class ApplicationContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Booking> Bookings { get; set; }
 
       //  public DbSet<Project> Projects { get; set; }
       //  public DbSet<WorkTask> WorkTasks { get; set; }
       //  public DbSet<ProjectUser> ProjectUsers { get; set; }
        //public DbSet<IdentityUserClaim<Guid>> IdentityUserClaims { get; set; }
        //public DbSet<IdentityUserClaim<string>> IdentityUserClaim
        //{
        //    get;
        //    set;
        //}

        public ApplicationContext(DbContextOptions options)
                : base(options)
        {
            Database.EnsureCreated();
        }
    /*    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }*/
       // public DbSet<User> Users { get; set; }
        // public DbSet<Employee> Employees { get; set; }
    }
    /*
    public class Project
    {
        public int Id { get; set; }
        public List<WorkTask> Tasks { get; set; }
        public List<ProjectUser> Users { get; set; }
    }

    public class ProjectUser
    {
        public int Id { get; set; }
        public string UserId { get; set; }
    }
    public class WorkTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }*/
}
