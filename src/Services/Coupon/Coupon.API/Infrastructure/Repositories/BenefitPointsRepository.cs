namespace Coupon.API.Infrastructure.Repositories
{
    using System.Threading.Tasks;
    using Coupon.API.Infrastructure.Models;
    using Microsoft.Azure.ServiceBus;
    using MongoDB.Driver;

    public class BenefitPointsRepository : IBenefitPointsRepository
    {
        private readonly CouponContext _couponContext;

        public BenefitPointsRepository(CouponContext couponContext)
        {
            _couponContext = couponContext;
        }

        public async Task UpdateQuantityOfBenefitPointsByClientIdAsync(BenefitPoints inBenefitPoints)
        {
            var filter = Builders<BenefitPoints>.Filter.Eq(x => x.ClientId, inBenefitPoints.ClientId);
            var curBenfitPoints = await _couponContext.BenefitPoints.Find(filter).FirstOrDefaultAsync();
            if(curBenfitPoints is null)
            {
                await _couponContext.BenefitPoints.InsertOneAsync(inBenefitPoints);
            }
            else
            {
                var update = Builders<BenefitPoints>.Update
                .Set(benfitPoints => benfitPoints.Quantity, curBenfitPoints.Quantity + inBenefitPoints.Quantity);

                await _couponContext.BenefitPoints.UpdateOneAsync(filter, update, new UpdateOptions { IsUpsert = false });
            }
        }

        public async Task<BenefitPoints> FindBenefitPointsByClientIdAsync(int clientId)
        {
            var filter = Builders<BenefitPoints>.Filter.Eq(x => x.ClientId, clientId);
            return await _couponContext.BenefitPoints.Find(filter).FirstOrDefaultAsync();
        }
    }
}
