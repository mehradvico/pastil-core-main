using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.TripSrv.TripSrv.Dto;
using Application.Services.TripSrv.TripSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Driver.Controllers
{
    /// <summary>
    /// مدیریت  سفر ها
    /// </summary>
    /// 
    [Area("Driver")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class TripCurrentController : ControllerBase
    {
        private readonly ITripService _tripService;
        private readonly ICurrentUserHelper _currentUserHelper;
        public TripCurrentController(ITripService tripService, ICurrentUserHelper currentUserHelper)
        {
            _tripService = tripService;
            _currentUserHelper = currentUserHelper;
        }

        /// <summary>
        ///  سفر جاری 
        /// </summary>
        /// <returns>
        /// </returns>
        [HttpGet]
        [ProducesResponseType(typeof(BaseResultDto<TripVDto>), 200)]
        public async Task<IActionResult> Get()
        {

            var Trip = await _tripService.GetDriverCurrentTrip(_currentUserHelper.CurrentUser.DriverId);
            return Ok(Trip);
        }
    }
}
