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
        public DbSet<Shedule> Shedules { get; set; }
        public DbSet<PersonalConnect> PersonalConnects { get; set; }
        public DbSet<News> Newses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<SheduleClub> SheduleClubs { get; set; }
        public DbSet<SheduleClubOpenBooking> SheduleClubOpenBookings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        //  public DbSet<Project> Projects { get; set; }
        //  public DbSet<WorkTask> WorkTasks { get; set; }
        //  public DbSet<ProjectUser> ProjectUsers { get; set; }
        //public DbSet<IdentityUserClaim<Guid>> IdentityUserClaims { get; set; }
        //public DbSet<IdentityUserClaim<string>> IdentityUserClaim
        //{
        //    get;
        //    set;
        //}

        public DbSet<T>? Return<T>(T item) where T : class,  IBaseId
        {

            return Tickets;
        
        }
        public ApplicationContext(DbContextOptions options)
                : base(options)
        {
            Database.EnsureCreated();
        }

        protected void _OnModelCreating<IBaseId>(ModelBuilder modelBuilder,IBaseId T)
        {
            modelBuilder.Entity<T>()
             .Property(e => e.DateCreate)
             .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<T>()
                .Property(e => e.DateUpdate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<T>()
                .HasQueryFilter(e => !e.IsDeleted);

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
            _OnModelCreating(modelBuilder, Booking);
            _OnModelCreating(modelBuilder, Club);
            _OnModelCreating(modelBuilder, Rate);
            _OnModelCreating(modelBuilder, Shedule);
            _OnModelCreating(modelBuilder, SheduleClub);
            _OnModelCreating(modelBuilder, SheduleClubOpenBooking);
            _OnModelCreating(modelBuilder, Ticket);
            _OnModelCreating(modelBuilder, News);
            _OnModelCreating(modelBuilder, Group);
            _OnModelCreating(modelBuilder, PersonalConnect);


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
