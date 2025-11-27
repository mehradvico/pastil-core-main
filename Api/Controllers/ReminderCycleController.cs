using Application.Common.Dto.Result;
using Application.Services.ProductSrvs.StoreSrv;
using Application.Services.ProductSrvs.StoreSrv.Dto;
using Application.Services.ReminderSrvs.ReminderCycleSrv.Dto;
using Application.Services.ReminderSrvs.ReminderCycleSrv.Iface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// مدیریت چرخه یادآوری ها
    /// </summary>
    ///
    [Route("api/[controller]")]
    [ApiController]
    public class ReminderCycleController : ControllerBase
    {
        private IReminderCycleService _reminderCycleService;
        /// <summary>
        /// مدیریت چرخه یادآوری ها
        /// </summary>
        ///
        public ReminderCycleController(IReminderCycleService reminderCycleService)
        {
            _reminderCycleService = reminderCycleService;
        }
        /// <summary>
        /// اطلاعات آیتم
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<ReminderCycleDto>), 200)]
        public async Task<IActionResult> Get(long id)
        {
            var result = await _reminderCycleService.FindAsyncVDto(id);
            return Ok(result);
        }
        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 

        [HttpGet()]
        [ProducesResponseType(typeof(ReminderCycleSearchDto), 200)]
        public IActionResult Get([FromQuery] ReminderCycleInputDto dto)
        {
            var result = _reminderCycleService.Search(dto);
            return Ok(result);
        }
    }
}
