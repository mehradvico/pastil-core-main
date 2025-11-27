using Application.Common.Dto.Result;
using Application.Services.TripSrv.TripSrv.Dto;
using Application.Services.TripSrv.TripSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت افزودن تخفیف سفر
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class TripSetRebateController : ControllerBase
    {
        private readonly ITripService _tripService;
        public TripSetRebateController(ITripService tripServic)
        {
            _tripService = tripServic;
        }

        /// <summary>
        ///  ویرایش آیتم 
        /// </summary>
        /// <returns>
        /// </returns>
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public async Task<IActionResult> Put(TripSetRebateCodeDto dto)
        {
            var companion = await _tripService.SetRebateCodeAsyncDto(dto);
            return Ok(companion);
        }
    }
}
