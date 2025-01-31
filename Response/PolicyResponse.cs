namespace PolicyCustomerService.Response
{
    // Represents the data sent back to the client
    public class PolicyResponse
    {
        public string? PolicyId { get; set; } // Unique policy ID

        public string? Status { get; set; } // Operation status (e.g., "Success")

        public string? SessionId { get; set; } // Session ID for tracking
    }

}
