using SampleChatter.Entities;
using Microsoft.EntityFrameworkCore;
using NLog;

namespace SampleChatter.Repository
{
    public class SampleChatterDbContext : DbContext
    {
        protected static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public SampleChatterDbContext(DbContextOptions<SampleChatterDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Logger.Info("Started configuring entities");
            // ConfigureCustomer(builder);
            Logger.Info("Completed configuring entities");
        }

        // public static void ConfigureCustomer(ModelBuilder builder) 
        // {
        //     builder.Entity<Customer>(entity =>
        //     {
        //         entity.ToTable("customer");
        //         entity.HasKey(e => new { e.CustomerId });
        //         entity.Property(e => e.CustomerId).HasColumnName("customer_id");
        //         entity.Property(e => e.FirstName).HasColumnName("first_name");
        //         entity.Property(e => e.LastName).HasColumnName("last_name");
        //         entity.Property(e => e.Title).HasColumnName("title");
        //         entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
        //         entity.Property(e => e.Mobile).HasColumnName("mobile");
        //         entity.Property(e => e.Email).HasColumnName("email");
        //     });
        // }
    }
}