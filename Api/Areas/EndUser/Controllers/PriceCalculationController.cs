using Application.Services.TripSrv.PriceCalculationSrv.Iface;
using Application.Services.TripSrv.TripSrv.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت  سفر ها
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class PriceCalculationController : ControllerBase
    {
        private readonly IPriceCalculationService _priceCalculationService;
        public PriceCalculationController(IPriceCalculationService priceCalculationService)
        {
            _priceCalculationService = priceCalculationService;
        }

        /// <summary>
        ///  محاسبه قیمت سفر
        /// </summary>
        /// <returns></returns> 
        [HttpPost]
        [ProducesResponseType(typeof(TripSearchDto), 200)]
        public async Task<IActionResult> Post(TripDto dto)
        {
            var search = await _priceCalculationService.CalculateTripPrice(dto);
            return Ok(search);
        }


    }
}
