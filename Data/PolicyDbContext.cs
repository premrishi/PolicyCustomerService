using Microsoft.EntityFrameworkCore;
using PolicyCustomerService.Models;

namespace PolicyCustomerService.Data
{
    public class PolicyDbContext : DbContext
    {
        // Represents the Insurance table
        public DbSet<Insurance> Insurances { get; set; }

        // Constructor to pass DbContextOptions to the base class
        public PolicyDbContext(DbContextOptions<PolicyDbContext> options) : base(options) { }

        // Configure database schema and behavior
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary key

                // No restrictions for any properties
                entity.Property(e => e.InsuranceType);
                entity.Property(e => e.CoverageTypes);  // No restrictions on CoverageTypes
                entity.Property(e => e.FirstName);      // No restrictions on Firstname
                entity.Property(e => e.LastName);       // No restrictions on Lastname
                entity.Property(e => e.DateOfBirth);            // No restrictions on Dob (Date of Birth)
                entity.Property(e => e.Gender);         // No restrictions on Gender
                entity.Property(e => e.CurrentLocation);
                entity.Property(e => e.PaymentFrequency);
                entity.Property(e => e.PaymentMethod);
                entity.Property(e => e.PayNow);
                entity.Property(e => e.SuggestedPremium);// No restrictions on CurrentLocation
            });
        }
    }
}
