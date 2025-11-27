using Application.Services.ReminderSrvs.ReminderTypeSrv.Dto;
using Application.Services.ReminderSrvs.ReminderTypeSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// مدیریت نوع یادآوری ها
    /// </summary>
    ///
    [Route("api/[controller]")]
    [ApiController]
    public class ReminderTypeController : ControllerBase
    {
        private IReminderTypeService _reminderTypeService;
        /// <summary>
        /// مدیریت نوع یادآوری ها
        /// </summary>
        ///
        public ReminderTypeController(IReminderTypeService reminderTypeService)
        {
            _reminderTypeService = reminderTypeService;
        }

        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 

        [HttpGet()]
        [ProducesResponseType(typeof(ReminderTypeSearchDto), 200)]
        public IActionResult Get([FromQuery] ReminderTypeInputDto dto)
        {
            var result = _reminderTypeService.Search(dto);
            return Ok(result);
        }
    }
}
