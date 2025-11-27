using Application.Common.Dto.Result;
using Application.Services.TripSrv.TripSrv.Dto;
using Application.Services.TripSrv.TripSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت تغییر وضعیت کیف پول سفر
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class TripSetWalletController : ControllerBase
    {
        private readonly ITripService _tripService;
        public TripSetWalletController(ITripService tripService)
        {
            _tripService = tripService;
        }

        /// <summary>
        ///  ویرایش آیتم 
        /// </summary>
        /// <returns>
        /// </returns>
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public async Task<IActionResult> Put(TripSetWalletDto dto)
        {
            var companion = await _tripService.SetWalletAsyncDto(dto);
            return Ok(companion);
        }
    }
}
