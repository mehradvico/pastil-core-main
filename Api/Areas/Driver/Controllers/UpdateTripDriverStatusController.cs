using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.TripSrv.TripSrv.Dto;
using Application.Services.TripSrv.TripSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Driver.Controllers
{
    /// <summary>
    ///  تغییر وضعیت راننده برای سفر
    /// </summary>
    ///
    [Area("Driver")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class UpdateTripDriverStatusController : ControllerBase
    {
        private ITripService _tripService;
        private ICurrentUserHelper _currentUser;
        public UpdateTripDriverStatusController(ITripService tripService, ICurrentUserHelper currentUser)
        {
            _tripService = tripService;
            _currentUser = currentUser;
        }
        /// <summary>
        /// تغییر وضعیت راننده
        /// </summary>
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto<TripDriverChangeStatusDto>), 200)]
        public async Task<IActionResult> Put(TripDriverChangeStatusDto dto)
        {
            dto.DriverId = _currentUser.CurrentUser.DriverId;
            var result = await _tripService.UpdateTripDriverStatusAsync(dto);
            return Ok(result);
        }
    }
}
