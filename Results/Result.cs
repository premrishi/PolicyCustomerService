namespace PolicyCustomerService.Results
{
    namespace PolicyCustomerService.Results
    {
        public class Result
        {
            public int PolicyId { get; set; } // The ID of the policy created
            public bool IsSuccess { get; set; } // Indicates success or failure of the operation
            public string ?SessionId { get; set; } // Session ID for tracking
            public object? Data { get; internal set; }
            public string? ErrorMessage { get; internal set; }
        }
    }

}
