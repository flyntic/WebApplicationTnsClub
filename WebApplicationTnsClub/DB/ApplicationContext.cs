using Azure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Xml;
using WebApplicationTnsClub.ControllerModels;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.DateCreate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<User>()
                .Property(e => e.DateUpdate)
                .HasDefaultValueSql("GETDATE()");

      // todo     modelBuilder.Entity<User>()
      //          .HasQueryFilter(p => EF.Property<bool>(p, "isdeleted") == false);

            modelBuilder.Entity<Booking>()
             .Property(e => e.DateCreate)
             .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Booking>()
                .Property(e => e.DateUpdate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Booking>()
                .HasQueryFilter(e => !e.IsDeleted);


            modelBuilder.Entity<Club>()
                .Property(e => e.DateCreate)
                 .HasDefaultValueSql("GETDATE()");
    
            modelBuilder.Entity<Club>()
                .Property(e => e.DateUpdate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Club>()
                .HasQueryFilter(e => !e.IsDeleted);


            modelBuilder.Entity<Rate>()
                .Property(e => e.DateCreate)
                 .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Rate>()
                .Property(e => e.DateUpdate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Rate>()
                .HasQueryFilter(e => !e.IsDeleted);

            base.OnModelCreating(modelBuilder);
            /*
                        modelBuilder.Entity<User>()
                .Property(e => e.DateCreate)
                .HasDefaultValueSql("GETDATE()");

                        modelBuilder.Entity<User>()
                            .Property(e => e.DateUpdate)
                            .HasDefaultValueSql("GETDATE()");

                        modelBuilder.Entity<User>()
                            .HasQueryFilter(e => !e.IsDeleted);
            */
        }

        public override int SaveChanges()
        {
            var modifiedEntities = ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Modified);

            foreach (var entity in modifiedEntities)
            {
                entity.Property("DateUpdate").CurrentValue = DateTime.Now;
            }

            var deletedEntities = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Deleted);

            foreach (var entity in deletedEntities)
            {
                entity.State = EntityState.Modified;
                entity.Property("DateDelete").CurrentValue = DateTime.Now;
                entity.Property("IsDeleted").CurrentValue = true;
            }

            return base.SaveChanges();
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
