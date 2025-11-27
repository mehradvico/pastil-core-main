using Application.Common.Dto.Result;
using Application.Services.TripSrv.TripStopSrv.Dto;
using Application.Services.TripSrv.TripStopSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Driver.Controllers
{
    /// <summary>
    /// مدیریت توقف های سفر
    /// </summary>
    /// 
    [Area("Driver")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class TripStopController : ControllerBase
    {
        private readonly ITripStopService _assistanceService;
        public TripStopController(ITripStopService assistanceService)
        {
            this._assistanceService = assistanceService;
        }

        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 
        [HttpGet()]
        [ProducesResponseType(typeof(TripStopSearchDto), 200)]
        public IActionResult Get([FromQuery] TripStopInputDto dto)
        {
            var search = _assistanceService.Search(dto);
            return Ok(search);
        }

        /// <summary>
        ///  اطلاعات آیتم 
        /// </summary>
        /// <param name="id">شناسه خدمات</param>
        /// <returns>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<TripStopDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var agency = await _assistanceService.FindAsyncDto(id);
            return Ok(agency);
        }
    }
}
