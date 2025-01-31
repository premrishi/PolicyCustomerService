using PolicyCustomerService.Models;

namespace PolicyCustomerService.Interface
{
    public interface IInsuranceRepository
    {
        Task AddInsuranceAsync(Insurance insurance);
        Task SaveChangesAsync();
    }
}
