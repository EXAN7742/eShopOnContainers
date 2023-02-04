namespace Coupon.API.Infrastructure.Repositories
{
    using System.Threading.Tasks;
    using Coupon.API.Infrastructure.Models;

    public interface IBenefitPointsRepository
    {
        Task<BenefitPoints> FindBenefitPointsByClientIdAsync(int clientId);

        Task UpdateQuantityOfBenefitPointsByClientIdAsync(BenefitPoints inBenefitPoints);
    }
}
