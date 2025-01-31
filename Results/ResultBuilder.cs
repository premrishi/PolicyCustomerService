using PolicyCustomerService.Interface;
using PolicyCustomerService.Results.PolicyCustomerService.Results;
namespace PolicyCustomerService.Results
{
    // Implements the IResultBuilder interface
    public class ResultBuilder : IResultBuilder
    {
        public Result Success(object data)
        {
            return new Result { IsSuccess = true, Data = data };
        }

        public Result Error(string errorMessage)
        {
            return new Result { IsSuccess = false, ErrorMessage = errorMessage };
        }
    }

}
