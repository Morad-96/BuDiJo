using BuDiJo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BuDiJo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Many to Many Relation EmployeeTicket
            builder.Entity<EmployeeTicket>().HasKey(m => new
            {
                m.Employee_ID,
                m.Ticket_ID
            });

            builder.Entity<EmployeeTicket>()
                .HasOne(t => t.Employees)
                .WithMany(ta => ta.EmployeeTickets)
                .HasForeignKey(tb => tb.Employee_ID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<EmployeeTicket>()
                .HasOne(t => t.Tickets)
                .WithMany(ta => ta.EmployeeTickets)
                .HasForeignKey(tb => tb.Ticket_ID)
                .OnDelete(DeleteBehavior.Restrict);


            //Many to Many Relation EmployeeTask
            builder.Entity<EmployeeTask>().HasKey(m => new
            {
                m.Employee_ID,
                m.Task_ID
            });
            builder.Entity<EmployeeTask>()
                .HasOne(t => t.Employees)
                .WithMany(ta => ta.EmployeeTasks)
                .HasForeignKey(tb => tb.Employee_ID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<EmployeeTask>()
                .HasOne(t => t.Tasks)
                .WithMany(ta => ta.EmployeeTasks)
                .HasForeignKey(tb => tb.Task_ID)
                .OnDelete(DeleteBehavior.Restrict);


            //Notations for Attributes
            builder.Entity<Employee>().Property(e => e.IsManager).HasDefaultValue(false);
            base.OnModelCreating(builder);

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<EmployeeTicket> EmployeeTickets { get; set; }
        public DbSet<EmployeeTask> EmployeeTasks { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ClockEvent> ClockEvents { get; set; }


    }


}
