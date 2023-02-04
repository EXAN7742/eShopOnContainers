using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Coupon.API.Infrastructure.Models
{
    public class BenefitPoints
    {
        [BsonIgnoreIfDefault]
        [BsonId]
        [BsonRepresentation(BsonType.Int32)]
        public int ClientId { get; set; }

        public decimal Quantity { get; set; }      
    }
}
