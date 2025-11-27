using Application.Common.Dto.Result;
using Application.Services.TripSrv.TripSrv.Dto;
using Application.Services.TripSrv.TripSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    ///  تغییر وضعیت کاربر برای سفر
    /// </summary>
    ///
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class UpdateTripUserStatusController : ControllerBase
    {
        private ITripService _tripService;
        public UpdateTripUserStatusController(ITripService tripService)
        {
            _tripService = tripService;
        }
        /// <summary>
        /// تغییر وضعیت کاربر
        /// </summary>
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto<TripUserChangeStatusDto>), 200)]
        public async Task<IActionResult> Put(TripUserChangeStatusDto dto)
        {
            var result = await _tripService.UpdateTripUserStatusAsync(dto);
            return Ok(result);
        }
    }
}
