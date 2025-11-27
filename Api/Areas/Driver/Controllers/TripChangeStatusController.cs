using Application.Common.Dto.Result;
using Application.Services.TripSrv.TripSrv.Dto;
using Application.Services.TripSrv.TripSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Driver.Controllers
{
    /// <summary>
    /// مدیریت تغییر وضعیت سفر
    /// </summary>
    /// 
    [Area("Driver")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class TripChangeStatusController : ControllerBase
    {
        private readonly ITripService _assistanceService;
        public TripChangeStatusController(ITripService assistanceService)
        {
            this._assistanceService = assistanceService;
        }
        /// <summary>
        ///  ویرایش آیتم 
        /// </summary>
        /// <returns>
        /// </returns>
        [HttpPut]
        [ProducesResponseType(typeof(BaseResultDto), 200)]
        public async Task<IActionResult> Put(TripChangeStatusDto dto)
        {
            var agency = await _assistanceService.TripChangeStatusAsync(dto);
            return Ok(agency);
        }
    }
}
