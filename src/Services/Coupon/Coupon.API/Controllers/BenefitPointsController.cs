namespace Coupon.API.Controllers
{
    using System.Net;
    using System.Threading.Tasks;
    using Coupon.API.Dtos;
    using Coupon.API.Infrastructure.Models;
    using Coupon.API.Infrastructure.Repositories;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BenefitPointsController : ControllerBase
    {
        private readonly IBenefitPointsRepository _benefitPointsRepository;
        private readonly IMapper<CouponDto, Coupon> _mapper;

        public BenefitPointsController(IBenefitPointsRepository benefitPointsRepository, IMapper<CouponDto, Coupon> mapper)
        {
            _benefitPointsRepository = benefitPointsRepository;
            _mapper = mapper;
        }

        [HttpGet("{clientId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BenefitPoints>> GetBenefitPointsByClientIdAsync(int clientId)
        {
            var benefitPoints = await _benefitPointsRepository.FindBenefitPointsByClientIdAsync(clientId);

            if (benefitPoints is null)
            {
                return NotFound();
            }

            //var couponDto = _mapper.Translate(coupon);

            return benefitPoints;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateQuantityOfBenefitPointsByClientIdAsync([FromBody] BenefitPoints benefitPoints)
        {
            await _benefitPointsRepository.UpdateQuantityOfBenefitPointsByClientIdAsync(benefitPoints);

            return Accepted();
        }
    }
}
