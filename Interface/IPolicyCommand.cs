using PolicyCustomerService.Request;
using System.Threading.Tasks;
using PolicyCustomerService.Results.PolicyCustomerService.Results;

namespace PolicyCustomerService.Interface
{
    public interface IPolicyCommand
    {
        Task<Result> ExecuteAsync(PolicyRequest request); // Executes the business logic
    }
}
