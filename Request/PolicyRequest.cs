using System;
using System.Collections.Generic;
namespace PolicyCustomerService.Request
{

    // Represents the data coming from the client
    public class PolicyRequest
    {
        public string? InsuranceType { get; set; } // Type of insurance

        public string? FirstName { get; set; } // User's first name

        public string? LastName { get; set; } // User's last name

        public DateTime DateOfBirth { get; set; } // Date of birth

        public string? Gender { get; set; } // Gender

        public string? CurrentLocation { get; set; } // Location of the user

        public string? CoverageTypes { get; set; } // List of coverage types

        public string? PaymentFrequency { get; set; } // Payment frequency ("Monthly" or "Yearly")

        public string? SuggestedPremium { get; set; } // Suggested premium plan

        public string? PaymentMethod { get; set; } // Payment method

        public bool PayNow { get; set; } // Indicates if payment is made now
    }

}
