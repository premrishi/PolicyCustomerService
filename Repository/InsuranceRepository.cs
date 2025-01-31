using PolicyCustomerService.Data;
using PolicyCustomerService.Interface;
using PolicyCustomerService.Models;

namespace PolicyCustomerService.Repository
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private readonly PolicyDbContext _dbContext;

        public InsuranceRepository(PolicyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddInsuranceAsync(Insurance insurance)
        {
            _dbContext.Insurances.Add(insurance);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }

}
