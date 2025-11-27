using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.Setting.NoticeSrv.Dto;
using Application.Services.Setting.NoticeSrv.Iface;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Areas.Admin.Controllers
{
    /// <summary>
    /// مدیریت اعلان ها
    /// </summary>
    ///
    [Area("Admin")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class NoticeController : ControllerBase
    {
        private INoticeService _notificationService;
        private ICurrentUserHelper _currentUser;
        /// <summary>
        /// مدیریت اعلان ها
        /// </summary>
        ///
        public NoticeController(INoticeService notificationService, ICurrentUserHelper currentUser)
        {
            _notificationService = notificationService;
            _currentUser = currentUser;
        }
        /// <summary>
        ///  اطلاعات اعلان 
        /// </summary>
        /// <param name="id">شناسه</param>
        /// <returns>
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResultDto<NoticeDto>), 200)]
        public async Task<IActionResult> Get(long id, long? userId)
        {
            var role = await _notificationService.FindAsyncUserDto(id, userId);
            return Ok(role);
        }
        /// <summary>
        ///  جستجو
        /// </summary>
        /// <returns></returns> 

        [HttpGet]
        [ProducesResponseType(typeof(NoticeInputDto), 200)]
        public IActionResult Get([FromQuery] NoticeInputDto dto)
        {
            var searchDto = _notificationService.Search(dto);
            return Ok(searchDto);
        }
    }
}
