using Azure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Xml;

using WebApplicationTnsClub.Extensions;
using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.DB
{

    public class ApplicationContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<CoachUser> CoachUsers { get; set; }
        public DbSet<ParentUser> ParentUsers { get; set; }
        public DbSet<ManagerUser> ManagerUsers { get; set; }
        public DbSet<News> Newses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<SheduleClub> SheduleClubs { get; set; }
        public DbSet<SheduleClubOpenBooking> SheduleClubOpenBookings { get; set; }
        public DbSet<Abonement> Abonements { get; set; }


     /*   public DbSet<T>? _Return<T>(T item) where T : class,  IBaseId
        {

            return this.Users as DbSet<T>;
        
        }*/
        public ApplicationContext(DbContextOptions options)
                : base(options)
        {
            Database.EnsureCreated();
        }

        protected void _OnModelCreating<T,L>(ModelBuilder modelBuilder) where T:IBaseDataType<L>
        {
     /* 06.12.2024      modelBuilder.Entity<T>()
             .Property(e => e.DateCreate)
             .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<T>()
                .Property(e => e.DateUpdate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<T>()
                .HasQueryFilter(e => !e.IsDeleted);
     */
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          //  modelBuilder.ApplyUtcDateTimeConverter();

         /*   modelBuilder.Entity<User>()
                .Property(e => e.DateCreate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<User>()
                .Property(e => e.DateUpdate)
                .HasDefaultValueSql("GETDATE()");

            // todo     modelBuilder.Entity<User>()
            //          .HasQueryFilter(p => EF.Property<bool>(p, "isdeleted") == false);
            _OnModelCreating<Booking>(modelBuilder);
            _OnModelCreating<Club>(modelBuilder );
            _OnModelCreating<Rate>(modelBuilder );
            _OnModelCreating<Shedule>(modelBuilder );
            _OnModelCreating<SheduleClub>(modelBuilder );
            _OnModelCreating<SheduleClubOpenBooking>(modelBuilder );
            _OnModelCreating<Ticket>(modelBuilder );
            _OnModelCreating<News>(modelBuilder );
            _OnModelCreating<Group>(modelBuilder );
            _OnModelCreating<PersonalConnect>(modelBuilder );
        */

             base.OnModelCreating(modelBuilder);
        }

      /*  internal object _Return<T>() where T : IApiBaseId
        {
            throw new NotImplementedException();
        }*/

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
