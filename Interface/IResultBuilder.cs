namespace PolicyCustomerService.Interface
{
    using PolicyCustomerService.Results.PolicyCustomerService.Results;
    // Interface for building results
    public interface IResultBuilder
    {
        Result Success(object data); // Builds a success result
        Result Error(string errorMessage); // Builds an error result
    }

}
