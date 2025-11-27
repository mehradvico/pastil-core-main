using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.WeekDaySrv.WeekDaySrv.Dto;
using Application.Services.WeekDaySrv.WeekDaySrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Companion.Controllers
{
    /// <summary>
    /// مدیریت روزهای هفته
    /// </summary>
    /// 
    [Area("Companion")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class WeekDayController : ControllerBase
    {
        private readonly IWeekDayService _weekDayService;
        private readonly ICurrentUserHelper _currentUserHelper;
        public WeekDayController(IWeekDayService weekDayService, ICurrentUserHelper currentUserHelper)
        {
            this._weekDayService = weekDayService;
            this._currentUserHelper = currentUserHelper;
        }

        /// <summary>
        /// جستجو
        /// </summary>
        /// <returns></returns> 
        [HttpGet()]
        [ProducesResponseType(typeof(WeekDaySearchDto), 200)]
        public IActionResult Get([FromQuery] WeekDayInputDto dto)
        {
            var search = _weekDayService.Search(dto);
            return Ok(search);
        }


        /// <summary>
        ///  اطلاعات آیتم 
        /// </summary>
        /// <param name="id">شناسه روز هفته</param>
        /// <returns>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<WeekDayDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var agency = await _weekDayService.FindAsyncDto(id);
            return Ok(agency);
        }
    }
}
