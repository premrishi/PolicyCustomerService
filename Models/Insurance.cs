using System;
using System.ComponentModel.DataAnnotations;
namespace PolicyCustomerService.Models
{
    public class Insurance
    {
        [Key] // Primary Key for the table
        public int Id { get; set; } // Auto-incremented ID for each record

        [Required] // Ensures this column is not null
        public string? InsuranceType { get; set; } // E.g., "medical" or "auto"

        [Required]
        public string? FirstName { get; set; } // User's first name

        [Required]
        public string? LastName { get; set; } // User's last name

        [Required]
        public DateTime DateOfBirth { get; set; } // User's date of birth

        [Required]
        public string? Gender { get; set; } // E.g., "Male" or "Female"

        [Required]
        public string? CurrentLocation { get; set; } // E.g., "New York"

        [Required]
        public string? CoverageTypes { get; set; } // Stores multiple values as comma-separated string

        [Required]
        public string? PaymentFrequency { get; set; } // E.g., "Monthly" or "Yearly"

        [Required]
        public string? SuggestedPremium { get; set; } // E.g., "Premium Plan 1"

        [Required]
        public string? PaymentMethod { get; set; } // E.g., "Credit Card"

        [Required]
        public bool PayNow { get; set; } // Indicates if payment is made now

        public string? SessionId { get; set; } // Unique session ID to track requests
    }
}
