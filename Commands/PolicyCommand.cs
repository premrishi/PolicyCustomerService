namespace PolicyCustomerService.Commands
{
    using PolicyCustomerService.Data;
    using PolicyCustomerService.Models;
    using PolicyCustomerService.Request;
    using PolicyCustomerService.Response;
    using PolicyCustomerService.Interface;
    using System;
    using System.Threading.Tasks;
    using PolicyCustomerService.Results.PolicyCustomerService.Results;

    // Implements the IPolicyCommand interface
    public class PolicyCommand : IPolicyCommand
    {   
        private readonly PolicyDbContext _dbContext; // Database context
        private readonly IResultBuilder _resultBuilder; // Builds results

        public PolicyCommand(PolicyDbContext dbContext, IResultBuilder resultBuilder)
        {
            _dbContext = dbContext; // Inject database context
            _resultBuilder = resultBuilder; // Inject result builder
        }

        public async Task<Result> ExecuteAsync(PolicyRequest request)
        {
            var sessionId = Guid.NewGuid().ToString(); // Generate a session ID

            // Map request to entity
            var insurance = new Insurance
            {
                InsuranceType = request.InsuranceType,
                FirstName = request.FirstName,
                LastName = request.LastName,
                DateOfBirth = request.DateOfBirth,
                Gender = request.Gender,
                CurrentLocation = request.CurrentLocation,
                CoverageTypes =  request.CoverageTypes,
                PaymentFrequency = request.PaymentFrequency,
                SuggestedPremium = request.SuggestedPremium,
                PaymentMethod = request.PaymentMethod,
                PayNow = request.PayNow,
                SessionId = sessionId
            };

            // Save to database
            _dbContext.Insurances.Add(insurance);
            await _dbContext.SaveChangesAsync();

            // Build response
            var response = new PolicyResponse
            {
                PolicyId = insurance.Id.ToString(),
                Status = "Success",
                SessionId = sessionId
            };

            return _resultBuilder.Success(response); // Return success result
        }
    }


}
