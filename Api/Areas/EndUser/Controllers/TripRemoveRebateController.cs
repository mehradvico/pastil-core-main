using Application.Common.Dto.Result;
using Application.Services.TripSrv.TripSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.EndUser.Controllers
{
    /// <summary>
    /// مدیریت حذف تخفیف سفر
    /// </summary>
    /// 
    [Area("EndUser")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class TripRemoveRebateController : ControllerBase
    {
        private readonly ITripService _tripService;
        public TripRemoveRebateController(ITripService tripService)
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
        public async Task<IActionResult> Put(long id)
        {
            var companion = await _tripService.ClearRebateCodeAsync(id);
            return Ok(companion);
        }
    }
}
