using Application.Common.DayToDate.Dto;
using Application.Common.DayToDate.Iface;
using Application.Common.Dto.Result;
using Application.Services.CategorySrv.Dto;
using Application.Services.CodeSrv.Dto;
using Application.Services.Setting.CodeSrv.Dto;
using Application.Services.Setting.CodeSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// مدیریت تبدیل روز به تاریخ
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DayToDateController : ControllerBase
    {
        private readonly IDayToDateService _dayToDateService;
        /// <summary>
        /// مدیریت تبدیل روز به تاریخ
        /// </summary>
        public DayToDateController(IDayToDateService dayToDateService)
        {
            this._dayToDateService = dayToDateService;
        }

        /// <summary>
        /// آیتم جدید
        /// </summary>
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultDto<DayToDateDto>), 200)]
        public IActionResult Post(DayToDateDto dto)
        {
            var insertDto = _dayToDateService.GetNextDateByDayNumber(dto);
            return Ok(insertDto);
        }
    }
}
