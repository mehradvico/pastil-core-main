using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.TripSrv.TripSrv.Dto;
using Application.Services.TripSrv.TripSrv.Iface;
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
            var Trip = await _tripService.GetUserCurrentTrip(_currentUserHelper.CurrentUser.UserId);
            return Ok(Trip);
        }
        /// <summary>
        /// نمایش اطلاعات کاربر (متن از منابع: nameof(Resources.UserDetails))
        /// </summary>
        /// <returns>
        /// </returns>
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultDto<TripVDto>), 200)]
        public async Task<IActionResult> Post(TripDto trip)
        {
            trip.UserId = _currentUserHelper.CurrentUser.UserId;    
            var Trip = await _tripService.InsertOrUpdateAsync(trip);
            return Ok(Trip);
        }

    }
}
